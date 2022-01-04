using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_Logic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Refresh(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0:
					MessageBox.Show("Not P = "+!checkBoxP.Checked);
					break;
				case 1:
					MessageBox.Show("P And Q = " + (checkBoxP.Checked && checkBoxQ.Checked));
					break;
				case 2:
					MessageBox.Show("P Or Q = " + (checkBoxP.Checked || checkBoxQ.Checked));
					break;
				case 3:
					MessageBox.Show("P XOr Q = " + (checkBoxP.Checked ^ checkBoxQ.Checked));
					break;
				case 4:
					MessageBox.Show("P NAnd Q = " + !(checkBoxP.Checked && checkBoxQ.Checked));
					break;
				case 5:
					MessageBox.Show("P NOr Q = " + !(checkBoxP.Checked || checkBoxQ.Checked));
					break;

			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void Changed(object sender, EventArgs e)
		{
			checkBoxP.Enabled = true;
			if (comboBox1.SelectedIndex == 0)
			{
				checkBoxQ.Enabled = false;
			}
			else checkBoxQ.Enabled = true;
		}
	}
}
