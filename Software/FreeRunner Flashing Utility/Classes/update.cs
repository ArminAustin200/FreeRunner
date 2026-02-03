using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json;

namespace FreeRunner_Flashing_Utility.Classes
{
    public static class update
    {
        public sealed class UpdateManifest
        {
            public int revision { get; set; }
            public string zipUrl { get; set; } = "";
            public string md5 { get; set; } = "";       
            public string? changelog { get; set; }
        }

        //Call with current program revision number
        public static async Task<bool> CheckAndUpdateFullAsync(
            string updateJsonUrl,
            int currentRevision,
            Action<int>? onProgress = null,
            Action<string>? onStatus = null,
            Action<string>? onChangelog = null)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            onStatus?.Invoke("Checking for updates...");

            await Task.Delay(1500);

            UpdateManifest manifest;
            using (var wc = new WebClient())
            {
                var json = await wc.DownloadStringTaskAsync(new Uri(updateJsonUrl));
                manifest = JsonSerializer.Deserialize<UpdateManifest>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                    ?? throw new Exception("Invalid update.json");
            }

            if (manifest.revision <= currentRevision) {
                onStatus?.Invoke("Up to date.");

                onChangelog?.Invoke(manifest.changelog ?? "");
                return false;
            }

            //If the manifest revision is newer than the current
            if (manifest.revision > currentRevision) {
                SystemSounds.Asterisk.Play();

                //Showing update dialogue
                using (var dlg = new changelog(manifest.revision, manifest.changelog)) {
                    dlg.setUserControl(false);
                    dlg.ShowDialog();
                }
            }

            if (string.IsNullOrWhiteSpace(manifest.zipUrl))
                throw new Exception("update.json missing zipUrl");

            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string currentExePath = Process.GetCurrentProcess().MainModule!.FileName!;
            string currentExeName = Path.GetFileName(currentExePath);

            string zipPath = Path.Combine(appDir, "full.zip");
            if (File.Exists(zipPath)) File.Delete(zipPath);

            onStatus?.Invoke("Downloading update...");
            using (var wc = new WebClient())
            {
                wc.DownloadProgressChanged += (s, e) => onProgress?.Invoke(e.ProgressPercentage);
                await wc.DownloadFileTaskAsync(new Uri(manifest.zipUrl), zipPath);
            }

            await Task.Delay(1000);

            //MD5 check 
            if (!string.IsNullOrWhiteSpace(manifest.md5))
            {
                onStatus?.Invoke("Verifying package...");
                var got = ComputeMD5(zipPath);
                if (!got.Equals(manifest.md5, StringComparison.OrdinalIgnoreCase))
                {
                    File.Delete(zipPath);
                    throw new Exception("Package checksum is invalid (MD5 mismatch).");
                }
            }

            onStatus?.Invoke("Installing update...");

            //Figure out current exe and paths
            string exePath = Process.GetCurrentProcess().MainModule!.FileName!;
            string appDirReal = Path.GetDirectoryName(exePath)!;   //use real dir of the running exe
            string exeName = Path.GetFileName(exePath);
            string backupPath = Path.Combine(appDirReal, exeName + ".old");

            try
            {
                //1) Backup current EXE
                if (File.Exists(backupPath))
                    File.Delete(backupPath);

                File.Move(exePath, backupPath);

                //2) Extract ZIP directly into app folder, overwriting everything
                using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(zipPath))
                {
                    zip.ExtractAll(appDirReal, ExtractExistingFileAction.OverwriteSilently);
                }

                //3) Remove the zip
                File.Delete(zipPath);

                //4) Start the new EXE from the same location
                onStatus?.Invoke("Update installed. Restarting...");
                Process.Start(new ProcessStartInfo
                {
                    FileName = Path.Combine(appDirReal, exeName),
                    WorkingDirectory = appDirReal,
                    UseShellExecute = true
                });

                //5) Exit current process so the new one takes over
                Environment.Exit(0);
                return true;
            }
            catch (Exception ex)
            {
                try { if (File.Exists(zipPath)) File.Delete(zipPath); } catch { }

                onStatus?.Invoke("Failed to install update: " + ex.Message);
                return false;
            }
        }

        //Function to compute MD5 hash
        private static string ComputeMD5(string filePath)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filePath);
            var hash = md5.ComputeHash(stream);
            return Convert.ToHexString(hash);
        }
    }
}
