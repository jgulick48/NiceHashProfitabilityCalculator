using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NiceHashProfitabilityCalculatorUpdater.DataHelper
{
    public static class GitHubReleases
    {
        public static dynamic GetRepoLatestReleaseNumber()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/repos/jgulick48/NiceHashProfitabilityCalculator/releases");
            httpWebRequest.Method = "GET";
            httpWebRequest.UserAgent = "NHPCApi";
            httpWebRequest.KeepAlive = false;
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic returnData = JsonConvert.DeserializeObject(result);
                    return returnData[0];
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
