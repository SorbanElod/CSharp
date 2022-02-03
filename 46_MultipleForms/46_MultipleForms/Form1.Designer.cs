namespace _46_MultipleForms
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
			this.buttonAsk = new System.Windows.Forms.Button();
			this.buttonNonModal = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelPrint = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonAsk
			// 
			this.buttonAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonAsk.Location = new System.Drawing.Point(573, 66);
			this.buttonAsk.Name = "buttonAsk";
			this.buttonAsk.Size = new System.Drawing.Size(160, 33);
			this.buttonAsk.TabIndex = 0;
			this.buttonAsk.Text = "Get Number";
			this.buttonAsk.UseVisualStyleBackColor = true;
			this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
			// 
			// buttonNonModal
			// 
			this.buttonNonModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buttonNonModal.Location = new System.Drawing.Point(573, 157);
			this.buttonNonModal.Name = "buttonNonModal";
			this.buttonNonModal.Size = new System.Drawing.Size(160, 33);
			this.buttonNonModal.TabIndex = 1;
			this.buttonNonModal.Text = "Not modal";
			this.buttonNonModal.UseVisualStyleBackColor = true;
			this.buttonNonModal.Click += new System.EventHandler(this.buttonNonModal_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(68, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 47);
			this.label1.TabIndex = 2;
			this.label1.Text = "Number:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPrint
			// 
			this.labelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.labelPrint.Location = new System.Drawing.Point(67, 150);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(124, 47);
			this.labelPrint.TabIndex = 3;
			this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonNonModal);
			this.Controls.Add(this.buttonAsk);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAsk;
		private System.Windows.Forms.Button buttonNonModal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPrint;
	}
}

