namespace _26_ComboBox
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonFill = new System.Windows.Forms.Button();
			this.buttonDeleteAll = new System.Windows.Forms.Button();
			this.buttonDeleteAct = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(78, 75);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 33);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// buttonFill
			// 
			this.buttonFill.Location = new System.Drawing.Point(99, 131);
			this.buttonFill.Name = "buttonFill";
			this.buttonFill.Size = new System.Drawing.Size(141, 60);
			this.buttonFill.TabIndex = 1;
			this.buttonFill.Text = "Upload";
			this.buttonFill.UseVisualStyleBackColor = true;
			this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
			// 
			// buttonDeleteAll
			// 
			this.buttonDeleteAll.Location = new System.Drawing.Point(99, 213);
			this.buttonDeleteAll.Name = "buttonDeleteAll";
			this.buttonDeleteAll.Size = new System.Drawing.Size(141, 60);
			this.buttonDeleteAll.TabIndex = 2;
			this.buttonDeleteAll.Text = "Delete All";
			this.buttonDeleteAll.UseVisualStyleBackColor = true;
			this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
			// 
			// buttonDeleteAct
			// 
			this.buttonDeleteAct.Location = new System.Drawing.Point(99, 297);
			this.buttonDeleteAct.Name = "buttonDeleteAct";
			this.buttonDeleteAct.Size = new System.Drawing.Size(141, 60);
			this.buttonDeleteAct.TabIndex = 3;
			this.buttonDeleteAct.Text = "Delete Selected";
			this.buttonDeleteAct.UseVisualStyleBackColor = true;
			this.buttonDeleteAct.Click += new System.EventHandler(this.buttonDeleteAct_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(350, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 26);
			this.label1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 432);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonDeleteAct);
			this.Controls.Add(this.buttonDeleteAll);
			this.Controls.Add(this.buttonFill);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.Text = "ComboBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonFill;
		private System.Windows.Forms.Button buttonDeleteAll;
		private System.Windows.Forms.Button buttonDeleteAct;
		private System.Windows.Forms.Label label1;
	}
}

