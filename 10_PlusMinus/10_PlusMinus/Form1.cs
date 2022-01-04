using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_PlusMinus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int num;
		private void buttonPlus_Click(object sender, EventArgs e)
		{
			num = int.Parse(label1.Text);
			num++;
			label1.Text = num.ToString();
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			num = int.Parse(label1.Text);
			num--;
			label1.Text = num.ToString();

		}
	}
}
