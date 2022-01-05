namespace SorbanElod
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
			this.groupBoxEdesseg = new System.Windows.Forms.GroupBox();
			this.radioButtonFrappe = new System.Windows.Forms.RadioButton();
			this.radioButtonUdito = new System.Windows.Forms.RadioButton();
			this.radioButtonFagyi = new System.Windows.Forms.RadioButton();
			this.groupBoxHozzavalok = new System.Windows.Forms.GroupBox();
			this.checkBoxTejszin = new System.Windows.Forms.CheckBox();
			this.checkBoxPiskota = new System.Windows.Forms.CheckBox();
			this.checkBoxJeg = new System.Windows.Forms.CheckBox();
			this.checkBoxOntet = new System.Windows.Forms.CheckBox();
			this.buttonFizet = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonTorol = new System.Windows.Forms.Button();
			this.labelPrint = new System.Windows.Forms.Label();
			this.groupBoxEdesseg.SuspendLayout();
			this.groupBoxHozzavalok.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 377);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(460, 75);
			this.label1.TabIndex = 0;
			this.label1.Text = "FAGYIZÓ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBoxEdesseg
			// 
			this.groupBoxEdesseg.Controls.Add(this.radioButtonFrappe);
			this.groupBoxEdesseg.Controls.Add(this.radioButtonUdito);
			this.groupBoxEdesseg.Controls.Add(this.radioButtonFagyi);
			this.groupBoxEdesseg.Location = new System.Drawing.Point(12, 12);
			this.groupBoxEdesseg.Name = "groupBoxEdesseg";
			this.groupBoxEdesseg.Size = new System.Drawing.Size(148, 134);
			this.groupBoxEdesseg.TabIndex = 1;
			this.groupBoxEdesseg.TabStop = false;
			this.groupBoxEdesseg.Text = "Edesseg";
			// 
			// radioButtonFrappe
			// 
			this.radioButtonFrappe.AutoSize = true;
			this.radioButtonFrappe.Location = new System.Drawing.Point(32, 95);
			this.radioButtonFrappe.Name = "radioButtonFrappe";
			this.radioButtonFrappe.Size = new System.Drawing.Size(86, 17);
			this.radioButtonFrappe.TabIndex = 2;
			this.radioButtonFrappe.Tag = "7";
			this.radioButtonFrappe.Text = "Frappe (7 lej)";
			this.radioButtonFrappe.UseVisualStyleBackColor = true;
			this.radioButtonFrappe.CheckedChanged += new System.EventHandler(this.Changed);
			// 
			// radioButtonUdito
			// 
			this.radioButtonUdito.AutoSize = true;
			this.radioButtonUdito.Location = new System.Drawing.Point(32, 56);
			this.radioButtonUdito.Name = "radioButtonUdito";
			this.radioButtonUdito.Size = new System.Drawing.Size(78, 17);
			this.radioButtonUdito.TabIndex = 1;
			this.radioButtonUdito.Tag = "6";
			this.radioButtonUdito.Text = "Udito (6 lej)";
			this.radioButtonUdito.UseVisualStyleBackColor = true;
			this.radioButtonUdito.CheckedChanged += new System.EventHandler(this.Changed);
			// 
			// radioButtonFagyi
			// 
			this.radioButtonFagyi.AutoSize = true;
			this.radioButtonFagyi.Location = new System.Drawing.Point(32, 20);
			this.radioButtonFagyi.Name = "radioButtonFagyi";
			this.radioButtonFagyi.Size = new System.Drawing.Size(78, 17);
			this.radioButtonFagyi.TabIndex = 0;
			this.radioButtonFagyi.Tag = "7";
			this.radioButtonFagyi.Text = "Fagyi (7 lej)";
			this.radioButtonFagyi.UseVisualStyleBackColor = true;
			this.radioButtonFagyi.CheckedChanged += new System.EventHandler(this.Changed);
			// 
			// groupBoxHozzavalok
			// 
			this.groupBoxHozzavalok.Controls.Add(this.checkBoxTejszin);
			this.groupBoxHozzavalok.Controls.Add(this.checkBoxPiskota);
			this.groupBoxHozzavalok.Controls.Add(this.checkBoxJeg);
			this.groupBoxHozzavalok.Controls.Add(this.checkBoxOntet);
			this.groupBoxHozzavalok.Location = new System.Drawing.Point(272, 149);
			this.groupBoxHozzavalok.Name = "groupBoxHozzavalok";
			this.groupBoxHozzavalok.Size = new System.Drawing.Size(148, 168);
			this.groupBoxHozzavalok.TabIndex = 2;
			this.groupBoxHozzavalok.TabStop = false;
			this.groupBoxHozzavalok.Text = "Hozzavalok";
			// 
			// checkBoxTejszin
			// 
			this.checkBoxTejszin.AutoSize = true;
			this.checkBoxTejszin.Location = new System.Drawing.Point(22, 129);
			this.checkBoxTejszin.Name = "checkBoxTejszin";
			this.checkBoxTejszin.Size = new System.Drawing.Size(105, 17);
			this.checkBoxTejszin.TabIndex = 3;
			this.checkBoxTejszin.Tag = "2";
			this.checkBoxTejszin.Text = "Tejszinhab (2 lej)";
			this.checkBoxTejszin.UseVisualStyleBackColor = true;
			this.checkBoxTejszin.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// checkBoxPiskota
			// 
			this.checkBoxPiskota.AutoSize = true;
			this.checkBoxPiskota.Location = new System.Drawing.Point(22, 95);
			this.checkBoxPiskota.Name = "checkBoxPiskota";
			this.checkBoxPiskota.Size = new System.Drawing.Size(89, 17);
			this.checkBoxPiskota.TabIndex = 2;
			this.checkBoxPiskota.Tag = "2";
			this.checkBoxPiskota.Text = "Piskota (2 lej)";
			this.checkBoxPiskota.UseVisualStyleBackColor = true;
			this.checkBoxPiskota.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// checkBoxJeg
			// 
			this.checkBoxJeg.AutoSize = true;
			this.checkBoxJeg.Location = new System.Drawing.Point(22, 67);
			this.checkBoxJeg.Name = "checkBoxJeg";
			this.checkBoxJeg.Size = new System.Drawing.Size(71, 17);
			this.checkBoxJeg.TabIndex = 1;
			this.checkBoxJeg.Tag = "1";
			this.checkBoxJeg.Text = "Jeg (1 lej)";
			this.checkBoxJeg.UseVisualStyleBackColor = true;
			this.checkBoxJeg.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// checkBoxOntet
			// 
			this.checkBoxOntet.AutoSize = true;
			this.checkBoxOntet.Location = new System.Drawing.Point(22, 33);
			this.checkBoxOntet.Name = "checkBoxOntet";
			this.checkBoxOntet.Size = new System.Drawing.Size(80, 17);
			this.checkBoxOntet.TabIndex = 0;
			this.checkBoxOntet.Tag = "1";
			this.checkBoxOntet.Text = "Ontet (1 lej)";
			this.checkBoxOntet.UseVisualStyleBackColor = true;
			this.checkBoxOntet.CheckedChanged += new System.EventHandler(this.Refresh);
			// 
			// buttonFizet
			// 
			this.buttonFizet.Location = new System.Drawing.Point(85, 244);
			this.buttonFizet.Name = "buttonFizet";
			this.buttonFizet.Size = new System.Drawing.Size(75, 35);
			this.buttonFizet.TabIndex = 3;
			this.buttonFizet.Text = "Fizetes";
			this.buttonFizet.UseVisualStyleBackColor = true;
			this.buttonFizet.Click += new System.EventHandler(this.buttonFizet_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(345, 23);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 35);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonTorol
			// 
			this.buttonTorol.Location = new System.Drawing.Point(85, 198);
			this.buttonTorol.Name = "buttonTorol";
			this.buttonTorol.Size = new System.Drawing.Size(75, 35);
			this.buttonTorol.TabIndex = 5;
			this.buttonTorol.Text = "Torles";
			this.buttonTorol.UseVisualStyleBackColor = true;
			this.buttonTorol.Click += new System.EventHandler(this.buttonTorol_Click);
			// 
			// labelPrint
			// 
			this.labelPrint.Location = new System.Drawing.Point(315, 77);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(145, 35);
			this.labelPrint.TabIndex = 6;
			this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.buttonTorol);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonFizet);
			this.Controls.Add(this.groupBoxHozzavalok);
			this.Controls.Add(this.groupBoxEdesseg);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Fagyizó";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxEdesseg.ResumeLayout(false);
			this.groupBoxEdesseg.PerformLayout();
			this.groupBoxHozzavalok.ResumeLayout(false);
			this.groupBoxHozzavalok.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxEdesseg;
		private System.Windows.Forms.GroupBox groupBoxHozzavalok;
		private System.Windows.Forms.Button buttonFizet;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonTorol;
		private System.Windows.Forms.Label labelPrint;
		private System.Windows.Forms.RadioButton radioButtonFrappe;
		private System.Windows.Forms.RadioButton radioButtonUdito;
		private System.Windows.Forms.RadioButton radioButtonFagyi;
		private System.Windows.Forms.CheckBox checkBoxTejszin;
		private System.Windows.Forms.CheckBox checkBoxPiskota;
		private System.Windows.Forms.CheckBox checkBoxJeg;
		private System.Windows.Forms.CheckBox checkBoxOntet;
	}
}

