using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43_MultiplaeFallingButtons
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 16;
		Random rnGee = new Random();
		Button[] g = new Button[n];

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 50;
			numericUpDown1.Maximum = n;
			numericUpDown1.Minimum = 1;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			n = (int)(numericUpDown1.Value);
			for (int i = 0; i < n; i++)
			{
				if(g[i] != null)
				{
					g[i].Dispose();
					g[i] = null;
				}
				g[i] = new Button();
				g[i].Text = (i + 1).ToString();
				g[i].Width = panel1.Width / n;
				g[i].Height *= 2;
				g[i].Left = g[i].Width * i;
				g[i].Click += new System.EventHandler(g_Click);
				g[i].BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
				panel1.Controls.Add(g[i]);
				g[i].Top = - rnGee.Next(200);
			}
			numericUpDown1.Enabled = false;
			{
				timer1.Start();
				timer2.Start();
				buttonStart.Enabled = false;
				numericUpDown1.Enabled = false;
			}
		}
		private void g_Click(object sender, EventArgs e)
		{
			label1.Text = (int.Parse(label1.Text) + int.Parse((sender as Button).Text)).ToString();
			(sender as Button).Top = -rnGee.Next(200);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			for(int i = 0; i < n; i++)
			{
				g[i].Top +=rnGee.Next(1,4);
				if (g[i].Top >= panel1.Height - g[i].Height)
				{
					Freeze();
					MessageBox.Show("Game Over");
					buttonStart.Enabled = true;
					numericUpDown1.Enabled = true;
				}
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
		private void Freeze()
		{
			timer1.Stop();
			timer2.Stop(); 
			foreach (Control c in panel1.Controls)
			{
				c.Enabled = false;
			}
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			labelTime.Text = (int.Parse(labelTime.Text)+1).ToString();
			if(int.Parse(labelTime.Text) == 30)
			{
				Freeze();
				MessageBox.Show("Game Over\nTime Expired");
				buttonStart.Enabled = true;
				numericUpDown1.Enabled = true;
			}
		}
	}
}
