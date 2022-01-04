namespace _19_CircleRadioGroup
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBoxText = new System.Windows.Forms.CheckBox();
			this.checkBoxColor = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonA = new System.Windows.Forms.RadioButton();
			this.radioButtonT = new System.Windows.Forms.RadioButton();
			this.radioButtonK = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(42, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sugár";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.textBox1.Location = new System.Drawing.Point(182, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 32);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// checkBoxText
			// 
			this.checkBoxText.AutoSize = true;
			this.checkBoxText.Location = new System.Drawing.Point(72, 178);
			this.checkBoxText.Name = "checkBoxText";
			this.checkBoxText.Size = new System.Drawing.Size(66, 20);
			this.checkBoxText.TabIndex = 3;
			this.checkBoxText.Text = "Felirat";
			this.checkBoxText.UseVisualStyleBackColor = true;
			this.checkBoxText.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// checkBoxColor
			// 
			this.checkBoxColor.AutoSize = true;
			this.checkBoxColor.Location = new System.Drawing.Point(72, 229);
			this.checkBoxColor.Name = "checkBoxColor";
			this.checkBoxColor.Size = new System.Drawing.Size(68, 20);
			this.checkBoxColor.TabIndex = 4;
			this.checkBoxColor.Text = "Szinez";
			this.checkBoxColor.UseVisualStyleBackColor = true;
			this.checkBoxColor.CheckedChanged += new System.EventHandler(this.ChangeColor);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonA);
			this.groupBox1.Controls.Add(this.radioButtonT);
			this.groupBox1.Controls.Add(this.radioButtonK);
			this.groupBox1.Location = new System.Drawing.Point(502, 139);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 230);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// radioButtonA
			// 
			this.radioButtonA.AutoSize = true;
			this.radioButtonA.Location = new System.Drawing.Point(49, 162);
			this.radioButtonA.Name = "radioButtonA";
			this.radioButtonA.Size = new System.Drawing.Size(71, 20);
			this.radioButtonA.TabIndex = 2;
			this.radioButtonA.Tag = "2";
			this.radioButtonA.Text = "Atmero";
			this.radioButtonA.UseVisualStyleBackColor = true;
			this.radioButtonA.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// radioButtonT
			// 
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new System.Drawing.Point(49, 105);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new System.Drawing.Size(70, 20);
			this.radioButtonT.TabIndex = 1;
			this.radioButtonT.Tag = "1";
			this.radioButtonT.Text = "Terulet";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonT.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// radioButtonK
			// 
			this.radioButtonK.AutoSize = true;
			this.radioButtonK.Checked = true;
			this.radioButtonK.Location = new System.Drawing.Point(49, 48);
			this.radioButtonK.Name = "radioButtonK";
			this.radioButtonK.Size = new System.Drawing.Size(69, 20);
			this.radioButtonK.TabIndex = 0;
			this.radioButtonK.TabStop = true;
			this.radioButtonK.Tag = "0";
			this.radioButtonK.Text = "Kerulet";
			this.radioButtonK.UseVisualStyleBackColor = true;
			this.radioButtonK.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.textBox2.Location = new System.Drawing.Point(72, 337);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(403, 32);
			this.textBox2.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.checkBoxColor);
			this.Controls.Add(this.checkBoxText);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBoxText;
		private System.Windows.Forms.CheckBox checkBoxColor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonA;
		private System.Windows.Forms.RadioButton radioButtonT;
		private System.Windows.Forms.RadioButton radioButtonK;
		private System.Windows.Forms.TextBox textBox2;
	}
}

