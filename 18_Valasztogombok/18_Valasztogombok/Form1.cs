using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Valasztogombok
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void LabelColorChange(object sender, EventArgs e)
		{
			label1.BackColor = (sender as RadioButton).BackColor;
		}

		private void FontColorChanged(object sender, EventArgs e)
		{
			label1.ForeColor = (sender as RadioButton).BackColor;
		}
	}
}
