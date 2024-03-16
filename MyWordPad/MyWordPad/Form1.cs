using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWordPad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt K");
		}

		private void toolStripBtnSave_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			sfd.Title = "Lưu file";
			sfd.Filter = "Text|*.txt|Word Pad|*.rtf";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(sfd.FileName);
				if (Path.GetExtension(sfd.FileName).ToLower() == ".txt")
				{
					File.WriteAllText(sfd.FileName, RtbDoc.Text);
				}
				else if (Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
				{
					RtbDoc.SaveFile(sfd.FileName);
				}
			}
		}

		private void XuLyOpenFile(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.Title = "Mở file";
			ofd.Filter = "Text|*.txt|Word Pad|*.rtf|All file|*.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
				{
					RtbDoc.Text = File.ReadAllText(ofd.FileName);
				}
				else if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
				{
					RtbDoc.LoadFile(ofd.FileName);
				}
			}
		}
	}
}
