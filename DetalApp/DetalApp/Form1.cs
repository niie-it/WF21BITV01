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

namespace DetalApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void EnableControl(bool enable = true)
		{
			ChkCaoVoi.Enabled = enable;
			ChkTayTrang.Enabled = enable;
			NudNhoRang.Enabled = enable;
			NudTramRang.Enabled = enable;
			BtnTinhTien.Enabled = enable;
			BtnLuuFile.Enabled = enable;
			BtnXoa.Enabled = enable;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EnableControl(false);
		}

		private void TxtHoTenKhachHang_TextChanged(object sender, EventArgs e)
		{
			if (TxtHoTenKhachHang.Text.Trim().Length > 0)
			{
				EnableControl(true);
			}
			else
			{
				EnableControl(false);
			}
		}

		int tongTien = 0;
		private void BtnTinhTien_Click(object sender, EventArgs e)
		{
			if (ChkCaoVoi.Checked)
			{
				tongTien += 100000;
			}
			if (ChkTayTrang.Checked)
			{
				tongTien += 1500000;
			}
			tongTien += Convert.ToInt32(NudNhoRang.Value) * 500000;
			tongTien += Convert.ToInt32(NudTramRang.Value) * 200000;

			TxtTongTien.Text = tongTien.ToString("#,##0") + " đ";
			MessageBox.Show($"Khách hàng: {TxtHoTenKhachHang.Text.Trim()} cần trả số tiền {tongTien.ToString("#,##0")} đ");
		}

		private void BtnLuuFile_Click(object sender, EventArgs e)
		{
			List<string> data = new List<string>()
			{
				"Họ tên: " + TxtHoTenKhachHang.Text.Trim(),
				$"Tổng tiền: {tongTien.ToString("#,##0")} đ"
			};
			File.WriteAllLines("data.txt", data);
		}

		private void BtnXoa_Click(object sender, EventArgs e)
		{
			TxtHoTenKhachHang.Clear();
			TxtTongTien.Clear();
			ChkCaoVoi.Checked = false;
			ChkTayTrang.Checked = false;
			NudNhoRang.Value = 0;
			NudTramRang.Value = 0;
		}

		private void BtnThoat_Click(object sender, EventArgs e)
		{
			var traLoi = MessageBox.Show("Bạn muốn có đóng chương trình không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (traLoi == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
