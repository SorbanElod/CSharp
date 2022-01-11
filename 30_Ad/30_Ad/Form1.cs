using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Ad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private int i = 0;
		private char ch;
		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "This is a very very long text      ";
			timer1.Interval = 100;
			timer1.Start();
		}
		private void colour()
		{
			Random random = new Random();
			label1.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
			label1.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
			this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			colour();
			ch = label1.Text[0];
			label1.Text = label1.Text.Substring(1);
			label1.Text += ch;
		}
	}
}
