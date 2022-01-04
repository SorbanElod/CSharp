namespace _05_VisibleUnvisible
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
			this.buttonVisible = new System.Windows.Forms.Button();
			this.labelOne = new System.Windows.Forms.Label();
			this.buttonDisable = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonVisible
			// 
			this.buttonVisible.Location = new System.Drawing.Point(144, 61);
			this.buttonVisible.Name = "buttonVisible";
			this.buttonVisible.Size = new System.Drawing.Size(150, 75);
			this.buttonVisible.TabIndex = 0;
			this.buttonVisible.Text = "Set Visible";
			this.buttonVisible.UseVisualStyleBackColor = true;
			this.buttonVisible.Click += new System.EventHandler(this.buttonVisible_Click);
			// 
			// labelOne
			// 
			this.labelOne.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOne.Location = new System.Drawing.Point(525, 61);
			this.labelOne.Name = "labelOne";
			this.labelOne.Size = new System.Drawing.Size(150, 75);
			this.labelOne.TabIndex = 2;
			this.labelOne.Text = "Visible visible";
			// 
			// buttonDisable
			// 
			this.buttonDisable.Location = new System.Drawing.Point(341, 275);
			this.buttonDisable.Name = "buttonDisable";
			this.buttonDisable.Size = new System.Drawing.Size(150, 75);
			this.buttonDisable.TabIndex = 3;
			this.buttonDisable.Text = "Disable";
			this.buttonDisable.UseVisualStyleBackColor = true;
			this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonDisable);
			this.Controls.Add(this.labelOne);
			this.Controls.Add(this.buttonVisible);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonVisible;
		private System.Windows.Forms.Label labelOne;
		private System.Windows.Forms.Button buttonDisable;
	}
}

