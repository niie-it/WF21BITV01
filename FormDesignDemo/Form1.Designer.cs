namespace FormDesignDemo
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			TxtUserName = new TextBox();
			TxtPassword = new TextBox();
			BtnLogin = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 20F);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(253, 32);
			label1.Name = "label1";
			label1.Size = new Size(230, 81);
			label1.TabIndex = 0;
			label1.Text = "LOGIN";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(48, 140);
			label2.Name = "label2";
			label2.Size = new Size(197, 48);
			label2.TabIndex = 1;
			label2.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(48, 239);
			label3.Name = "label3";
			label3.Size = new Size(187, 48);
			label3.TabIndex = 2;
			label3.Text = "Password";
			label3.Click += label3_Click;
			// 
			// TxtUserName
			// 
			TxtUserName.Font = new Font("Tahoma", 12F);
			TxtUserName.Location = new Point(252, 131);
			TxtUserName.Name = "TxtUserName";
			TxtUserName.Size = new Size(430, 56);
			TxtUserName.TabIndex = 3;
			// 
			// TxtPassword
			// 
			TxtPassword.Font = new Font("Tahoma", 12F);
			TxtPassword.Location = new Point(253, 236);
			TxtPassword.Name = "TxtPassword";
			TxtPassword.PasswordChar = '@';
			TxtPassword.Size = new Size(430, 56);
			TxtPassword.TabIndex = 4;
			// 
			// BtnLogin
			// 
			BtnLogin.Font = new Font("Tahoma", 12F);
			BtnLogin.Location = new Point(253, 333);
			BtnLogin.Name = "BtnLogin";
			BtnLogin.Size = new Size(188, 58);
			BtnLogin.TabIndex = 5;
			BtnLogin.Text = "LOGIN";
			BtnLogin.UseVisualStyleBackColor = true;
			BtnLogin.Click += BtnLogin_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(BtnLogin);
			Controls.Add(TxtPassword);
			Controls.Add(TxtUserName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "LOGIN";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox TxtUserName;
		private TextBox TxtPassword;
		private Button BtnLogin;
	}
}
