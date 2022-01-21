using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_DividePanel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 10;
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			buttonGenerate.Enabled = true;
			buttonDelete.Enabled = false;
		}
		Random rnGee = new Random();
		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			n = (int)(numericUpDown1.Value);
			Label[] g = new Label[n];
			for(int i = 0; i < n; i++)
			{
				g[i] = new Label();
				g[i].Name = "lb" + i;
				g[i].Size = panel1.Size;
				g[i].Width /= n;
				g[i].Left = ((panel1.Width / n) * i);
				g[i].BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
				g[i].Click += new EventHandler(g_Click);
				g[i].MouseEnter += new EventHandler(g_Click);
				panel1.Controls.Add(g[i]);
				buttonGenerate.Enabled = false;
				buttonDelete.Enabled = true;
			}
		}
		private void g_Click(object sender, EventArgs e)
		{
			(sender as Label).BackColor = Color.FromArgb(rnGee.Next(0, 255), rnGee.Next(0, 255), rnGee.Next(0, 255));
			labelPrint.Text = ((sender as Label).Left/ (sender as Label).Width).ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			buttonDelete.Enabled = false;
		}
	}
}
