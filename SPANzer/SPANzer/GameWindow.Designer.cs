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
			this.GTimer1 = new System.Windows.Forms.Timer(this.components);
			this.pCanvas = new System.Windows.Forms.PictureBox();
			this.fireRate = new System.Windows.Forms.Timer(this.components);
			this.Intermezzo = new System.Windows.Forms.Timer(this.components);
			this.GTimer2 = new System.Windows.Forms.Timer(this.components);
			this.Refresh = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.pControl = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).BeginInit();
			this.pControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// GTimer1
			// 
			this.GTimer1.Interval = 1;
			this.GTimer1.Tick += new System.EventHandler(this.GTimer1_Tick);
			// 
			// pCanvas
			// 
			this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pCanvas.Location = new System.Drawing.Point(0, 0);
			this.pCanvas.Name = "pCanvas";
			this.pCanvas.Size = new System.Drawing.Size(1342, 623);
			this.pCanvas.TabIndex = 3;
			this.pCanvas.TabStop = false;
			this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
			// 
			// fireRate
			// 
			this.fireRate.Tick += new System.EventHandler(this.fireRate_Tick);
			// 
			// Intermezzo
			// 
			this.Intermezzo.Tick += new System.EventHandler(this.Intermezzo_Tick);
			// 
			// GTimer2
			// 
			this.GTimer2.Interval = 1;
			this.GTimer2.Tick += new System.EventHandler(this.GTimer2_Tick);
			// 
			// Refresh
			// 
			this.Refresh.Interval = 2;
			this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(575, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 51);
			this.label1.TabIndex = 1;
			this.label1.Text = "label2";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pControl
			// 
			this.pControl.Controls.Add(this.label1);
			this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pControl.Location = new System.Drawing.Point(0, 623);
			this.pControl.Name = "pControl";
			this.pControl.Size = new System.Drawing.Size(1342, 100);
			this.pControl.TabIndex = 0;
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1342, 723);
			this.Controls.Add(this.pCanvas);
			this.Controls.Add(this.pControl);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "GameWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SPanzerKampfWagen";
			this.Load += new System.EventHandler(this.GameWindow_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pCanvas)).EndInit();
			this.pControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer GTimer1;
		private System.Windows.Forms.PictureBox pCanvas;
		private System.Windows.Forms.Timer fireRate;
		private System.Windows.Forms.Timer Intermezzo;
		private System.Windows.Forms.Timer GTimer2;
		private System.Windows.Forms.Timer Refresh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pControl;
	}
}

