using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_EarthWithoutImageList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int i;
		private void timer1_Tick(object sender, EventArgs e)
		{
			i = i % 16;
			pictureBox1.Image = Image.FromFile($@"Pictures\W{++i}.png");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Interval = 10;
			timer1.Enabled = !timer1.Enabled;
			if (timer1.Enabled == true)
			{
				button1.Text = "Stop";
			}
			else button1.Text = "Start";
		}
	}
}
