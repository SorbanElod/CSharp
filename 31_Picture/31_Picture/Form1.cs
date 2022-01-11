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
		private int speed = 10;
		Random rn = new Random();
		int dirX = 1, dirY = 1;

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int x = pictureBox1.Left + dirX * speed;
			int y = pictureBox1.Top + dirY * speed;
			if(x>0 && x+pictureBox1.Width > ClientSize.Width)
			{
				pictureBox1.Left = x;
			}
			if (y>0 && y + pictureBox1.Height> ClientSize.Height)
			{
				pictureBox1.Top = y;
			}
		}
	}
}
