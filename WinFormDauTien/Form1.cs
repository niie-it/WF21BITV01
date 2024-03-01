namespace WinFormDauTien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			double Toan = double.Parse(DiemToan.Text);
			double Ly = double.Parse(DiemLy.Text);
			double Hoa = double.Parse(DiemHoa.Text);

			MessageBox.Show($"Toán {Toan}, Lý {Ly}, Hóa {Hoa}");
		}

		private void DiemLy_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
