using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUserControl
{
	public partial class UCDongHo : UserControl
	{
		public UCDongHo()
		{
			InitializeComponent();
		}

		const string START_TEXT = "START";
		const string STOP_TEXT = "STOP";
		DateTime timeStart;
		int lapStep = 0;
		const int LapCount = 5;
		private void BtnStartStop_Click(object sender, EventArgs e)
		{
			if (BtnStartStop.Text == START_TEXT)
			{
				BtnStartStop.Text = STOP_TEXT;
				timer1.Enabled = true;
				timeStart = DateTime.Now;
			}
			else
			{
				BtnStartStop.Text = START_TEXT;
				timer1.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			var duration = DateTime.Now - timeStart;
			LblDongHo.Text = duration.ToString();
		}
	}
}
