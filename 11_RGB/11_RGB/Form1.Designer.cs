namespace _11_RGB
{
	partial class Form1
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
			this.hScrollBarSize = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.labelRed = new System.Windows.Forms.Label();
			this.labelGreen = new System.Windows.Forms.Label();
			this.labelBlue = new System.Windows.Forms.Label();
			this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
			this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
			this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
			this.SuspendLayout();
			// 
			// hScrollBarSize
			// 
			this.hScrollBarSize.Location = new System.Drawing.Point(214, 9);
			this.hScrollBarSize.Maximum = 400;
			this.hScrollBarSize.Name = "hScrollBarSize";
			this.hScrollBarSize.Size = new System.Drawing.Size(400, 50);
			this.hScrollBarSize.TabIndex = 0;
			this.hScrollBarSize.Value = 400;
			this.hScrollBarSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSize_Scroll);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(211, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 50);
			this.label1.TabIndex = 1;
			// 
			// labelRed
			// 
			this.labelRed.BackColor = System.Drawing.Color.Red;
			this.labelRed.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRed.Location = new System.Drawing.Point(66, 196);
			this.labelRed.Name = "labelRed";
			this.labelRed.Size = new System.Drawing.Size(100, 50);
			this.labelRed.TabIndex = 2;
			this.labelRed.Text = "R   0";
			this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGreen
			// 
			this.labelGreen.BackColor = System.Drawing.Color.Green;
			this.labelGreen.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGreen.Location = new System.Drawing.Point(66, 281);
			this.labelGreen.Name = "labelGreen";
			this.labelGreen.Size = new System.Drawing.Size(100, 50);
			this.labelGreen.TabIndex = 3;
			this.labelGreen.Text = "G   0";
			this.labelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelBlue
			// 
			this.labelBlue.BackColor = System.Drawing.Color.RoyalBlue;
			this.labelBlue.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBlue.Location = new System.Drawing.Point(66, 370);
			this.labelBlue.Name = "labelBlue";
			this.labelBlue.Size = new System.Drawing.Size(100, 50);
			this.labelBlue.TabIndex = 4;
			this.labelBlue.Text = "B   0";
			this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hScrollBarRed
			// 
			this.hScrollBarRed.LargeChange = 1;
			this.hScrollBarRed.Location = new System.Drawing.Point(214, 196);
			this.hScrollBarRed.Maximum = 255;
			this.hScrollBarRed.Name = "hScrollBarRed";
			this.hScrollBarRed.Size = new System.Drawing.Size(400, 50);
			this.hScrollBarRed.TabIndex = 5;
			this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
			// 
			// hScrollBarGreen
			// 
			this.hScrollBarGreen.LargeChange = 1;
			this.hScrollBarGreen.Location = new System.Drawing.Point(214, 281);
			this.hScrollBarGreen.Maximum = 255;
			this.hScrollBarGreen.Name = "hScrollBarGreen";
			this.hScrollBarGreen.Size = new System.Drawing.Size(400, 50);
			this.hScrollBarGreen.TabIndex = 6;
			this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
			// 
			// hScrollBarBlue
			// 
			this.hScrollBarBlue.LargeChange = 1;
			this.hScrollBarBlue.Location = new System.Drawing.Point(214, 370);
			this.hScrollBarBlue.Maximum = 255;
			this.hScrollBarBlue.Name = "hScrollBarBlue";
			this.hScrollBarBlue.Size = new System.Drawing.Size(400, 50);
			this.hScrollBarBlue.TabIndex = 7;
			this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.hScrollBarBlue);
			this.Controls.Add(this.hScrollBarGreen);
			this.Controls.Add(this.hScrollBarRed);
			this.Controls.Add(this.labelBlue);
			this.Controls.Add(this.labelGreen);
			this.Controls.Add(this.labelRed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hScrollBarSize);
			this.Name = "Form1";
			this.Text = "RGB";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.HScrollBar hScrollBarSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelRed;
		private System.Windows.Forms.Label labelGreen;
		private System.Windows.Forms.Label labelBlue;
		private System.Windows.Forms.HScrollBar hScrollBarRed;
		private System.Windows.Forms.HScrollBar hScrollBarGreen;
		private System.Windows.Forms.HScrollBar hScrollBarBlue;
	}
}

