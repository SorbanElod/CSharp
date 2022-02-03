namespace _47_ImageCutter
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.buttonGame = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericUpDown1.Location = new System.Drawing.Point(297, 129);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(206, 30);
			this.numericUpDown1.TabIndex = 0;
			// 
			// buttonGame
			// 
			this.buttonGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonGame.Location = new System.Drawing.Point(320, 249);
			this.buttonGame.Name = "buttonGame";
			this.buttonGame.Size = new System.Drawing.Size(161, 73);
			this.buttonGame.TabIndex = 1;
			this.buttonGame.Text = "Start Game";
			this.buttonGame.UseVisualStyleBackColor = true;
			this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonGame);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form1";
			this.Text = "ss";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button buttonGame;
	}
}

