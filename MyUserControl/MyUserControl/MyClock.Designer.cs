namespace MyUserControl
{
	partial class MyClock
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
			components = new System.ComponentModel.Container();
			LblDongHo = new Label();
			BtnStart = new Button();
			BtnLap = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// LblDongHo
			// 
			LblDongHo.AutoSize = true;
			LblDongHo.Font = new Font("Tahoma", 20F);
			LblDongHo.Location = new Point(41, 31);
			LblDongHo.Name = "LblDongHo";
			LblDongHo.Size = new Size(474, 81);
			LblDongHo.TabIndex = 0;
			LblDongHo.Text = "00:00:00 0000";
			// 
			// BtnStart
			// 
			BtnStart.Font = new Font("Tahoma", 12F);
			BtnStart.Location = new Point(21, 127);
			BtnStart.Name = "BtnStart";
			BtnStart.Size = new Size(219, 70);
			BtnStart.TabIndex = 1;
			BtnStart.Text = "START";
			BtnStart.UseVisualStyleBackColor = true;
			BtnStart.Click += BtnStart_Click;
			// 
			// BtnLap
			// 
			BtnLap.Font = new Font("Tahoma", 12F);
			BtnLap.Location = new Point(267, 127);
			BtnLap.Name = "BtnLap";
			BtnLap.Size = new Size(219, 70);
			BtnLap.TabIndex = 2;
			BtnLap.Text = "LAP";
			BtnLap.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// MyClock
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(BtnLap);
			Controls.Add(BtnStart);
			Controls.Add(LblDongHo);
			Name = "MyClock";
			Size = new Size(501, 218);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LblDongHo;
		private Button BtnStart;
		private Button BtnLap;
		private System.Windows.Forms.Timer timer1;
	}
}
