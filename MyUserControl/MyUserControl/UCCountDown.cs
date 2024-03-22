using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUserControl
{
	public partial class UCCountDown : UserControl
	{
		public UCCountDown()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (timer1.Enabled)
			{
				timer1.Enabled = false;
			}
			else
			{
				//check giá trị hợp lệ
				var pattern = @"\d{2}:\d{2}:\d{2}";
				var result = Regex.Match(TxtDongHo.Text, pattern);
				timer1.Enabled = true;
			}
		}
	}
}
