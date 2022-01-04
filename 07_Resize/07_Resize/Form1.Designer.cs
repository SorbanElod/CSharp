
namespace _07_Resize
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
			this.buttonPlus = new System.Windows.Forms.Button();
			this.buttonMinus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonPlus
			// 
			this.buttonPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonPlus.Location = new System.Drawing.Point(559, 152);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(75, 75);
			this.buttonPlus.TabIndex = 0;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
			// 
			// buttonMinus
			// 
			this.buttonMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonMinus.Location = new System.Drawing.Point(188, 152);
			this.buttonMinus.Name = "buttonMinus";
			this.buttonMinus.Size = new System.Drawing.Size(75, 75);
			this.buttonMinus.TabIndex = 1;
			this.buttonMinus.Text = "-";
			this.buttonMinus.UseVisualStyleBackColor = true;
			this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonMinus);
			this.Controls.Add(this.buttonPlus);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button buttonMinus;
	}
}

