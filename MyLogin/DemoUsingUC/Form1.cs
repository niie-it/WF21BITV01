namespace DemoUsingUC
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Vừa nhập {ucLogin1.Username}");
		}
	}
}
