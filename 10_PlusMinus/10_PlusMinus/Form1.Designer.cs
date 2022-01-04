namespace _10_PlusMinus
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.buttonMinus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Stencil Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(291, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 75);
			this.label1.TabIndex = 0;
			this.label1.Text = "0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonPlus
			// 
			this.buttonPlus.Font = new System.Drawing.Font("Stencil Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlus.Location = new System.Drawing.Point(115, 248);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(150, 75);
			this.buttonPlus.TabIndex = 1;
			this.buttonPlus.Text = "++";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
			// 
			// buttonMinus
			// 
			this.buttonMinus.Font = new System.Drawing.Font("Stencil Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMinus.Location = new System.Drawing.Point(497, 248);
			this.buttonMinus.Name = "buttonMinus";
			this.buttonMinus.Size = new System.Drawing.Size(150, 75);
			this.buttonMinus.TabIndex = 2;
			this.buttonMinus.Text = "--";
			this.buttonMinus.UseVisualStyleBackColor = true;
			this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonMinus);
			this.Controls.Add(this.buttonPlus);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "PlusMinus";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button buttonMinus;
	}
}

