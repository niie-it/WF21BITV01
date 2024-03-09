namespace QuanLyTon
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
			CboHangHoa = new ComboBox();
			NudSoLuong = new NumericUpDown();
			BtnThem = new Button();
			BtnBot = new Button();
			LblDonGia = new Label();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)NudSoLuong).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(20, 18);
			label1.Name = "label1";
			label1.Size = new Size(190, 48);
			label1.TabIndex = 0;
			label1.Text = "Hàng hóa";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(644, 9);
			label2.Name = "label2";
			label2.Size = new Size(177, 48);
			label2.TabIndex = 1;
			label2.Text = "Số lượng";
			// 
			// CboHangHoa
			// 
			CboHangHoa.Font = new Font("Tahoma", 12F);
			CboHangHoa.FormattingEnabled = true;
			CboHangHoa.Location = new Point(20, 94);
			CboHangHoa.Name = "CboHangHoa";
			CboHangHoa.Size = new Size(586, 56);
			CboHangHoa.TabIndex = 2;
			CboHangHoa.SelectedIndexChanged += CboHangHoa_SelectedIndexChanged;
			// 
			// NudSoLuong
			// 
			NudSoLuong.Font = new Font("Tahoma", 12F);
			NudSoLuong.Location = new Point(644, 85);
			NudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			NudSoLuong.Name = "NudSoLuong";
			NudSoLuong.Size = new Size(300, 56);
			NudSoLuong.TabIndex = 3;
			NudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// BtnThem
			// 
			BtnThem.Font = new Font("Tahoma", 12F);
			BtnThem.Location = new Point(1001, 87);
			BtnThem.Name = "BtnThem";
			BtnThem.Size = new Size(188, 58);
			BtnThem.TabIndex = 4;
			BtnThem.Text = "Thêm";
			BtnThem.UseVisualStyleBackColor = true;
			BtnThem.Click += BtnThem_Click;
			// 
			// BtnBot
			// 
			BtnBot.Font = new Font("Tahoma", 12F);
			BtnBot.Location = new Point(1206, 87);
			BtnBot.Name = "BtnBot";
			BtnBot.Size = new Size(188, 58);
			BtnBot.TabIndex = 5;
			BtnBot.Text = "Bớt";
			BtnBot.UseVisualStyleBackColor = true;
			BtnBot.Click += BtnBot_Click;
			// 
			// LblDonGia
			// 
			LblDonGia.AutoSize = true;
			LblDonGia.Font = new Font("Tahoma", 12F);
			LblDonGia.ForeColor = Color.Red;
			LblDonGia.Location = new Point(22, 173);
			LblDonGia.Name = "LblDonGia";
			LblDonGia.Size = new Size(77, 48);
			LblDonGia.TabIndex = 6;
			LblDonGia.Text = "Giá";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(20, 284);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 102;
			dataGridView1.Size = new Size(1374, 507);
			dataGridView1.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1406, 803);
			Controls.Add(dataGridView1);
			Controls.Add(LblDonGia);
			Controls.Add(BtnBot);
			Controls.Add(BtnThem);
			Controls.Add(NudSoLuong);
			Controls.Add(CboHangHoa);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "QUẢN LÝ HÀNG HÓA TỒN";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)NudSoLuong).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox CboHangHoa;
		private NumericUpDown NudSoLuong;
		private Button BtnThem;
		private Button BtnBot;
		private Label LblDonGia;
		private DataGridView dataGridView1;
	}
}
