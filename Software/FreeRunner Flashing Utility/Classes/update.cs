using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
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

            // MD5 check 
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

            string stageDir = Path.Combine(appDir, "_update_tmp");
            string cmdPath = Path.Combine(appDir, "_apply_update.cmd");

            if (Directory.Exists(stageDir))
                Directory.Delete(stageDir, true);

            Directory.CreateDirectory(stageDir);

            // Extract ZIP into staging(NOT appDir)
            using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(zipPath)) {
                zip.ExtractAll(stageDir, ExtractExistingFileAction.OverwriteSilently);
            }
            File.Delete(zipPath);

            // Write + run apply script (copies folders too)
            WriteApplyScript(cmdPath, appDir, stageDir, currentExeName);

            Process.Start(new ProcessStartInfo {
                FileName = cmdPath,
                WorkingDirectory = appDir,
                UseShellExecute = true,
                CreateNoWindow = true
            });

            // Exit so nothing is locked
            Environment.Exit(0);
            return true;
        }

        private static string ComputeMD5(string filePath)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filePath);
            var hash = md5.ComputeHash(stream);
            return Convert.ToHexString(hash);
        }

        static void WriteApplyScript(string cmdPath, string appDir, string stageDir, string exeName)
        {
            // Exclude files/folders you never want overwritten (edit as needed)
            // Example: keep user config, logs, or NAND dumps
            string excludeFiles = "user.config settings.json";
            string excludeDirs = "Logs Dumps";

            string script =
            $@"@echo off
            setlocal
            cd /d ""{appDir}""

                REM wait a moment for the app to fully exit
                timeout /t 2 /nobreak >nul

                REM Copy everything (folders included) from staging into the app folder
                REM /E = include subdirs, /R /W = retry settings, /NFL /NDL = quieter output
                robocopy ""{stageDir}"" ""{appDir}"" /E /R:2 /W:1 /NFL /NDL /NP /NJH /NJS ^
                    /XF {excludeFiles} ^
                    /XD {excludeDirs}

                REM cleanup staging
                rmdir /s /q ""{stageDir}""

                REM restart updated app
                start """" ""{Path.Combine(appDir, exeName)}""
                endlocal
            ";

            File.WriteAllText(cmdPath, script);
        }
    }
}
