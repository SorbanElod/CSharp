using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void NumberIn(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void PlusMinus(object sender, EventArgs e)
		{
			if(textBox1.Text.Length > 0)
			{
				if (textBox1.Text.Contains("-") == false)
				{
					textBox1.Text = "-" + textBox1.Text;
				}
				else
				{
					textBox1.Text = textBox1.Text.Substring(1);
				}
			}
		}

		private void InsertDot(object sender, EventArgs e)
		{
			if (textBox1.Text.Contains(".") == false)
			{
				if(textBox1.Text.Length > 0)
				{

				}
			}
			else
			{
				
			}
		}
	}
}
