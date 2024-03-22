namespace MyUserControl
{
	partial class UCDongHo
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
			BtnStartStop = new Button();
			BtnLap = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// LblDongHo
			// 
			LblDongHo.AutoSize = true;
			LblDongHo.Font = new Font("Tahoma", 20F);
			LblDongHo.ForeColor = Color.Blue;
			LblDongHo.Location = new Point(22, 27);
			LblDongHo.Name = "LblDongHo";
			LblDongHo.Size = new Size(437, 81);
			LblDongHo.TabIndex = 0;
			LblDongHo.Text = "00:00:00 000";
			// 
			// BtnStartStop
			// 
			BtnStartStop.Font = new Font("Tahoma", 14.1F);
			BtnStartStop.Location = new Point(22, 128);
			BtnStartStop.Name = "BtnStartStop";
			BtnStartStop.Size = new Size(193, 83);
			BtnStartStop.TabIndex = 1;
			BtnStartStop.Text = "START";
			BtnStartStop.UseVisualStyleBackColor = true;
			BtnStartStop.Click += BtnStartStop_Click;
			// 
			// BtnLap
			// 
			BtnLap.Font = new Font("Tahoma", 14.1F);
			BtnLap.Location = new Point(282, 128);
			BtnLap.Name = "BtnLap";
			BtnLap.Size = new Size(193, 83);
			BtnLap.TabIndex = 1;
			BtnLap.Text = "LAP";
			BtnLap.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// UCDongHo
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(BtnLap);
			Controls.Add(BtnStartStop);
			Controls.Add(LblDongHo);
			Name = "UCDongHo";
			Size = new Size(541, 230);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LblDongHo;
		private Button BtnStartStop;
		private Button BtnLap;
		private System.Windows.Forms.Timer timer1;
	}
}
