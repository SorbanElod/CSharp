namespace _23_TextFormat
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelPrint = new System.Windows.Forms.Label();
			this.groupBoxColor = new System.Windows.Forms.GroupBox();
			this.groupBoxStyle = new System.Windows.Forms.GroupBox();
			this.groupBoxFont = new System.Windows.Forms.GroupBox();
			this.groupBoxText = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxR = new System.Windows.Forms.CheckBox();
			this.checkBoxG = new System.Windows.Forms.CheckBox();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.checkBoxBold = new System.Windows.Forms.CheckBox();
			this.checkBoxUnder = new System.Windows.Forms.CheckBox();
			this.checkBoxItalic = new System.Windows.Forms.CheckBox();
			this.radioButtonArial = new System.Windows.Forms.RadioButton();
			this.radioButtonTimes = new System.Windows.Forms.RadioButton();
			this.radioButtonComic = new System.Windows.Forms.RadioButton();
			this.radioButtonAurebesh = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.groupBoxColor.SuspendLayout();
			this.groupBoxStyle.SuspendLayout();
			this.groupBoxFont.SuspendLayout();
			this.groupBoxText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Szoveg",
            "Hatter"});
			this.comboBox1.Location = new System.Drawing.Point(232, 66);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(163, 30);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(64, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mit?";
			// 
			// labelPrint
			// 
			this.labelPrint.Font = new System.Drawing.Font("Book Antiqua", 12F);
			this.labelPrint.Location = new System.Drawing.Point(451, 47);
			this.labelPrint.Name = "labelPrint";
			this.labelPrint.Size = new System.Drawing.Size(525, 133);
			this.labelPrint.TabIndex = 2;
			this.labelPrint.Text = "Lorem Ipsum";
			this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBoxColor
			// 
			this.groupBoxColor.Controls.Add(this.checkBoxB);
			this.groupBoxColor.Controls.Add(this.checkBoxG);
			this.groupBoxColor.Controls.Add(this.checkBoxR);
			this.groupBoxColor.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBoxColor.Location = new System.Drawing.Point(41, 223);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Size = new System.Drawing.Size(199, 274);
			this.groupBoxColor.TabIndex = 3;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Szin";
			// 
			// groupBoxStyle
			// 
			this.groupBoxStyle.Controls.Add(this.checkBoxBold);
			this.groupBoxStyle.Controls.Add(this.checkBoxUnder);
			this.groupBoxStyle.Controls.Add(this.checkBoxItalic);
			this.groupBoxStyle.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBoxStyle.Location = new System.Drawing.Point(257, 223);
			this.groupBoxStyle.Name = "groupBoxStyle";
			this.groupBoxStyle.Size = new System.Drawing.Size(199, 274);
			this.groupBoxStyle.TabIndex = 4;
			this.groupBoxStyle.TabStop = false;
			this.groupBoxStyle.Text = "Stilus";
			// 
			// groupBoxFont
			// 
			this.groupBoxFont.Controls.Add(this.radioButtonAurebesh);
			this.groupBoxFont.Controls.Add(this.radioButtonComic);
			this.groupBoxFont.Controls.Add(this.radioButtonTimes);
			this.groupBoxFont.Controls.Add(this.radioButtonArial);
			this.groupBoxFont.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBoxFont.Location = new System.Drawing.Point(473, 223);
			this.groupBoxFont.Name = "groupBoxFont";
			this.groupBoxFont.Size = new System.Drawing.Size(199, 274);
			this.groupBoxFont.TabIndex = 5;
			this.groupBoxFont.TabStop = false;
			this.groupBoxFont.Text = "Betutipus";
			// 
			// groupBoxText
			// 
			this.groupBoxText.Controls.Add(this.buttonRefresh);
			this.groupBoxText.Controls.Add(this.textBox1);
			this.groupBoxText.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBoxText.Location = new System.Drawing.Point(689, 223);
			this.groupBoxText.Name = "groupBoxText";
			this.groupBoxText.Size = new System.Drawing.Size(330, 274);
			this.groupBoxText.TabIndex = 6;
			this.groupBoxText.TabStop = false;
			this.groupBoxText.Text = "Uj szoveg";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDown1.Location = new System.Drawing.Point(232, 141);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(163, 30);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(64, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Meret";
			// 
			// checkBoxR
			// 
			this.checkBoxR.AutoSize = true;
			this.checkBoxR.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxR.Location = new System.Drawing.Point(52, 67);
			this.checkBoxR.Name = "checkBoxR";
			this.checkBoxR.Size = new System.Drawing.Size(73, 26);
			this.checkBoxR.TabIndex = 0;
			this.checkBoxR.Text = "Piros";
			this.checkBoxR.UseVisualStyleBackColor = true;
			this.checkBoxR.CheckedChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// checkBoxG
			// 
			this.checkBoxG.AutoSize = true;
			this.checkBoxG.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxG.Location = new System.Drawing.Point(52, 127);
			this.checkBoxG.Name = "checkBoxG";
			this.checkBoxG.Size = new System.Drawing.Size(70, 26);
			this.checkBoxG.TabIndex = 1;
			this.checkBoxG.Text = "Zold";
			this.checkBoxG.UseVisualStyleBackColor = true;
			this.checkBoxG.CheckedChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// checkBoxB
			// 
			this.checkBoxB.AutoSize = true;
			this.checkBoxB.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxB.Location = new System.Drawing.Point(52, 187);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(64, 26);
			this.checkBoxB.TabIndex = 2;
			this.checkBoxB.Text = "Kek";
			this.checkBoxB.UseVisualStyleBackColor = true;
			this.checkBoxB.CheckedChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// checkBoxBold
			// 
			this.checkBoxBold.AutoSize = true;
			this.checkBoxBold.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxBold.Location = new System.Drawing.Point(39, 184);
			this.checkBoxBold.Name = "checkBoxBold";
			this.checkBoxBold.Size = new System.Drawing.Size(104, 26);
			this.checkBoxBold.TabIndex = 5;
			this.checkBoxBold.Text = "Felkover";
			this.checkBoxBold.UseVisualStyleBackColor = true;
			this.checkBoxBold.CheckedChanged += new System.EventHandler(this.StyleChange);
			// 
			// checkBoxUnder
			// 
			this.checkBoxUnder.AutoSize = true;
			this.checkBoxUnder.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxUnder.Location = new System.Drawing.Point(39, 124);
			this.checkBoxUnder.Name = "checkBoxUnder";
			this.checkBoxUnder.Size = new System.Drawing.Size(112, 26);
			this.checkBoxUnder.TabIndex = 4;
			this.checkBoxUnder.Text = "Alahuzott";
			this.checkBoxUnder.UseVisualStyleBackColor = true;
			this.checkBoxUnder.CheckedChanged += new System.EventHandler(this.StyleChange);
			// 
			// checkBoxItalic
			// 
			this.checkBoxItalic.AutoSize = true;
			this.checkBoxItalic.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkBoxItalic.Location = new System.Drawing.Point(39, 64);
			this.checkBoxItalic.Name = "checkBoxItalic";
			this.checkBoxItalic.Size = new System.Drawing.Size(65, 26);
			this.checkBoxItalic.TabIndex = 3;
			this.checkBoxItalic.Text = "Dolt";
			this.checkBoxItalic.UseVisualStyleBackColor = true;
			this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.StyleChange);
			// 
			// radioButtonArial
			// 
			this.radioButtonArial.AutoSize = true;
			this.radioButtonArial.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButtonArial.Location = new System.Drawing.Point(6, 40);
			this.radioButtonArial.Name = "radioButtonArial";
			this.radioButtonArial.Size = new System.Drawing.Size(60, 26);
			this.radioButtonArial.TabIndex = 0;
			this.radioButtonArial.TabStop = true;
			this.radioButtonArial.Text = "Arial";
			this.radioButtonArial.UseVisualStyleBackColor = true;
			this.radioButtonArial.CheckedChanged += new System.EventHandler(this.FontChange);
			// 
			// radioButtonTimes
			// 
			this.radioButtonTimes.AutoSize = true;
			this.radioButtonTimes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButtonTimes.Location = new System.Drawing.Point(6, 96);
			this.radioButtonTimes.Name = "radioButtonTimes";
			this.radioButtonTimes.Size = new System.Drawing.Size(170, 24);
			this.radioButtonTimes.TabIndex = 1;
			this.radioButtonTimes.TabStop = true;
			this.radioButtonTimes.Text = "Times New Roman";
			this.radioButtonTimes.UseVisualStyleBackColor = true;
			this.radioButtonTimes.CheckedChanged += new System.EventHandler(this.FontChange);
			// 
			// radioButtonComic
			// 
			this.radioButtonComic.AutoSize = true;
			this.radioButtonComic.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.radioButtonComic.Location = new System.Drawing.Point(6, 152);
			this.radioButtonComic.Name = "radioButtonComic";
			this.radioButtonComic.Size = new System.Drawing.Size(152, 28);
			this.radioButtonComic.TabIndex = 2;
			this.radioButtonComic.TabStop = true;
			this.radioButtonComic.Text = "Comic Sans Ms";
			this.radioButtonComic.UseVisualStyleBackColor = true;
			this.radioButtonComic.CheckedChanged += new System.EventHandler(this.FontChange);
			// 
			// radioButtonAurebesh
			// 
			this.radioButtonAurebesh.AutoSize = true;
			this.radioButtonAurebesh.Font = new System.Drawing.Font("Aurebesh Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonAurebesh.Location = new System.Drawing.Point(6, 208);
			this.radioButtonAurebesh.Name = "radioButtonAurebesh";
			this.radioButtonAurebesh.Size = new System.Drawing.Size(111, 25);
			this.radioButtonAurebesh.TabIndex = 3;
			this.radioButtonAurebesh.TabStop = true;
			this.radioButtonAurebesh.Text = "Aurebesh";
			this.radioButtonAurebesh.UseVisualStyleBackColor = true;
			this.radioButtonAurebesh.CheckedChanged += new System.EventHandler(this.FontChange);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(65, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(213, 30);
			this.textBox1.TabIndex = 9;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(98, 137);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(148, 61);
			this.buttonRefresh.TabIndex = 10;
			this.buttonRefresh.Text = "Atir";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 543);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.groupBoxText);
			this.Controls.Add(this.groupBoxFont);
			this.Controls.Add(this.groupBoxStyle);
			this.Controls.Add(this.groupBoxColor);
			this.Controls.Add(this.labelPrint);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxColor.ResumeLayout(false);
			this.groupBoxColor.PerformLayout();
			this.groupBoxStyle.ResumeLayout(false);
			this.groupBoxStyle.PerformLayout();
			this.groupBoxFont.ResumeLayout(false);
			this.groupBoxFont.PerformLayout();
			this.groupBoxText.ResumeLayout(false);
			this.groupBoxText.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPrint;
		private System.Windows.Forms.GroupBox groupBoxColor;
		private System.Windows.Forms.GroupBox groupBoxStyle;
		private System.Windows.Forms.GroupBox groupBoxFont;
		private System.Windows.Forms.GroupBox groupBoxText;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxB;
		private System.Windows.Forms.CheckBox checkBoxG;
		private System.Windows.Forms.CheckBox checkBoxR;
		private System.Windows.Forms.CheckBox checkBoxBold;
		private System.Windows.Forms.CheckBox checkBoxUnder;
		private System.Windows.Forms.CheckBox checkBoxItalic;
		private System.Windows.Forms.RadioButton radioButtonComic;
		private System.Windows.Forms.RadioButton radioButtonTimes;
		private System.Windows.Forms.RadioButton radioButtonArial;
		private System.Windows.Forms.RadioButton radioButtonAurebesh;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonRefresh;
	}
}

