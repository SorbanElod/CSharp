using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_EarthImgList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
		private int i = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			i = i % 16;
			pictureBox1.Image = imageList1.Images[i++];
		}

		private string[] Names;
		private int n;
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
			Names = Directory.GetFiles("Pictures", "*.png");
			n = Names.Count();
			foreach(string s in Names)
			{
				imageList1.Images.Add(Image.FromFile(s));
			}
			pictureBox1.Image = imageList1.Images[0];
		}
	}
}
