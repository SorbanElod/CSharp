using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_RGB
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void hScrollBarSize_Scroll(object sender, ScrollEventArgs e)
		{
			label1.Width = hScrollBarSize.Value;
		}

		private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
		{
			label1.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
			labelRed.Text = String.Format("R {0,3}", hScrollBarRed.Value);
			labelGreen.Text = String.Format("G {0,3}", hScrollBarGreen.Value);
			labelBlue.Text = String.Format("B {0,3}", hScrollBarBlue.Value);
		}
	}
}
