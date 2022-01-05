using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_XO
{
	public partial class Form1 : Form
	{
		private int[,] matrix = new int[3, 3];
		private bool player = true;
		private int i;
		private int j;
		private int clicks = 0;
		private int winX = 0;
		private int winY = 0;
		public Form1()
		{
			InitializeComponent();
		}
		private void upload()
		{ 
			int db = 2;
			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					matrix[i, j] = db++;
				}
			}
		}
		private void ButtonClikked(object sender, EventArgs e)
		{
			clicks++;
			Control send = (Control)sender;
			i = int.Parse(send.Tag.ToString())/3;
			j = int.Parse(send.Tag.ToString())%3;
			if (player == true)
			{
				matrix[i, j] = -1;
				send.Text = "X";
			}
			else
			{
				matrix[i, j] = 1;
				send.Text = "Y";
			}
			send.Enabled = false;
			CheckIfWin();
			player = !player;
		}
		private void CheckIfWin()
		{
			for(int i = 0; i < 3; i++)
			{
				if (matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i])
				{
					if (player == true)
					{
						MessageBox.Show("X wins!");
						winX++;
					}
					else
					{
						MessageBox.Show("Y wins!");
						winY++;
					}
					restart();
				}
				else if (matrix[i,0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2])
				{
					if (player == true)
					{
						MessageBox.Show("X wins!");
						winX++;
					}
					else
					{
						MessageBox.Show("Y wins!");
						winY++;
					}
					restart();
				}
				else if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
				{
					if (player == true)
					{
						MessageBox.Show("X wins!");
						winX++;
					}
					else
					{
						MessageBox.Show("Y wins!");
						winY++;
					}
					restart();
				}
				else if (matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
				{
					if (player == true)
					{
						MessageBox.Show("X wins!");
						winX++;
					}
					else
					{
						MessageBox.Show("Y wins!");
						winY++;
					}
					restart();
				}
				else if(clicks == 9)
				{
					MessageBox.Show("Draw");
					restart();
				}
			}
		}
		private void restart()
		{
			foreach(Control b in Controls)
			{
				if (b is Button)
				{
					b.Text = "";
					b.Enabled = true;
				}
			}
			player = false;
			clicks = 0;
			upload();
			labelWin.Text = "X: "+winX+"       Y: "+winY;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			upload();
			labelWin.Text = "X: 0       Y: 0";
		}

		private void labelWin_DoubleClick(object sender, EventArgs e)
		{
			winX = 0;
			winY = 0;
			restart();
		}
	}
}
