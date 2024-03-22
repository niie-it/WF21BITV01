namespace MyUserControl
{
	public partial class MyClock : UserControl
	{
		public MyClock()
		{
			InitializeComponent();
		}

		const string START_TEXT = "START";
		const string STOP_TEXT = "STOP";
		DateTime timeStart;
		private void BtnStart_Click(object sender, EventArgs e)
		{
			if (BtnStart.Text == START_TEXT)
			{
				BtnStart.Text = STOP_TEXT;
				timer1.Enabled = true;
				timeStart = DateTime.Now;
			}
			else
			{
				BtnStart.Text = START_TEXT;
				timer1.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LblDongHo.Text = (DateTime.Now - timeStart).ToString();
		}
	}
}
