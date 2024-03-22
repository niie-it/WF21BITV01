namespace MyUserControl
{
	partial class UCCountDown
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
			TxtDongHo = new TextBox();
			button1 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// TxtDongHo
			// 
			TxtDongHo.Location = new Point(54, 15);
			TxtDongHo.Name = "TxtDongHo";
			TxtDongHo.Size = new Size(250, 47);
			TxtDongHo.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(85, 68);
			button1.Name = "button1";
			button1.Size = new Size(188, 58);
			button1.TabIndex = 1;
			button1.Text = "RUN";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// UCCountDown
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button1);
			Controls.Add(TxtDongHo);
			Name = "UCCountDown";
			Size = new Size(346, 136);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtDongHo;
		private Button button1;
		private System.Windows.Forms.Timer timer1;
	}
}
