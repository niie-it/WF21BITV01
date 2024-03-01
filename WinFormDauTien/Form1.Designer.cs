namespace WinFormDauTien
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
			DiemToan = new TextBox();
			DiemLy = new TextBox();
			DiemHoa = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F);
			label1.Location = new Point(67, 103);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(194, 46);
			label1.TabIndex = 0;
			label1.Text = "Điểm Toán";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F);
			label2.Location = new Point(67, 185);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(161, 46);
			label2.TabIndex = 1;
			label2.Text = "Điểm Lý";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 12F);
			label3.Location = new Point(83, 267);
			label3.Margin = new Padding(6, 0, 6, 0);
			label3.Name = "label3";
			label3.Size = new Size(184, 46);
			label3.TabIndex = 2;
			label3.Text = "Điểm Hóa";
			// 
			// DiemToan
			// 
			DiemToan.Font = new Font("Times New Roman", 12F);
			DiemToan.Location = new Point(270, 100);
			DiemToan.Name = "DiemToan";
			DiemToan.Size = new Size(250, 53);
			DiemToan.TabIndex = 3;
			// 
			// DiemLy
			// 
			DiemLy.Font = new Font("Times New Roman", 12F);
			DiemLy.Location = new Point(271, 203);
			DiemLy.Name = "DiemLy";
			DiemLy.Size = new Size(250, 53);
			DiemLy.TabIndex = 4;
			DiemLy.TextChanged += DiemLy_TextChanged;
			// 
			// DiemHoa
			// 
			DiemHoa.Font = new Font("Times New Roman", 12F);
			DiemHoa.Location = new Point(271, 281);
			DiemHoa.Name = "DiemHoa";
			DiemHoa.Size = new Size(250, 53);
			DiemHoa.TabIndex = 5;
			// 
			// button1
			// 
			button1.Font = new Font("Times New Roman", 12F);
			button1.Location = new Point(566, 118);
			button1.Name = "button1";
			button1.Size = new Size(400, 181);
			button1.TabIndex = 6;
			button1.Text = "Tính Điểm & Xếp hạng";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1057, 429);
			Controls.Add(button1);
			Controls.Add(DiemHoa);
			Controls.Add(DiemLy);
			Controls.Add(DiemToan);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(6);
			Name = "Form1";
			Text = "Tính điểm - Xếp hạng";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox DiemToan;
		private TextBox DiemLy;
		private TextBox DiemHoa;
		private Button button1;
	}
}
