namespace SimpleEmployeeApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnThem_Click(object sender, EventArgs e)
		{
			//TODO: Validate cho dữ liệu nhập

			//Tạo item cho ListView
			ListViewItem lvi = LvNhanVien.Items.Add(TxtHoTen.Text);
			lvi.SubItems.Add(DtpNgaySinh.Value.ToShortDateString());
			lvi.SubItems.Add(TxtDienThoai.Text);
			lvi.SubItems.Add(TxtDiaChi.Text);
		}

		private void LvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			// check xem có chọn dòng nào không?
			if (LvNhanVien.SelectedItems.Count > 0)
			{
				var selectedItem = LvNhanVien.SelectedItems[0] as ListViewItem;
				TxtHoTen.Text = selectedItem.SubItems[0].Text;
				DtpNgaySinh.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
				TxtDienThoai.Text = selectedItem.SubItems[2].Text;
				TxtDiaChi.Text = selectedItem.SubItems[3].Text;
			}
		}

		private void BtnXoa_Click(object sender, EventArgs e)
		{
			if (LvNhanVien.SelectedItems.Count > 0)
			{
				if (MessageBox.Show($"Bạn chắc xóa nhân viên {LvNhanVien.SelectedItems[0].Text} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					LvNhanVien.Items.Remove(LvNhanVien.SelectedItems[0]);
				}
			}
		}

		private void BtnSua_Click(object sender, EventArgs e)
		{
			if (LvNhanVien.SelectedItems.Count > 0)
			{
				var selectedItem = LvNhanVien.SelectedItems[0] as ListViewItem;
				selectedItem.SubItems[0].Text = TxtHoTen.Text;
				selectedItem.SubItems[1].Text = DtpNgaySinh.Text;
				selectedItem.SubItems[2].Text = TxtDienThoai.Text;
				selectedItem.SubItems[3].Text = TxtDiaChi.Text;
			}
		}
	}
}
