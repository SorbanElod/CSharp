namespace _27_Stopper
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
			this.components = new System.ComponentModel.Container();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.buttonMode = new System.Windows.Forms.Button();
			this.labelPrint = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(653, 61);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(100, 45);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(249, 306);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(100, 45);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonRestart
			// 
			this.buttonRestart.Location = new System.Drawing.Point(162, 378);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new System.Drawing.Size(100, 45);
			this.buttonRestart.TabIndex = 2;
			this.buttonRestart.Text = "Restart";
			this.buttonRestart.UseVisualStyleBackColor = true;
			this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
			// 
			// buttonMode
			// 
			this.buttonMode.Location = new System.Drawing.Point(327, 378);
			this.buttonMode.Name = "buttonMode";
			this.buttonMode.Size = new System.Drawing.Size(100, 45);
			this.buttonMode.TabIndex = 3;
			this.buttonMode.Text = "Laptime";
			this.buttonMode.UseVisualStyleBackColor = true;
			this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
			// 
			// labelPrint
			// 
			this.labelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.labelPrint.Location = new System.Drawing.Point(124, 18);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(387, 50);
			this.labelPrint.TabIndex = 4;
			this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(162, 82);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(285, 212);
			this.listBox1.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.buttonMode);
			this.Controls.Add(this.buttonRestart);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.buttonExit);
			this.Name = "Form1";
			this.Text = "Stopper";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonMode;
		private System.Windows.Forms.Button buttonRestart;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label labelPrint;
		private System.Windows.Forms.Timer timer1;
	}
}

