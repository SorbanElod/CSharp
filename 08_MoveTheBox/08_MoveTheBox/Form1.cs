using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_MoveTheBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int x = (this.ClientSize.Width - 2*labelOne.Width)/3;
			labelOne.Left = x;
			labelTwo.Left = ClientSize.Width - (x + labelTwo.Width);
			labelOne.Top = ClientSize.Height / 2 - labelOne.Height;
			labelTwo.Top = ClientSize.Height / 2 - labelTwo.Height;
		}
		const int leptek = 6;
		private void labelOne_MouseMove(object sender, EventArgs e)
		{
			if(labelOne.Top >= leptek)
			{
				labelOne.Top -= leptek;
				labelTwo.Top += leptek;

			}
			else
			{
				labelOne.Top = 0;
			}
		}

		private void labelTwo_MouseMove(object sender, EventArgs e)
		{
			if (labelTwo.Top >= leptek)
			{
				labelOne.Top += leptek;
				labelTwo.Top -= leptek;
			}
			else
			{
				labelTwo.Top = 0;
			}

		}
	}
}
