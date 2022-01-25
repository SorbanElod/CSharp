using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41_PuzzleSort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static int n = 100;
		Button[] g = new Button[n];
		static int current = n-1;
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < n; i++)
			{
				if (g[i] != null)
				{
					g[i].Dispose();
				}
			}
			//panel1.Controls.Clear();
			buttonCreate.Enabled = true;
			buttonClear.Enabled = false;
		}
		Random rnGee = new Random();
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			buttonCreate.Enabled = false;
			buttonClear.Enabled = true;

			n = (int)(numericUpDown1.Value);
			current = n - 1;
			for (int i = 0; i < n; i++)
			{
				g[i] = new Button();
					g[i].Name = "lb" + i;
					g[i].Text = rnGee.Next(1,999).ToString();
					g[i].Size = panel1.Size;
					g[i].Width /= n;
					g[i].Left = (g[i].Width * i);
					g[i].Click += new EventHandler(g_Click);
					panel1.Controls.Add(g[i]);
			}
			g[n-1].Text = "";
			current = n - 1;
		}
		private void g_Click(object sender, EventArgs e)
		{
			g[current].Text = (sender as Button).Text;
			(sender as Button).Text = "";
			current = (sender as Button).Left / (sender as Button).Width;
			if(Check() == true)
			{
				MessageBox.Show("Good");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			buttonCreate.Enabled = true;
			buttonClear.Enabled = false;
			numericUpDown1.Maximum = n;
		}
		private bool Check()
		{
			bool buul = false;
			if(g[0].Text == "")
			{
				buul = true;
				for(int i = 1; i < n-1; i++)
				{
					if (int.Parse(g[i].Text) > int.Parse(g[i + 1].Text)) ;
					buul = true;
				}
			}
			return buul;
		}
	}
}
