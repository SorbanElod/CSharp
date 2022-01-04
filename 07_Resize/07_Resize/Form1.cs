using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Resize
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int leptek = 5;
		private void buttonMinus_Click(object sender, EventArgs e)
		{
			this.Width -= leptek;
			this.Height -= leptek;

			
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			this.Width += leptek;
			this.Height += leptek;

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			this.CenterToScreen();
		}

		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			this.CenterToScreen();
		}
	}
}
