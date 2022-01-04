
namespace _08_MoveTheBox
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
			this.labelOne = new System.Windows.Forms.Label();
			this.labelTwo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelOne
			// 
			this.labelOne.BackColor = System.Drawing.Color.Lime;
			this.labelOne.Location = new System.Drawing.Point(121, 128);
			this.labelOne.Name = "labelOne";
			this.labelOne.Size = new System.Drawing.Size(150, 75);
			this.labelOne.TabIndex = 0;
			this.labelOne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelOne_MouseMove);
			// 
			// labelTwo
			// 
			this.labelTwo.BackColor = System.Drawing.Color.Red;
			this.labelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTwo.Location = new System.Drawing.Point(522, 128);
			this.labelTwo.Name = "labelTwo";
			this.labelTwo.Size = new System.Drawing.Size(150, 75);
			this.labelTwo.TabIndex = 1;
			this.labelTwo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTwo_MouseMove);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelTwo);
			this.Controls.Add(this.labelOne);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelOne;
		private System.Windows.Forms.Label labelTwo;
	}
}

