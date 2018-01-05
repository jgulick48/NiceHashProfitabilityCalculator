using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceHashWorkerMonitor
{
	public partial class NiceHashWorkerMonitor : Form
	{
		public NiceHashWorkerMonitor()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataHelper.ExcavatorSocket sock = new DataHelper.ExcavatorSocket();
			MessageBox.Show(sock.Client("127.0.0.1",1,"device.list",new string[0]).ToString());

		}
	}
}
