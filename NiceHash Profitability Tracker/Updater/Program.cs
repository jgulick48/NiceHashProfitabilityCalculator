using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Updater
{
    public static class Program
    {
        private static dynamic ReleaseInfo;
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting 5 seconds then checking for running processes before update.");
			Thread.Sleep(5);
            DeleteFilesInCurrentDirectory();
            SaveInformationOnLatestRelease();
            DownloadAppDownloader();
            StartUpdateDownloader();
        }
        public static void SaveInformationOnLatestRelease()
        {
			string updaterFolder = Path.Combine(Directory.GetCurrentDirectory(), "Downloader");
            if (!Directory.Exists(updaterFolder))
            {
                Directory.CreateDirectory(updaterFolder);
            }
            ReleaseInfo = DataHelper.GitHubReleases.GetRepoLatestReleaseNumber();
            if (ReleaseInfo != null)
            {
                Console.WriteLine("Writing release information to file.");
                File.WriteAllText(Path.Combine(updaterFolder, "LatestRelease.json"), ReleaseInfo.ToString());
            }
            else
            {
                Console.WriteLine("Error: Unable to find information on latest release.");
                Environment.Exit(1);
            }
        }
        private static void DeleteFilesInCurrentDirectory()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);

            foreach (FileInfo file in di.GetFiles())
            {
                if (!file.Name.Contains("Updater") && !file.Name.Contains("Newtonsoft") && !file.Name.Contains("RunningApp.txt"))
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        private static void DownloadAppDownloader()
        {
            int downloadCount = 0;
            dynamic downloadedAsset = null;
            foreach(dynamic asset in ReleaseInfo.assets)
            {
                if(asset.label == "Downloader")
                {
                    downloadCount++;
                    DataHelper.DownloadHelper.DownLoadFileFromURL(asset.browser_download_url.ToString(), asset.name.ToString());
                    downloadedAsset = asset;
                }
            }
            if(downloadCount != 1)
            {
                Console.WriteLine("Error: Found unexpected number of downloads for asset Downloader.");
                Environment.Exit(1);
            }
            else
            {
				string updaterFolder = "Downloader";
                Directory.CreateDirectory(updaterFolder);
				if (downloadedAsset != null)
				{
					DataHelper.DownloadHelper.ExtractZipFromFile(downloadedAsset.name.ToString(), updaterFolder);
				}
            }
        }
        private static void StartUpdateDownloader()
        {
            ProcessStartInfo psStart = new ProcessStartInfo();
            psStart.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "Downloader");
            psStart.FileName = "Downloader.exe";
            Process.Start(psStart);
        }
    }
}
