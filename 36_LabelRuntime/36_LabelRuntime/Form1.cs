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
				Label label1 = new Label();
				label1.Text = "Hello There!";
				label1.BackColor = Color.DarkKhaki;
				panel1.Controls.Add(label1);
				label1.Top = generate.Next(panel1.Height - label1.Height);
				label1.Left = generate.Next(panel1.Width - label1.Width);
				button1.Text = "Delete label";
				
				exists = true;
			}
			else
			{
				button1.Text = "Add Label";
				panel1.Controls.Clear();
				exists = false;
			}
		}
	}
}
