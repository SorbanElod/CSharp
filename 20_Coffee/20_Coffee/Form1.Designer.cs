namespace _20_Coffee
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
			this.groupBoxDrink = new System.Windows.Forms.GroupBox();
			this.radioButtonH = new System.Windows.Forms.RadioButton();
			this.radioButtonT = new System.Windows.Forms.RadioButton();
			this.radioButtonC = new System.Windows.Forms.RadioButton();
			this.groupBoxOthers = new System.Windows.Forms.GroupBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonPay = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxDrink.SuspendLayout();
			this.groupBoxOthers.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxDrink
			// 
			this.groupBoxDrink.Controls.Add(this.radioButtonH);
			this.groupBoxDrink.Controls.Add(this.radioButtonT);
			this.groupBoxDrink.Controls.Add(this.radioButtonC);
			this.groupBoxDrink.Location = new System.Drawing.Point(74, 25);
			this.groupBoxDrink.Name = "groupBoxDrink";
			this.groupBoxDrink.Size = new System.Drawing.Size(250, 250);
			this.groupBoxDrink.TabIndex = 0;
			this.groupBoxDrink.TabStop = false;
			this.groupBoxDrink.Text = "Drink";
			// 
			// radioButtonH
			// 
			this.radioButtonH.AutoSize = true;
			this.radioButtonH.Location = new System.Drawing.Point(74, 175);
			this.radioButtonH.Name = "radioButtonH";
			this.radioButtonH.Size = new System.Drawing.Size(111, 20);
			this.radioButtonH.TabIndex = 2;
			this.radioButtonH.Tag = "6";
			this.radioButtonH.Text = "Hot chocolate";
			this.radioButtonH.UseVisualStyleBackColor = true;
			this.radioButtonH.CheckedChanged += new System.EventHandler(this.DrinkClicked);
			// 
			// radioButtonT
			// 
			this.radioButtonT.AutoSize = true;
			this.radioButtonT.Location = new System.Drawing.Point(74, 115);
			this.radioButtonT.Name = "radioButtonT";
			this.radioButtonT.Size = new System.Drawing.Size(53, 20);
			this.radioButtonT.TabIndex = 1;
			this.radioButtonT.Tag = "3";
			this.radioButtonT.Text = "Tea";
			this.radioButtonT.UseVisualStyleBackColor = true;
			this.radioButtonT.CheckedChanged += new System.EventHandler(this.DrinkClicked);
			// 
			// radioButtonC
			// 
			this.radioButtonC.AutoSize = true;
			this.radioButtonC.Location = new System.Drawing.Point(74, 55);
			this.radioButtonC.Name = "radioButtonC";
			this.radioButtonC.Size = new System.Drawing.Size(67, 20);
			this.radioButtonC.TabIndex = 0;
			this.radioButtonC.Tag = "4";
			this.radioButtonC.Text = "Coffee";
			this.radioButtonC.UseVisualStyleBackColor = true;
			this.radioButtonC.CheckedChanged += new System.EventHandler(this.DrinkClicked);
			// 
			// groupBoxOthers
			// 
			this.groupBoxOthers.Controls.Add(this.checkBox4);
			this.groupBoxOthers.Controls.Add(this.checkBox3);
			this.groupBoxOthers.Controls.Add(this.checkBox2);
			this.groupBoxOthers.Controls.Add(this.checkBox1);
			this.groupBoxOthers.Location = new System.Drawing.Point(477, 25);
			this.groupBoxOthers.Name = "groupBoxOthers";
			this.groupBoxOthers.Size = new System.Drawing.Size(250, 250);
			this.groupBoxOthers.TabIndex = 1;
			this.groupBoxOthers.TabStop = false;
			this.groupBoxOthers.Text = "Others";
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(78, 201);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(72, 20);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Tag = "3";
			this.checkBox4.Text = "Tejszin";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.OthersClicked);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(78, 144);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(53, 20);
			this.checkBox3.TabIndex = 5;
			this.checkBox3.Tag = "1";
			this.checkBox3.Text = "Milk";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.OthersClicked);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(78, 87);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(70, 20);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Tag = "2";
			this.checkBox2.Text = "Lemon";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.OthersClicked);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(78, 30);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(65, 20);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Tag = "1";
			this.checkBox1.Text = "Sugar";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.OthersClicked);
			// 
			// buttonPay
			// 
			this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.buttonPay.Location = new System.Drawing.Point(467, 330);
			this.buttonPay.Name = "buttonPay";
			this.buttonPay.Size = new System.Drawing.Size(200, 75);
			this.buttonPay.TabIndex = 2;
			this.buttonPay.Text = "Pay";
			this.buttonPay.UseVisualStyleBackColor = true;
			this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(74, 330);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 75);
			this.label1.TabIndex = 3;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPay);
			this.Controls.Add(this.groupBoxOthers);
			this.Controls.Add(this.groupBoxDrink);
			this.Name = "Form1";
			this.Text = "Coffee";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxDrink.ResumeLayout(false);
			this.groupBoxDrink.PerformLayout();
			this.groupBoxOthers.ResumeLayout(false);
			this.groupBoxOthers.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxDrink;
		private System.Windows.Forms.GroupBox groupBoxOthers;
		private System.Windows.Forms.Button buttonPay;
		private System.Windows.Forms.RadioButton radioButtonH;
		private System.Windows.Forms.RadioButton radioButtonT;
		private System.Windows.Forms.RadioButton radioButtonC;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
	}
}

