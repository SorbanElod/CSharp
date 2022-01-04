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
		public Form1()
		{
			InitializeComponent();
		}
		
		private void ButtonClikked(object sender, EventArgs e)
		{
			
			Control send = (Control)sender;
			i = int.Parse(send.Tag.ToString())/3;
			j = int.Parse(send.Tag.ToString())%3;
			if (player == true)
			{
				matrix[i,j] = -1;
				send.Text = matrix[i, j].ToString();
			}
			else
			{
				matrix[i,j] = 1;
				send.Text = matrix[i,j].ToString();
			}
			player = !player;
			send.Enabled = false;
			CheckIfWin();
		}
		private void CheckIfWin()
		{
			//Vertical
			for(int i = 0; i < 3; i++)
			{

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
