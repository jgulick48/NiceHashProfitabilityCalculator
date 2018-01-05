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

namespace NiceHashWorkerMonitor.DataHelper
{
	class ExcavatorSocket
	{
		private TcpClient _tcpclient;

		private StreamReader _sReader;
		private StreamWriter _sWriter;
		public static List<string> lst_storeddata = new List<string>();

		private Boolean _isConnected;
		public dynamic Client(string ipAddress, int id, string method, string[] param)
		{
			//server ip
			//String ipAddress = "192.168.43.15";
			//port number
			int portNum = 4000;
			try
			{
				_tcpclient = new TcpClient();
				_tcpclient.Connect(ipAddress, portNum);
				return HandleCommunication(id, method, param);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public dynamic HandleCommunication(int id, string method, string[] param)
		{
			_sReader = new StreamReader(_tcpclient.GetStream(), Encoding.ASCII);
			_sWriter = new StreamWriter(_tcpclient.GetStream(), Encoding.ASCII);
			JObject requestData = new JObject(
				new JProperty("id", id),
				new JProperty("method", method),
				new JProperty("params",GetJArrayFromStringArray(param)));
			
			_sWriter.WriteLine(requestData.ToString(Formatting.None));
			string temp = requestData.ToString(Formatting.None);
			_sWriter.Flush();

			// receive data
			String sDataIncomming = _sReader.ReadLine();
			dynamic returnData = JsonConvert.DeserializeObject(sDataIncomming);
			_sWriter.Close();
			_tcpclient.Close();
			return returnData;
		}
		public JArray GetJArrayFromStringArray(string[] param)
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
