namespace _46_MultipleForms
{
	partial class Form2
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(42, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(717, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Write an integer to the TextBox";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBox1.Location = new System.Drawing.Point(323, 133);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 30);
			this.textBox1.TabIndex = 1;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonOK.Location = new System.Drawing.Point(201, 214);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(154, 54);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonCancel.Location = new System.Drawing.Point(445, 214);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(154, 54);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Not OK";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}