namespace _40_MatrixColors
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelPrint = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelRGB = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericUpDown1.Location = new System.Drawing.Point(643, 37);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(93, 30);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// buttonCreate
			// 
			this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonCreate.Location = new System.Drawing.Point(643, 82);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(93, 48);
			this.buttonCreate.TabIndex = 1;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonClear.Location = new System.Drawing.Point(643, 158);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(93, 48);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(590, 225);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Clicked Label Number";
			// 
			// labelPrint
			// 
			this.labelPrint.AutoSize = true;
			this.labelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.labelPrint.Location = new System.Drawing.Point(670, 263);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(0, 25);
			this.labelPrint.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button3.Location = new System.Drawing.Point(643, 312);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 48);
			this.button3.TabIndex = 6;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(23, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 504);
			this.panel1.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(653, 386);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "R,G,B";
			// 
			// labelRGB
			// 
			this.labelRGB.AutoSize = true;
			this.labelRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.labelRGB.Location = new System.Drawing.Point(624, 427);
			this.labelRGB.Name = "labelRGB";
			this.labelRGB.Size = new System.Drawing.Size(0, 25);
			this.labelRGB.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 569);
			this.Controls.Add(this.labelRGB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "Form1";
			this.Text = "Matrix";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPrint;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelRGB;
	}
}

