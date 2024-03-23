namespace SimpleEmployeeApp
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
			groupBox1 = new GroupBox();
			DtpNgaySinh = new DateTimePicker();
			TxtDienThoai = new MaskedTextBox();
			TxtDiaChi = new TextBox();
			TxtHoTen = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			groupBox2 = new GroupBox();
			BtnThoat = new Button();
			BtnSua = new Button();
			BtnXoa = new Button();
			BtnThem = new Button();
			groupBox3 = new GroupBox();
			LvNhanVien = new ListView();
			ColHoTen = new ColumnHeader();
			ColDienThoai = new ColumnHeader();
			ColNgaySinh = new ColumnHeader();
			ColDiaChi = new ColumnHeader();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 20F);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(447, 39);
			label1.Name = "label1";
			label1.Size = new Size(732, 81);
			label1.TabIndex = 0;
			label1.Text = "DANH MỤC NHÂN VIÊN";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(DtpNgaySinh);
			groupBox1.Controls.Add(TxtDienThoai);
			groupBox1.Controls.Add(TxtDiaChi);
			groupBox1.Controls.Add(TxtHoTen);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Tahoma", 12F);
			groupBox1.Location = new Point(12, 147);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1683, 290);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin chi tiết";
			// 
			// DtpNgaySinh
			// 
			DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			DtpNgaySinh.Font = new Font("Tahoma", 12F);
			DtpNgaySinh.Format = DateTimePickerFormat.Custom;
			DtpNgaySinh.Location = new Point(1273, 187);
			DtpNgaySinh.Name = "DtpNgaySinh";
			DtpNgaySinh.Size = new Size(358, 56);
			DtpNgaySinh.TabIndex = 7;
			// 
			// TxtDienThoai
			// 
			TxtDienThoai.Font = new Font("Tahoma", 12F);
			TxtDienThoai.Location = new Point(1273, 80);
			TxtDienThoai.Mask = "(999) 000-0000";
			TxtDienThoai.Name = "TxtDienThoai";
			TxtDienThoai.Size = new Size(358, 56);
			TxtDienThoai.TabIndex = 6;
			// 
			// TxtDiaChi
			// 
			TxtDiaChi.Font = new Font("Tahoma", 12F);
			TxtDiaChi.Location = new Point(288, 174);
			TxtDiaChi.Name = "TxtDiaChi";
			TxtDiaChi.Size = new Size(611, 56);
			TxtDiaChi.TabIndex = 5;
			// 
			// TxtHoTen
			// 
			TxtHoTen.Font = new Font("Tahoma", 12F);
			TxtHoTen.Location = new Point(291, 92);
			TxtHoTen.Name = "TxtHoTen";
			TxtHoTen.Size = new Size(608, 56);
			TxtHoTen.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F);
			label5.Location = new Point(1038, 187);
			label5.Name = "label5";
			label5.Size = new Size(194, 48);
			label5.TabIndex = 3;
			label5.Text = "Ngày sinh";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Tahoma", 12F);
			label4.Location = new Point(1034, 81);
			label4.Name = "label4";
			label4.Size = new Size(200, 48);
			label4.TabIndex = 2;
			label4.Text = "Điện thoại";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 12F);
			label3.Location = new Point(51, 177);
			label3.Name = "label3";
			label3.Size = new Size(140, 48);
			label3.TabIndex = 1;
			label3.Text = "Địa chỉ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 12F);
			label2.Location = new Point(50, 95);
			label2.Name = "label2";
			label2.Size = new Size(138, 48);
			label2.TabIndex = 0;
			label2.Text = "Họ tên";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(BtnThoat);
			groupBox2.Controls.Add(BtnSua);
			groupBox2.Controls.Add(BtnXoa);
			groupBox2.Controls.Add(BtnThem);
			groupBox2.Font = new Font("Tahoma", 12F);
			groupBox2.Location = new Point(563, 479);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1060, 239);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			// 
			// BtnThoat
			// 
			BtnThoat.Font = new Font("Tahoma", 12F);
			BtnThoat.Location = new Point(779, 68);
			BtnThoat.Name = "BtnThoat";
			BtnThoat.Size = new Size(217, 125);
			BtnThoat.TabIndex = 0;
			BtnThoat.Text = "Thoát";
			BtnThoat.UseVisualStyleBackColor = true;
			// 
			// BtnSua
			// 
			BtnSua.Font = new Font("Tahoma", 12F);
			BtnSua.Location = new Point(537, 68);
			BtnSua.Name = "BtnSua";
			BtnSua.Size = new Size(217, 125);
			BtnSua.TabIndex = 0;
			BtnSua.Text = "&Sửa";
			BtnSua.UseVisualStyleBackColor = true;
			BtnSua.Click += BtnSua_Click;
			// 
			// BtnXoa
			// 
			BtnXoa.Font = new Font("Tahoma", 12F);
			BtnXoa.Location = new Point(299, 68);
			BtnXoa.Name = "BtnXoa";
			BtnXoa.Size = new Size(217, 125);
			BtnXoa.TabIndex = 0;
			BtnXoa.Text = "&Xóa";
			BtnXoa.UseVisualStyleBackColor = true;
			BtnXoa.Click += BtnXoa_Click;
			// 
			// BtnThem
			// 
			BtnThem.Font = new Font("Tahoma", 12F);
			BtnThem.Location = new Point(57, 68);
			BtnThem.Name = "BtnThem";
			BtnThem.Size = new Size(217, 125);
			BtnThem.TabIndex = 0;
			BtnThem.Text = "&Thêm";
			BtnThem.UseVisualStyleBackColor = true;
			BtnThem.Click += BtnThem_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(LvNhanVien);
			groupBox3.Font = new Font("Tahoma", 12F);
			groupBox3.Location = new Point(12, 724);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(1696, 448);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Thông tin chung";
			// 
			// LvNhanVien
			// 
			LvNhanVien.Columns.AddRange(new ColumnHeader[] { ColHoTen, ColDienThoai, ColNgaySinh, ColDiaChi });
			LvNhanVien.Dock = DockStyle.Fill;
			LvNhanVien.Font = new Font("Tahoma", 12F);
			LvNhanVien.FullRowSelect = true;
			LvNhanVien.GridLines = true;
			LvNhanVien.Location = new Point(3, 52);
			LvNhanVien.Name = "LvNhanVien";
			LvNhanVien.Size = new Size(1690, 393);
			LvNhanVien.TabIndex = 0;
			LvNhanVien.UseCompatibleStateImageBehavior = false;
			LvNhanVien.View = View.Details;
			LvNhanVien.SelectedIndexChanged += LvNhanVien_SelectedIndexChanged;
			// 
			// ColHoTen
			// 
			ColHoTen.Text = "Họ tên";
			ColHoTen.Width = 300;
			// 
			// ColDienThoai
			// 
			ColDienThoai.DisplayIndex = 2;
			ColDienThoai.Text = "Điện thoại";
			ColDienThoai.Width = 200;
			// 
			// ColNgaySinh
			// 
			ColNgaySinh.DisplayIndex = 1;
			ColNgaySinh.Text = "Ngày sinh";
			ColNgaySinh.Width = 200;
			// 
			// ColDiaChi
			// 
			ColDiaChi.Text = "Địa chỉ";
			ColDiaChi.Width = 600;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1742, 1201);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "QUẢN LÝ NHÂN VIÊN";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label3;
		private Label label2;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private DateTimePicker DtpNgaySinh;
		private MaskedTextBox TxtDienThoai;
		private TextBox TxtDiaChi;
		private TextBox TxtHoTen;
		private Label label5;
		private Label label4;
		private Button BtnThoat;
		private Button BtnSua;
		private Button BtnXoa;
		private Button BtnThem;
		private ListView LvNhanVien;
		private ColumnHeader ColHoTen;
		private ColumnHeader ColDienThoai;
		private ColumnHeader ColNgaySinh;
		private ColumnHeader ColDiaChi;
	}
}
