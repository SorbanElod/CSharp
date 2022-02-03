namespace _47_ImageCutter
{
	partial class Form2
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonExit.Location = new System.Drawing.Point(470, 383);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(138, 59);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(430, 430);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.Location = new System.Drawing.Point(470, 276);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 59);
			this.button1.TabIndex = 2;
			this.button1.Text = "Kever";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Shuffle);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button2.Location = new System.Drawing.Point(470, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 59);
			this.button2.TabIndex = 3;
			this.button2.Text = "Kirak";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonExit);
			this.Name = "Form2";
			this.Text = "Image";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}