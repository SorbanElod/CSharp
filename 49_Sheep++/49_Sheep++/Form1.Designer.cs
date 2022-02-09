namespace _49_Sheep__
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
			this.pictureBoxWolf = new System.Windows.Forms.PictureBox();
			this.pictureBoxSheep = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxWolf
			// 
			this.pictureBoxWolf.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxWolf.Image = global::_49_Sheep__.Properties.Resources.farkas1;
			this.pictureBoxWolf.Location = new System.Drawing.Point(204, 155);
			this.pictureBoxWolf.Name = "pictureBoxWolf";
			this.pictureBoxWolf.Size = new System.Drawing.Size(100, 150);
			this.pictureBoxWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxWolf.TabIndex = 0;
			this.pictureBoxWolf.TabStop = false;
			// 
			// pictureBoxSheep
			// 
			this.pictureBoxSheep.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxSheep.Image = global::_49_Sheep__.Properties.Resources.bari1;
			this.pictureBoxSheep.Location = new System.Drawing.Point(462, 155);
			this.pictureBoxSheep.Name = "pictureBoxSheep";
			this.pictureBoxSheep.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxSheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxSheep.TabIndex = 1;
			this.pictureBoxSheep.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(307, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 79);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::_49_Sheep__.Properties.Resources.ret;
			this.ClientSize = new System.Drawing.Size(1025, 510);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBoxSheep);
			this.Controls.Add(this.pictureBoxWolf);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Sheep++";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxWolf;
		private System.Windows.Forms.PictureBox pictureBoxSheep;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
	}
}

