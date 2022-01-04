namespace _04_LabelReArrange
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
			this.labelOne = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelOne
			// 
			this.labelOne.Font = new System.Drawing.Font("Stencil Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOne.Location = new System.Drawing.Point(0, 0);
			this.labelOne.Name = "labelOne";
			this.labelOne.Size = new System.Drawing.Size(800, 450);
			this.labelOne.TabIndex = 0;
			this.labelOne.Text = "Label";
			this.labelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelOne_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelOne);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelOne;
	}
}

