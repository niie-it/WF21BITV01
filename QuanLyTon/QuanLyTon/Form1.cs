namespace QuanLyTon
{
	public partial class Form1 : Form
	{
		static List<HangHoa> HangHoas = new List<HangHoa>()
		{
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="Samsung Galaxy S24", SoLuong = 5, DonGia=23099000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="Iphone 15 Pro 256", SoLuong = 15, DonGia=29099000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="LG ABC", SoLuong = 7, DonGia=13099000},
			new HangHoa{MaHh=Guid.NewGuid(), TenHh="Xiami Note 15", SoLuong = 3, DonGia=12099000},
		};

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = HangHoas;

			CboHangHoa.DisplayMember = "TenHh";
			CboHangHoa.ValueMember = "MaHh";
			CboHangHoa.DataSource = HangHoas;
		}

		private void CboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			var maHHDangChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());

			var hangHoaChon = HangHoas.SingleOrDefault(hh => hh.MaHh == maHHDangChon);
			if (hangHoaChon != null)
			{
				LblDonGia.Text = hangHoaChon.DonGia.ToString("#,##0");
			}
		}

		private void BtnThem_Click(object sender, EventArgs e)
		{
			int SoLuong = Convert.ToInt32(NudSoLuong.Value);
			var maHHDangChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());

			var hangHoaChon = HangHoas.SingleOrDefault(hh => hh.MaHh == maHHDangChon);
			if (hangHoaChon != null)
			{
				hangHoaChon.SoLuong += SoLuong;

				dataGridView1.DataSource = null;
				dataGridView1.DataSource = HangHoas;
			}
		}

		private void BtnBot_Click(object sender, EventArgs e)
		{
			int SoLuong = Convert.ToInt32(NudSoLuong.Value);
			var maHHDangChon = Guid.Parse(CboHangHoa.SelectedValue.ToString());

			var hangHoaChon = HangHoas.SingleOrDefault(hh => hh.MaHh == maHHDangChon);
			if (hangHoaChon != null)
			{
				if (hangHoaChon.SoLuong < SoLuong)
				{
					MessageBox.Show("Không đủ số lượng để bớt");
					return;
				}
				hangHoaChon.SoLuong -= SoLuong;

				dataGridView1.DataSource = null;
				dataGridView1.DataSource = HangHoas;
			}
		}
	}
}
