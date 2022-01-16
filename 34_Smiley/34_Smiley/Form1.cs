using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_Smiley
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int i = 1;
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 1;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			i = i % 4;
			pictureBox1.Image = Bitmap.FromFile("fejecs" + ++i + ".bmp");
		}
	}
}
