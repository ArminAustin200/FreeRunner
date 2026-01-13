using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;

namespace FreeRunner_Flashing_Utility.Classes
{
    public static class update
    {
        public sealed class UpdateManifest
        {
            public int revision { get; set; }
            public string zipUrl { get; set; } = "";
            public string md5 { get; set; } = "";         // optional
            public string? changelog { get; set; }        // optional
        }

        // Call this with your current revision number (hardcoded or from assembly)
        public static async Task<bool> CheckAndUpdateFullAsync(
            string updateJsonUrl,
            int currentRevision,
            Action<int>? onProgress = null,
            Action<string>? onStatus = null)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            onStatus?.Invoke("Checking for updates...");

            UpdateManifest manifest;
            using (var wc = new WebClient())
            {
                var json = await wc.DownloadStringTaskAsync(new Uri(updateJsonUrl));
                manifest = JsonSerializer.Deserialize<UpdateManifest>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                    ?? throw new Exception("Invalid update.json");
            }

            if (manifest.revision <= currentRevision)
            {
                onStatus?.Invoke("Up to date.");
                return false;
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

            // MD5 check (matches J-Runner behavior) :contentReference[oaicite:4]{index=4}
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

            
            string oldExePath = currentExePath + ".old";
            try
            {
                if (File.Exists(oldExePath)) File.Delete(oldExePath);

                File.Move(currentExePath, oldExePath);

                using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(zipPath))
                {
                    zip.ExtractAll(appDir, ExtractExistingFileAction.OverwriteSilently);
                }
                File.Delete(zipPath);

                // Relaunch the updated EXE (now extracted)
                string newExePath = Path.Combine(appDir, currentExeName);
                Process.Start(new ProcessStartInfo
                {
                    FileName = newExePath,
                    WorkingDirectory = appDir,
                    UseShellExecute = true
                });

                Environment.Exit(0);
                return true;
            }
            catch
            {
                // Best-effort rollback
                try
                {
                    if (File.Exists(currentExePath)) File.Delete(currentExePath);
                    if (File.Exists(oldExePath)) File.Move(oldExePath, currentExePath);
                }
                catch { /* ignore */ }

                throw;
            }
            finally
            {
                try { if (File.Exists(zipPath)) File.Delete(zipPath); } catch { }
            }
        }

        private static string ComputeMD5(string filePath)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filePath);
            var hash = md5.ComputeHash(stream);
            return Convert.ToHexString(hash);
        }
    }
}
