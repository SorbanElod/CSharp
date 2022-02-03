using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45_MatrixBoxes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random rn = new Random();
		private int ui = 3;
		private int uj = 3;
		private static int n = 4;
		Button[,] g = new Button[n,n];

		private void button1_Click(object sender, EventArgs e)
		{
			int num = rn.Next(4);
			int num2 = ui;
			int num3 = uj;
			switch (num)
			{
				case 0:
					num2 = ui - 1;
					break;
				case 1:
					num3 = uj + 1;
					break;
				case 2:
					num2 = ui + 1;
					break;
				case 3:
					num3 = uj - 1;
					break;
			}
			label1.Text = num2 + " sor " + num3 + " oszlop ";
			if (num2 >= 0 && num2 < 4 && num3 >= 0 && num3 < 4)
			{
				Swap(num2, num3);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					g[i,j] = new Button();
					g[i, j].Width = panel1.Width / n;
					g[i, j].Height = panel1.Height / n;
					g[i, j].Text = (4 * i + j + 1).ToString();
					g[i, j].BackColor = Color.Orange;
					g[i, j].Font = label1.Font;
					panel1.Controls.Add(g[i,j]);
					g[i, j].Left = j * panel1.Width / n;
					g[i, j].Top = i * panel1.Height / n;
					g[i,j].Click += new System.EventHandler(button_Click);
					panel1.Controls.Add(g[i, j]);
				}
			}
			g[3, 3].Dispose();
		}
		private void Swap(int i,int j)
		{
			g[i, j].Top = ui * g[i, j].Height;
			g[i, j].Left = uj * g[i, j].Width;
			g[ui, uj] = g[i, j];
			ui = i;
			uj = j;
		}
		private void button_Click(object sender, EventArgs e)
		{
			int num = (sender as Button).Top / (sender as Button).Height;
			int num2 = (sender as Button).Left / (sender as Button).Width;
			if ((num == ui && Math.Abs(uj - num2) == 1) || (num2 == uj && Math.Abs(ui - num) == 1))
			{
				Swap(num, num2);
			}
			if (helyes())
			{
				MessageBox.Show(" ", "Gratulalok");
			}
		}

		private bool helyes()
		{
			int num = 1;
			if (ui != 3 || uj != 3)
			{
				return false;
			}
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (i == 3 && j == 3)
					{
						return true;
					}
					if (Convert.ToInt32(g[i, j].Text) != num)
					{
						return false;
					}
					num++;
				}
			}
			return true;
		}
	}
}
