namespace _17_BusTicket
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.checkBoxDiscDiak = new System.Windows.Forms.CheckBox();
			this.checkBoxDiscNyugi = new System.Windows.Forms.CheckBox();
			this.checkBoxDiscTorzs = new System.Windows.Forms.CheckBox();
			this.checkBoxOthKuta = new System.Windows.Forms.CheckBox();
			this.checkBoxOthBic = new System.Windows.Forms.CheckBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.labelPrint = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(39, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Uticél";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(236, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kedvezmények";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(415, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Egyéb";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(56, 102);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(117, 35);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = "3";
			this.radioButton1.Text = "Boldogfalva";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.DestinationChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(56, 162);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(117, 35);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Tag = "6";
			this.radioButton2.Text = "Keményfalva";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.DestinationChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(56, 222);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(117, 35);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Tag = "5";
			this.radioButton3.Text = "Agyagfalva";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.DestinationChanged);
			// 
			// checkBoxDiscDiak
			// 
			this.checkBoxDiscDiak.AutoSize = true;
			this.checkBoxDiscDiak.Location = new System.Drawing.Point(257, 102);
			this.checkBoxDiscDiak.Name = "checkBoxDiscDiak";
			this.checkBoxDiscDiak.Size = new System.Drawing.Size(68, 26);
			this.checkBoxDiscDiak.TabIndex = 6;
			this.checkBoxDiscDiak.Text = "Diák";
			this.checkBoxDiscDiak.UseVisualStyleBackColor = true;
			this.checkBoxDiscDiak.CheckStateChanged += new System.EventHandler(this.DiscountChanged);
			// 
			// checkBoxDiscNyugi
			// 
			this.checkBoxDiscNyugi.AutoSize = true;
			this.checkBoxDiscNyugi.Location = new System.Drawing.Point(257, 166);
			this.checkBoxDiscNyugi.Name = "checkBoxDiscNyugi";
			this.checkBoxDiscNyugi.Size = new System.Drawing.Size(111, 26);
			this.checkBoxDiscNyugi.TabIndex = 7;
			this.checkBoxDiscNyugi.Text = "Nyugdíjas";
			this.checkBoxDiscNyugi.UseVisualStyleBackColor = true;
			this.checkBoxDiscNyugi.CheckStateChanged += new System.EventHandler(this.DiscountChanged);
			// 
			// checkBoxDiscTorzs
			// 
			this.checkBoxDiscTorzs.AutoSize = true;
			this.checkBoxDiscTorzs.Location = new System.Drawing.Point(257, 230);
			this.checkBoxDiscTorzs.Name = "checkBoxDiscTorzs";
			this.checkBoxDiscTorzs.Size = new System.Drawing.Size(111, 26);
			this.checkBoxDiscTorzs.TabIndex = 8;
			this.checkBoxDiscTorzs.Text = "Törzsutas";
			this.checkBoxDiscTorzs.UseVisualStyleBackColor = true;
			this.checkBoxDiscTorzs.CheckStateChanged += new System.EventHandler(this.DiscountChanged);
			// 
			// checkBoxOthKuta
			// 
			this.checkBoxOthKuta.AutoSize = true;
			this.checkBoxOthKuta.Location = new System.Drawing.Point(442, 102);
			this.checkBoxOthKuta.Name = "checkBoxOthKuta";
			this.checkBoxOthKuta.Size = new System.Drawing.Size(101, 26);
			this.checkBoxOthKuta.TabIndex = 9;
			this.checkBoxOthKuta.Text = "Kutyával";
			this.checkBoxOthKuta.UseVisualStyleBackColor = true;
			this.checkBoxOthKuta.CheckedChanged += new System.EventHandler(this.OthersChanged);
			// 
			// checkBoxOthBic
			// 
			this.checkBoxOthBic.AutoSize = true;
			this.checkBoxOthBic.Location = new System.Drawing.Point(442, 172);
			this.checkBoxOthBic.Name = "checkBoxOthBic";
			this.checkBoxOthBic.Size = new System.Drawing.Size(101, 26);
			this.checkBoxOthBic.TabIndex = 10;
			this.checkBoxOthBic.Text = "Biciklivel";
			this.checkBoxOthBic.UseVisualStyleBackColor = true;
			this.checkBoxOthBic.CheckedChanged += new System.EventHandler(this.OthersChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(56, 282);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(117, 35);
			this.radioButton4.TabIndex = 11;
			this.radioButton4.TabStop = true;
			this.radioButton4.Tag = "8";
			this.radioButton4.Text = "Máréfalva";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.DestinationChanged);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(592, 50);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(83, 31);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.Text = "Töröl";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(592, 142);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(83, 31);
			this.buttonPrint.TabIndex = 13;
			this.buttonPrint.Text = "Nyomtat";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// labelPrint
			// 
			this.labelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrint.Location = new System.Drawing.Point(244, 313);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(378, 101);
			this.labelPrint.TabIndex = 14;
			this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 588);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.checkBoxOthBic);
			this.Controls.Add(this.checkBoxOthKuta);
			this.Controls.Add(this.checkBoxDiscTorzs);
			this.Controls.Add(this.checkBoxDiscNyugi);
			this.Controls.Add(this.checkBoxDiscDiak);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "BusTicket";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.CheckBox checkBoxDiscDiak;
		private System.Windows.Forms.CheckBox checkBoxDiscNyugi;
		private System.Windows.Forms.CheckBox checkBoxDiscTorzs;
		private System.Windows.Forms.CheckBox checkBoxOthKuta;
		private System.Windows.Forms.CheckBox checkBoxOthBic;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Label labelPrint;
	}
}

