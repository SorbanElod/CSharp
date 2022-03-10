namespace SPANzer
{
	partial class GameWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pControl = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pCanvas = new System.Windows.Forms.PictureBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.pControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// pControl
			// 
			this.pControl.Controls.Add(this.label3);
			this.pControl.Controls.Add(this.label2);
			this.pControl.Controls.Add(this.label1);
			this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pControl.Location = new System.Drawing.Point(0, 683);
			this.pControl.Name = "pControl";
			this.pControl.Size = new System.Drawing.Size(1482, 100);
			this.pControl.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(972, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(557, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pCanvas
			// 
			this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pCanvas.Location = new System.Drawing.Point(0, 0);
			this.pCanvas.Name = "pCanvas";
			this.pCanvas.Size = new System.Drawing.Size(1482, 683);
			this.pCanvas.TabIndex = 3;
			this.pCanvas.TabStop = false;
			this.pCanvas.Click += new System.EventHandler(this.pCanvas_Click);
			this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
			// 
			// timer2
			// 
			this.timer2.Interval = 1;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1482, 783);
			this.Controls.Add(this.pCanvas);
			this.Controls.Add(this.pControl);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GameWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SPanzerKampfWagen";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.pControl.ResumeLayout(false);
			this.pControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pControl;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pCanvas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label3;
	}
}

