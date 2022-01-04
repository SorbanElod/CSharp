namespace _13_Sender
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
			this.button1 = new System.Windows.Forms.Button();
			this.labelText = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelControl = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(147, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Button";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ClickOnCtrl);
			// 
			// labelText
			// 
			this.labelText.BackColor = System.Drawing.Color.DarkSalmon;
			this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelText.Location = new System.Drawing.Point(380, 52);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(200, 75);
			this.labelText.TabIndex = 1;
			this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelText.Click += new System.EventHandler(this.ClickOnLabel);
			// 
			// labelDescription
			// 
			this.labelDescription.BackColor = System.Drawing.Color.Salmon;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescription.Location = new System.Drawing.Point(380, 151);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(200, 75);
			this.labelDescription.TabIndex = 2;
			this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDescription.Click += new System.EventHandler(this.ClickOnLabel);
			// 
			// labelControl
			// 
			this.labelControl.BackColor = System.Drawing.Color.LightSalmon;
			this.labelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl.Location = new System.Drawing.Point(141, 171);
			this.labelControl.Name = "labelControl";
			this.labelControl.Size = new System.Drawing.Size(116, 40);
			this.labelControl.TabIndex = 3;
			this.labelControl.Text = "Control";
			this.labelControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelControl.Click += new System.EventHandler(this.ClickOnCtrl);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(128, 253);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(157, 26);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "<Insert Text here>";
			this.textBox1.Click += new System.EventHandler(this.ClickOnCtrl);
			this.textBox1.TextChanged += new System.EventHandler(this.ClickOnCtrl);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelControl);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelText);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "ReturnToSender";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelText;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelControl;
		private System.Windows.Forms.TextBox textBox1;
	}
}

