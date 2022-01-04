using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_VisibleUnvisible
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void buttonVisible_Click(object sender, EventArgs e)
		{
			if (labelOne.Visible != true)
			{
				buttonVisible.Text = "Show label";
			}
			else buttonVisible.Text = "Hide label";
			labelOne.Visible = !labelOne.Visible;
		}

		private void buttonDisable_Click(object sender, EventArgs e)
		{
			buttonVisible.Enabled = false;
		}
	}
}
