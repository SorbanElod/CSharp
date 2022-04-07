namespace SPANzerMapGenerator
{
	partial class Main
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
			this.pControl = new System.Windows.Forms.Label();
			this.pCanvas = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// pControl
			// 
			this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pControl.Location = new System.Drawing.Point(0, 610);
			this.pControl.Name = "pControl";
			this.pControl.Size = new System.Drawing.Size(1410, 100);
			this.pControl.TabIndex = 0;
			this.pControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pCanvas
			// 
			this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pCanvas.Location = new System.Drawing.Point(0, 0);
			this.pCanvas.Name = "pCanvas";
			this.pCanvas.Size = new System.Drawing.Size(1410, 610);
			this.pCanvas.TabIndex = 1;
			this.pCanvas.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1410, 710);
			this.Controls.Add(this.pCanvas);
			this.Controls.Add(this.pControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "MapGen";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label pControl;
		private System.Windows.Forms.PictureBox pCanvas;
	}
}

