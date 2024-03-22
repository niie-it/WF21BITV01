namespace MyLogin
{
	public partial class UCLogin : UserControl
	{
		public string Username
		{
			get { return TxtTenDangNhap.Text; }
			set { TxtTenDangNhap.Text = value; }
		}
		public string Password
		{
			get { return TxtMatKhau.Text; }
			set { TxtMatKhau.Text = value; }
		}
		public UCLogin()
		{
			InitializeComponent();
		}
	}
}
