namespace _15_Henger
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
			this.labelR = new System.Windows.Forms.Label();
			this.maskedTextBoxR = new System.Windows.Forms.MaskedTextBox();
			this.textBoxH = new System.Windows.Forms.TextBox();
			this.labelH = new System.Windows.Forms.Label();
			this.labelT = new System.Windows.Forms.Label();
			this.labelEredmeny = new System.Windows.Forms.Label();
			this.buttonCount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelR
			// 
			this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelR.Location = new System.Drawing.Point(46, 85);
			this.labelR.Name = "labelR";
			this.labelR.Size = new System.Drawing.Size(100, 23);
			this.labelR.TabIndex = 0;
			this.labelR.Text = "Sugár";
			this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// maskedTextBoxR
			// 
			this.maskedTextBoxR.Location = new System.Drawing.Point(152, 85);
			this.maskedTextBoxR.Mask = "000.00";
			this.maskedTextBoxR.Name = "maskedTextBoxR";
			this.maskedTextBoxR.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBoxR.TabIndex = 1;
			this.maskedTextBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxH
			// 
			this.textBoxH.Location = new System.Drawing.Point(152, 156);
			this.textBoxH.Name = "textBoxH";
			this.textBoxH.Size = new System.Drawing.Size(100, 20);
			this.textBoxH.TabIndex = 2;
			// 
			// labelH
			// 
			this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelH.Location = new System.Drawing.Point(46, 153);
			this.labelH.Name = "labelH";
			this.labelH.Size = new System.Drawing.Size(100, 23);
			this.labelH.TabIndex = 4;
			this.labelH.Text = "Magasság";
			this.labelH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelT
			// 
			this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelT.Location = new System.Drawing.Point(46, 216);
			this.labelT.Name = "labelT";
			this.labelT.Size = new System.Drawing.Size(100, 23);
			this.labelT.TabIndex = 5;
			this.labelT.Text = "Térfogat";
			this.labelT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelEredmeny
			// 
			this.labelEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEredmeny.Location = new System.Drawing.Point(152, 216);
			this.labelEredmeny.Name = "labelEredmeny";
			this.labelEredmeny.Size = new System.Drawing.Size(100, 23);
			this.labelEredmeny.TabIndex = 6;
			this.labelEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCount
			// 
			this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCount.Location = new System.Drawing.Point(454, 272);
			this.buttonCount.Name = "buttonCount";
			this.buttonCount.Size = new System.Drawing.Size(99, 42);
			this.buttonCount.TabIndex = 7;
			this.buttonCount.Text = "Számolj!";
			this.buttonCount.UseVisualStyleBackColor = true;
			this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCount);
			this.Controls.Add(this.labelEredmeny);
			this.Controls.Add(this.labelT);
			this.Controls.Add(this.labelH);
			this.Controls.Add(this.textBoxH);
			this.Controls.Add(this.maskedTextBoxR);
			this.Controls.Add(this.labelR);
			this.Name = "Form1";
			this.Text = "Henger";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelR;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxR;
		private System.Windows.Forms.TextBox textBoxH;
		private System.Windows.Forms.Label labelH;
		private System.Windows.Forms.Label labelT;
		private System.Windows.Forms.Label labelEredmeny;
		private System.Windows.Forms.Button buttonCount;
	}
}

