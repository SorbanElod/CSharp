using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_LabelRuntime
{
	public partial class Form1 : Form
	{
		Label label1;
		public Form1()
		{
			InitializeComponent();
		}
		private bool exists = false;
		Random generate = new Random();
		private void button1_Click(object sender, EventArgs e)
		{
			if (exists == false)
			{
				button1.Text = "Delete label";
				Label label1 = new Label();
				label1.Text = "Hello There!";
				label1.BackColor = Color.DarkKhaki;
				label1.Width = 150;
				label1.Height = 30;
				label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
				label1.Top = generate.Next(panel1.Height - label1.Height);
				label1.Left = generate.Next(panel1.Width - label1.Width);
				label1.Click += new System.EventHandler(this.label1_Click);
				panel1.Controls.Add(label1);
				
				exists = true;
			}
			else
			{
				button1.Text = "Add Label";
				panel1.Controls.Clear();
				exists = false;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("I'm bad in F1","Fact");
		}
	}
}
