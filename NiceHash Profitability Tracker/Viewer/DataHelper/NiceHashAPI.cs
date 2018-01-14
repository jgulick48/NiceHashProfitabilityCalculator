using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace Viewer.DataHelper
{
	public static class NiceHashAPI
	{
		public static float GetBalance(string WalletAddress)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nicehash.com/api?method=stats.provider&addr=" + WalletAddress);
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";
			try
			{
				var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
					var result = streamReader.ReadToEnd();
					dynamic returnData = JsonConvert.DeserializeObject(result);
					if (returnData != null)
					{
						float newBal = getBalanceFromResults(returnData.result.stats);
						return newBal;
					}
					return 0.0f;
				}
			}
			catch (Exception ex)
			{
				return 0.0f;
			}
		}
		private static float getBalanceFromResults(dynamic stats)
		{
			float total = 0;
			foreach (dynamic stat in stats)
			{
				float balance = 0;
				if (float.TryParse(stat.balance.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out balance))
				{
					total += balance;
				}
				else
				{
				}
			}
			return total;
		}
	}
}
