using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40_MatrixColors
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 100;
		Label[,] g = new Label[n, n];
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			/*
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					g[i, j].Dispose();
				}
			}
			*/
			buttonCreate.Enabled = true;
			buttonClear.Enabled = false;
		}
		Random rnGee = new Random();
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			buttonCreate.Enabled = false;
			buttonClear.Enabled = true;

			n = (int)(numericUpDown1.Value);
			for (int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					g[i,j] = new Label();
					g[i,j].Name = "lb" + i+"_"+j;
					g[i,j].Size = panel1.Size;
					g[i,j].Width /= n;
					g[i,j].Height /= n;
					g[i,j].Left = (g[i,j].Width * j);
					g[i,j].Top = (g[i,j].Height * i);
					g[i,j].BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
					g[i,j].Click += new EventHandler(g_Click);
					g[i,j].MouseEnter += new EventHandler(g_Click);
					panel1.Controls.Add(g[i,j]);
				}
			}
		}

		private void g_Click(object sender, EventArgs e)
		{
			(sender as Label).BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
			labelPrint.Text = ((sender as Label).Left / (sender as Label).Width).ToString() + " , " + ((sender as Label).Top / (sender as Label).Height);
			labelRGB.Text = (sender as Label).BackColor.R + "," + (sender as Label).BackColor.G + "," + (sender as Label).BackColor.B;
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			buttonCreate.Enabled = true;
			buttonClear.Enabled = false;
			numericUpDown1.Maximum = n;
		}
	}
}