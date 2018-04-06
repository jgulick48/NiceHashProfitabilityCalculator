using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Updater.DataHelper
{
    public static class DownloadHelper
    {
        public static void DownLoadFileFromURL(string url, string fileName)
        {
            string myStringWebResource = null;
			// Create a new WebClient instance.
			using (WebClient myWebClient = new WebClient())
			{
				// Concatenate the domain with the Web resource filename.
				myStringWebResource = url;
				Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
				// Download the Web resource and save it into the current filesystem folder.
				myWebClient.DownloadFile(myStringWebResource, fileName);
				Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
				Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Environment.CurrentDirectory);
			}
        }
        public static void ExtractZipFromFile(string zipPath, string extractPath)
        {
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
            File.Delete(zipPath);
        }
    }
}
