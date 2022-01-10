using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_LabelTimer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.BackColor = Color.DarkKhaki;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Height++;
			label1.Width++;
			label1.Top = (this.Height - label1.Height) / 2;
			label1.Left = (this.Width - label1.Width) / 2;
		}
	}
}