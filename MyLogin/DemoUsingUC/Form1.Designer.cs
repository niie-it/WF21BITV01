namespace DemoUsingUC
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
			ucLogin1 = new MyLogin.UCLogin();
			button1 = new Button();
			ucDongHo1 = new MyUserControl.UCDongHo();
			SuspendLayout();
			// 
			// ucLogin1
			// 
			ucLogin1.Location = new Point(12, 12);
			ucLogin1.Name = "ucLogin1";
			ucLogin1.Password = "";
			ucLogin1.Size = new Size(688, 224);
			ucLogin1.TabIndex = 0;
			ucLogin1.Username = "";
			// 
			// button1
			// 
			button1.Location = new Point(724, 62);
			button1.Name = "button1";
			button1.Size = new Size(196, 111);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ucDongHo1
			// 
			ucDongHo1.Location = new Point(179, 261);
			ucDongHo1.Name = "ucDongHo1";
			ucDongHo1.Size = new Size(521, 250);
			ucDongHo1.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(953, 574);
			Controls.Add(ucDongHo1);
			Controls.Add(button1);
			Controls.Add(ucLogin1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private MyLogin.UCLogin ucLogin1;
		private Button button1;
		private MyUserControl.UCDongHo ucDongHo1;
	}
}
