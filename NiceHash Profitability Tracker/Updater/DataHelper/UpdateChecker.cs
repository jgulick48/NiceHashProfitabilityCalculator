using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Monitor.DataHelper
{
    public class UpdateChecker
    {
        static dynamic CurrentRelease;
        public static string NewReleaseURL;
        private static string ReleaseFilePath = Path.Combine(Environment.CurrentDirectory, "CurrentRelease.json");
        public static bool CheckForUpdatedRelease()
        {
            if (LoadCurrentRelease())
            {
                return CheckCurrentReleaseAgainstLatest();
            }
            else
            {
                return false;
            }
            return false;
        }
        private static bool LoadCurrentRelease()
        {
            if (File.Exists(ReleaseFilePath))
            {
                CurrentRelease = JsonConvert.DeserializeObject(File.ReadAllText(ReleaseFilePath));
                return true;
            }
            else
            {
                CurrentRelease = Updater.DataHelper.GitHubReleases.GetRepoLatestReleaseNumber();
                File.WriteAllText(ReleaseFilePath, CurrentRelease.ToString());
                return false;
            }
        }
        private static bool CheckCurrentReleaseAgainstLatest()
        {
            dynamic LatestRelease = Updater.DataHelper.GitHubReleases.GetRepoLatestReleaseNumber();
            if (LatestRelease.id > CurrentRelease.id)
            {
                NewReleaseURL = LatestRelease.html_url;
                return true;
            }
            return false;
        }
    }
}
