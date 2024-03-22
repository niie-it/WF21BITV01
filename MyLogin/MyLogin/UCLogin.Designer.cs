namespace MyLogin
{
	partial class UCLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			TxtTenDangNhap = new TextBox();
			TxtMatKhau = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(13, 28);
			label1.Name = "label1";
			label1.Size = new Size(287, 48);
			label1.TabIndex = 0;
			label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(22, 129);
			label2.Name = "label2";
			label2.Size = new Size(183, 48);
			label2.TabIndex = 1;
			label2.Text = "Mật khẩu";
			// 
			// TxtTenDangNhap
			// 
			TxtTenDangNhap.Font = new Font("Tahoma", 12F);
			TxtTenDangNhap.Location = new Point(306, 20);
			TxtTenDangNhap.Name = "TxtTenDangNhap";
			TxtTenDangNhap.Size = new Size(333, 56);
			TxtTenDangNhap.TabIndex = 2;
			// 
			// TxtMatKhau
			// 
			TxtMatKhau.Font = new Font("Tahoma", 12F);
			TxtMatKhau.Location = new Point(306, 121);
			TxtMatKhau.Name = "TxtMatKhau";
			TxtMatKhau.PasswordChar = '$';
			TxtMatKhau.Size = new Size(333, 56);
			TxtMatKhau.TabIndex = 3;
			// 
			// UCLogin
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(TxtMatKhau);
			Controls.Add(TxtTenDangNhap);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "UCLogin";
			Size = new Size(669, 219);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox TxtTenDangNhap;
		private TextBox TxtMatKhau;
	}
}
