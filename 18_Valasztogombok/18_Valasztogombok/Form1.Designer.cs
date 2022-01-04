namespace _18_Valasztogombok
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonB = new System.Windows.Forms.RadioButton();
			this.radioButtonG = new System.Windows.Forms.RadioButton();
			this.radioButtonR = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonBr = new System.Windows.Forms.RadioButton();
			this.radioButtonWh = new System.Windows.Forms.RadioButton();
			this.radioButtonYl = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonB);
			this.groupBox1.Controls.Add(this.radioButtonG);
			this.groupBox1.Controls.Add(this.radioButtonR);
			this.groupBox1.Location = new System.Drawing.Point(26, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 150);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LabelBakkolor";
			// 
			// radioButtonB
			// 
			this.radioButtonB.AutoSize = true;
			this.radioButtonB.BackColor = System.Drawing.Color.Blue;
			this.radioButtonB.Location = new System.Drawing.Point(24, 113);
			this.radioButtonB.Name = "radioButtonB";
			this.radioButtonB.Size = new System.Drawing.Size(55, 20);
			this.radioButtonB.TabIndex = 2;
			this.radioButtonB.Text = "Blue";
			this.radioButtonB.UseVisualStyleBackColor = false;
			this.radioButtonB.CheckedChanged += new System.EventHandler(this.LabelColorChange);
			// 
			// radioButtonG
			// 
			this.radioButtonG.AutoSize = true;
			this.radioButtonG.BackColor = System.Drawing.Color.Green;
			this.radioButtonG.Location = new System.Drawing.Point(24, 75);
			this.radioButtonG.Name = "radioButtonG";
			this.radioButtonG.Size = new System.Drawing.Size(65, 20);
			this.radioButtonG.TabIndex = 1;
			this.radioButtonG.Text = "Green";
			this.radioButtonG.UseVisualStyleBackColor = false;
			this.radioButtonG.CheckedChanged += new System.EventHandler(this.LabelColorChange);
			// 
			// radioButtonR
			// 
			this.radioButtonR.AutoSize = true;
			this.radioButtonR.BackColor = System.Drawing.Color.Red;
			this.radioButtonR.Location = new System.Drawing.Point(24, 37);
			this.radioButtonR.Name = "radioButtonR";
			this.radioButtonR.Size = new System.Drawing.Size(54, 20);
			this.radioButtonR.TabIndex = 0;
			this.radioButtonR.Text = "Red";
			this.radioButtonR.UseVisualStyleBackColor = false;
			this.radioButtonR.CheckedChanged += new System.EventHandler(this.LabelColorChange);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButtonBr);
			this.groupBox2.Controls.Add(this.radioButtonWh);
			this.groupBox2.Controls.Add(this.radioButtonYl);
			this.groupBox2.Location = new System.Drawing.Point(26, 266);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 150);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FontColor";
			// 
			// radioButtonBr
			// 
			this.radioButtonBr.AutoSize = true;
			this.radioButtonBr.BackColor = System.Drawing.Color.Brown;
			this.radioButtonBr.Location = new System.Drawing.Point(43, 103);
			this.radioButtonBr.Name = "radioButtonBr";
			this.radioButtonBr.Size = new System.Drawing.Size(65, 20);
			this.radioButtonBr.TabIndex = 5;
			this.radioButtonBr.Text = "Brown";
			this.radioButtonBr.UseVisualStyleBackColor = false;
			this.radioButtonBr.CheckedChanged += new System.EventHandler(this.FontColorChanged);
			// 
			// radioButtonWh
			// 
			this.radioButtonWh.AutoSize = true;
			this.radioButtonWh.BackColor = System.Drawing.Color.White;
			this.radioButtonWh.Location = new System.Drawing.Point(43, 65);
			this.radioButtonWh.Name = "radioButtonWh";
			this.radioButtonWh.Size = new System.Drawing.Size(62, 20);
			this.radioButtonWh.TabIndex = 4;
			this.radioButtonWh.Text = "White";
			this.radioButtonWh.UseVisualStyleBackColor = false;
			this.radioButtonWh.CheckedChanged += new System.EventHandler(this.FontColorChanged);
			// 
			// radioButtonYl
			// 
			this.radioButtonYl.AutoSize = true;
			this.radioButtonYl.BackColor = System.Drawing.Color.Yellow;
			this.radioButtonYl.Location = new System.Drawing.Point(43, 27);
			this.radioButtonYl.Name = "radioButtonYl";
			this.radioButtonYl.Size = new System.Drawing.Size(68, 20);
			this.radioButtonYl.TabIndex = 3;
			this.radioButtonYl.Text = "Yellow";
			this.radioButtonYl.UseVisualStyleBackColor = false;
			this.radioButtonYl.CheckedChanged += new System.EventHandler(this.FontColorChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(473, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 94);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lorem Ipsum";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Valasztogomb";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonB;
		private System.Windows.Forms.RadioButton radioButtonG;
		private System.Windows.Forms.RadioButton radioButtonR;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonBr;
		private System.Windows.Forms.RadioButton radioButtonWh;
		private System.Windows.Forms.RadioButton radioButtonYl;
	}
}

