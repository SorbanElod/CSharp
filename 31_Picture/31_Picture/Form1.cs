using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Picture
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int speed = 100;
		Random rn = new Random();
		int dirX = 1, dirY = 1;

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (timer1.Enabled)
			{
				pictureBox1.Image = Image.FromFile("tancos2.png");
			}
			else
			{
				pictureBox1.Image = Image.FromFile("tancos1.png");
			}
			timer1.Enabled = !timer1.Enabled;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int x = pictureBox1.Left + dirX * speed;
			int y = pictureBox1.Top + dirY * speed;
			if(x>0 && x < ClientSize.Width - pictureBox1.Width)
			{
				pictureBox1.Left = x;
			}
			else
			{
				dirX = -dirX;
			}
			if (y>0 && y < ClientSize.Height - pictureBox1.Height)
			{
				pictureBox1.Top = y;
			}
			else
			{
				dirY = -dirY;
			}
		}
	}
}
