using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38_ButtonGenerate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 10;
		Random r = new Random();
		Button[] g = new Button[n];
		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			// for (int i = 0; i < n; i++) panel1.Controls.Remove(g[i]);
			for (int i = 0; i < n; i++)
				if (g[i] != null) g[i].Dispose();
			for (int i = 0; i < n; i++)
			{
				g[i] = new Button();
				g[i].Name = "btn" + i;
				g[i].Text = i.ToString();
				g[i].Width = 40;
				g[i].Height = 20;
				g[i].Top = r.Next(panel1.Height - g[i].Height);
				g[i].Left = r.Next(panel1.Width - g[i].Width);
				panel1.Controls.Add(g[i]);
				g[i].Click += new EventHandler(g_Click);
			}
		}
		private void g_Click(object sender, EventArgs e)
		{
			//panel1.Controls.Remove(sender as Button);
			(sender as Button).Dispose();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < n; i++)
			{

				g[i].Top = r.Next(panel1.Height - g[i].Height);
				g[i].Left = r.Next(panel1.Width - g[i].Width);

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Interval = 500;
		}
	}
}