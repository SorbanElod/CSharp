using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Henger
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCount_Click(object sender, EventArgs e)
		{
			double r, h;
			if(double.TryParse(maskedTextBoxR.Text, out r))
			{
				if (double.TryParse(textBoxH.Text, out h))
				{
					double eredmeny = r * r * h * Math.PI;
					labelEredmeny.Text = eredmeny.ToString();
				}

			}

		}
	}
}
