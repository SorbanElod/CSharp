using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42_FallingButtons
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 16;
		Random rnGee = new Random();
		Button [] g = new Button [n]; 
		private int index = 0;
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 50;
			numericUpDown1.Maximum = n;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			n = (int)(numericUpDown1.Value);
			for(int i = 0; i < n; i++)
			{
				g[i] = new Button();
				g[i].Text = (i+1).ToString();
				g[i].Width = panel1.Width / n;
				g[i].Left = g[i].Width * i;
				g[i].Click += new System.EventHandler(g_Click);
				g[i].BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
				panel1.Controls.Add(g[i]);
				g[i].Visible = false;
			}
			int a = rnGee.Next(n);
			g[a].Visible = true;
			numericUpDown1.Enabled = false;
			index = a;
			if (timer1.Enabled == true)
			{
				timer1.Stop();
				buttonStart.Text = "Start";
			}
			else
			{
				timer1.Start();
				buttonStart.Text = "Stop";
			}
		}
		private void g_Click(object sender, EventArgs e)
		{
			label1.Text = (int.Parse(label1.Text) + int.Parse((sender as Button).Text)).ToString();
			(sender as Button).Visible = false;
			int a = rnGee.Next(n);
			g[a].Visible = true;
			g[a].Top = 0;
			index = a;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			g[index].Top += 5;
			if (g[index].Top >= panel1.Height - g[index].Height)
			{
				g[index].Visible = false;
				int a = rnGee.Next(n);
				g[a].Visible = true;
				g[a].Top = 0;
				index = a;
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
	}
}
