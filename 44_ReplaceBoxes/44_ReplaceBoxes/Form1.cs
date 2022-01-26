using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_ReplaceBoxes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 300;
		Random rnGee = new Random();
		Label[] g = new Label[n];

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 50;
			numericUpDown1.Maximum = n;
			numericUpDown1.Minimum = 2;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			n = (int)(numericUpDown1.Value);
			for(int i = 0; i < n; i++)
			{
				g[i] = new Label();
				g[i].Height = panel1.Height / n;
				g[i].Width = panel1.Width / 3;
				g[i].Left = 0;
				g[i].Top = g[i].Height * i;
				g[i].MouseEnter += new System.EventHandler(label_MouseEnter);
				g[i].BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
				panel1.Controls.Add(g[i]);
			}
			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
			numericUpDown1.Enabled = false;
		}
		private void label_MouseEnter(object sender, EventArgs e)
		{
			(sender as Label).Top = (sender as Label).Height * (n-((sender as Label).Top/(sender as Label).Height)-1);
			if ((sender as Label).Left == 2* (sender as Label).Width)
			{
				(sender as Label).Left = 0;
			}
			else
			{
				(sender as Label).Left = 2 * (sender as Label).Width;
			}
		}
		private void buttonStop_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < n; i++)
			{
				if (g[i] != null)
				{
					g[i].Dispose();
					g[i] = null;
				}
			}
			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
			numericUpDown1.Enabled = true;
		}
	}
}
