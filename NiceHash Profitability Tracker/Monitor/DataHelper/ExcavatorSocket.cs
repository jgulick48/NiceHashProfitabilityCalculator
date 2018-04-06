using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Monitor.DataHelper
{
	class ExcavatorSocket
	{
		private static TcpClient _tcpclient;
		protected static List<string> lst_storeddata = new List<string>();
		public static dynamic Client(Objects.MiningRig rig, int id, string method, string[] param)
		{
			try
			{
				_tcpclient = new TcpClient();
				_tcpclient.Connect(rig.IPAddress, rig.Port);
				return HandleCommunication(id, method, param);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public static dynamic HandleCommunication(int id, string method, string[] param)
		{
			StreamReader _sReader = new StreamReader(_tcpclient.GetStream(), Encoding.ASCII);
			StreamWriter _sWriter = new StreamWriter(_tcpclient.GetStream(), Encoding.ASCII);
			JObject requestData = new JObject(
				new JProperty("id", id),
				new JProperty("method", method),
				new JProperty("params",GetJArrayFromStringArray(param)));
			
			_sWriter.WriteLine(requestData.ToString(Formatting.None));
			_sWriter.Flush();

			// receive data
			String sDataIncomming = _sReader.ReadLine();
			dynamic returnData = JsonConvert.DeserializeObject(sDataIncomming);
			_sWriter.Close();
			_tcpclient.Close();
			return returnData;
		}
		public static JArray GetJArrayFromStringArray(string[] param)
		{
			JArray array = new JArray();
			foreach(string para in param)
			{
				array.Add(para);
			}
			return array;
		}
	}
}
