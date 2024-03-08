namespace FormDesignDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			// Kiểm tra nếu username, password trống thì xuất hiện cảnh báo và yêu cầu nhập lại
			string username = TxtUserName.Text.Trim();
			string password = TxtPassword.Text.Trim();
			if (username.Length == 0 || password.Length == 0)
			{
				MessageBox.Show("Chưa hợp lệ! Nhập lại!");
				return;
			}

			// Password tối thiểu 5 kí tự
			if (password.Length < 5)
			{
				MessageBox.Show("Mật khẩu phải tối thiểu 5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Password phải chứa tối thiểu 1 chữ hoa, 1 chữ thường, 1 kí tự đặc biệt, không được chứa khoảng trắng
			if (password.Any(char.IsUpper) && password.Any(char.IsLower) && !password.Contains(" "))
			{
				// ok => Chúc mừng đăng nhập thành công
				MessageBox.Show("Đăng nhập thành công!");
			}
			else
			{
				MessageBox.Show("Mật khẩu tối thiểu 1 chữ hoa, 1 chữ thường, không chứa khoảng trắng");
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
