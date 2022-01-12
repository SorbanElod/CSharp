using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_LabelsMoving
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int speed = 2;
		private void timer1_Tick(object sender, EventArgs e)
		{
			move1();
			move2();

		}
		private void move1()
		{
			int dirX = 1;
			int dirY = 1;
			int x = label1.Left + dirX * speed;
			int y = label1.Top + dirX * speed;
			if (x > 0 && x < ClientSize.Width - label1.Width)
			{
				label1.Left = x;
			}
			else
			{
				label1.Top = ClientSize.Height - label1.Height;
				label1.Left = ClientSize.Width - label1.Width;
			}
			if (y > 0 && y < ClientSize.Height - label1.Height)
			{
				label1.Top = y;
			}
		}

		private void move2()
		{
			int dirX = -1;
			int dirY = -1;
			int x = label2.Left + dirX * speed;
			int y = label2.Top + dirY * speed;
			if (x > 0 && x < ClientSize.Width - label2.Width)
			{
				label2.Left = x;
			}
			else
			{
				label2.Top = 0;
				label2.Left = 0;
			}
			if (y > 0 && y < ClientSize.Height - label2.Height)
			{
				label2.Top = y;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Top = 0;
			label1.Left = 0;
			label2.Top = ClientSize.Height - label2.Height;
			label2.Left = ClientSize.Width - label2.Width;
			timer1.Interval = 10;
			timer1.Start();
		}
	}
}
