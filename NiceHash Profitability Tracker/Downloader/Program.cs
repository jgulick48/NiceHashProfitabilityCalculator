using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using System.Threading;


namespace Downloader
{
    class Program
    {
        private static dynamic ReleaseInfo;
        private static string InstallFolder;
        private static string RunningApplication;
        static void Main(string[] args)
        {
            Console.WriteLine("Downloader started. Waiting 10 seconds before starting.");
            Thread.Sleep(10000);
            Console.WriteLine("Importing release information from file.");
            ImportReleaseInfoFromFile();
            Console.WriteLine("Getting installation location.");
            GetInstallFolderPath();
            Console.WriteLine("Deleting files from install location.");
            DeleteFilesInInstallDirectory();
            Console.WriteLine("Downloading application.");
            DownloadApplication();
            Console.WriteLine("Saving current release information.");
            SaveInstalledReleaseInformation();
            Console.WriteLine("Application has been downloaded. Checking for previously running app.");
            GetRunningApplication();
            if (!string.IsNullOrEmpty(RunningApplication))
            {
                StartApplication();
            }
            else
            {
                Console.WriteLine("No running application found.  Closing Update Complete.");
            }
        }
        private static void GetInstallFolderPath()
        {
            InstallFolder = "..";
        }
        private static void ImportReleaseInfoFromFile()
        {
            ReleaseInfo = JsonConvert.DeserializeObject(File.ReadAllText("LatestRelease.json"));
        }
        private static void DeleteFilesInInstallDirectory()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(InstallFolder);

            foreach (FileInfo file in di.GetFiles())
            {
                if (!file.Name.Contains("RunningApp.txt"))
                {
                    file.Delete();
                }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                if (!dir.Name.Contains("Downloader") && !dir.Name.Contains("Debug"))
                {
                    dir.Delete(true);
                }
            }
        }
        private static void DownloadApplication()
        {
            int downloadCount = 0;
            dynamic downloadedAsset = null;
            foreach (dynamic asset in ReleaseInfo.assets)
            {
                if (asset.label == "Application")
                {
                    downloadCount++;
                    Updater.DataHelper.DownloadHelper.DownLoadFileFromURL(asset.browser_download_url.ToString(), asset.name.ToString());
                    downloadedAsset = asset;
                }
            }
            if (downloadCount != 1)
            {
                Console.WriteLine("Error: Found unexpected number of downloads for asset Downloader.");
                Environment.Exit(1);
            }
            else
            {
                Updater.DataHelper.DownloadHelper.ExtractZipFromFile(downloadedAsset.name.ToString(), InstallFolder);
            }
        }
        private static void SaveInstalledReleaseInformation()
        {
            File.WriteAllText(Path.Combine(InstallFolder, "CurrentRelease.json"), ReleaseInfo.ToString());
        }
        private static void GetRunningApplication()
        {
            string runningAppFilePath = Path.Combine(InstallFolder, "RunningApp.txt");
            if (File.Exists(runningAppFilePath))
            {
                RunningApplication = File.ReadAllText(runningAppFilePath);
                File.Delete(runningAppFilePath);
            }
        }
        private static void StartApplication()
        {
            ProcessStartInfo psStart = new ProcessStartInfo();
            psStart.WorkingDirectory = "..";
            psStart.FileName = Path.Combine(InstallFolder, RunningApplication);
            Process.Start(psStart);
        }
    }
}
