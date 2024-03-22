namespace DemoUserControl
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			myClock1 = new MyUserControl.MyClock();
			myClock2 = new MyUserControl.MyClock();
			SuspendLayout();
			// 
			// myClock1
			// 
			myClock1.Location = new Point(-2, -2);
			myClock1.Name = "myClock1";
			myClock1.Size = new Size(525, 218);
			myClock1.TabIndex = 0;
			// 
			// myClock2
			// 
			myClock2.Location = new Point(26, 222);
			myClock2.Name = "myClock2";
			myClock2.Size = new Size(507, 216);
			myClock2.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(myClock2);
			Controls.Add(myClock1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private MyUserControl.MyClock myClock1;
		private MyUserControl.MyClock myClock2;
	}
}
