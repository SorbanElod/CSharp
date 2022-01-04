namespace _25_Logic
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
			this.checkBoxP = new System.Windows.Forms.CheckBox();
			this.checkBoxQ = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBoxP
			// 
			this.checkBoxP.AutoSize = true;
			this.checkBoxP.Font = new System.Drawing.Font("Comic Sans MS", 12.2F, System.Drawing.FontStyle.Bold);
			this.checkBoxP.Location = new System.Drawing.Point(628, 72);
			this.checkBoxP.Name = "checkBoxP";
			this.checkBoxP.Size = new System.Drawing.Size(46, 34);
			this.checkBoxP.TabIndex = 0;
			this.checkBoxP.Text = "P";
			this.checkBoxP.UseVisualStyleBackColor = true;
			// 
			// checkBoxQ
			// 
			this.checkBoxQ.AutoSize = true;
			this.checkBoxQ.Font = new System.Drawing.Font("Comic Sans MS", 12.2F, System.Drawing.FontStyle.Bold);
			this.checkBoxQ.Location = new System.Drawing.Point(628, 125);
			this.checkBoxQ.Name = "checkBoxQ";
			this.checkBoxQ.Size = new System.Drawing.Size(53, 34);
			this.checkBoxQ.TabIndex = 1;
			this.checkBoxQ.Text = "Q";
			this.checkBoxQ.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Not",
            "And",
            "Or",
            "XOr",
            "NAnd",
            "NOr"});
			this.comboBox1.Location = new System.Drawing.Point(106, 49);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(139, 24);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Changed);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.buttonPrint.Location = new System.Drawing.Point(263, 203);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(150, 75);
			this.buttonPrint.TabIndex = 3;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.Refresh);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.checkBoxQ);
			this.Controls.Add(this.checkBoxP);
			this.Name = "Form1";
			this.Text = "Logic";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxP;
		private System.Windows.Forms.CheckBox checkBoxQ;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonPrint;
	}
}

