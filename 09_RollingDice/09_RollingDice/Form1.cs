using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_RollingDice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRoll_Click(object sender, EventArgs e)
		{
			Random generate = new Random();
			int rn = generate.Next(1,7);
			label1.Text = rn.ToString();
		}
	}
}
