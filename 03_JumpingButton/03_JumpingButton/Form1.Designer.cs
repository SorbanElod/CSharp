namespace _03_JumpingButton
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
			this.buttonYes = new System.Windows.Forms.Button();
			this.buttonNo = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonYes
			// 
			this.buttonYes.Location = new System.Drawing.Point(361, 271);
			this.buttonYes.Name = "buttonYes";
			this.buttonYes.Size = new System.Drawing.Size(100, 50);
			this.buttonYes.TabIndex = 0;
			this.buttonYes.TabStop = false;
			this.buttonYes.Text = "Yes";
			this.buttonYes.UseVisualStyleBackColor = true;
			this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
			this.buttonYes.MouseEnter += new System.EventHandler(this.buttonYes_MouseEnter);
			// 
			// buttonNo
			// 
			this.buttonNo.Location = new System.Drawing.Point(575, 77);
			this.buttonNo.Name = "buttonNo";
			this.buttonNo.Size = new System.Drawing.Size(100, 50);
			this.buttonNo.TabIndex = 1;
			this.buttonNo.Text = "No";
			this.buttonNo.UseVisualStyleBackColor = true;
			this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(110, 77);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(100, 50);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelText
			// 
			this.labelText.BackColor = System.Drawing.Color.Lime;
			this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelText.Location = new System.Drawing.Point(256, 154);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(279, 73);
			this.labelText.TabIndex = 3;
			this.labelText.Text = "Do you like Windows?";
			this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.buttonYes);
			this.Controls.Add(this.labelText);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonNo);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelText;
    }
}

