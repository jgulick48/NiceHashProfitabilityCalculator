using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NiceHashWorkerMonitor.DataHelper
{
	public class NiceHashAPIHelper
	{
		public static dynamic GetNiceHashData(string uri)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";
			try
			{
				var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
					var result = streamReader.ReadToEnd();
					dynamic returnData = JsonConvert.DeserializeObject(result);
					return returnData;
				}
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
