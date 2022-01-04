using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Pizza
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private string currency = "RON";
		private int price = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (CheckBox a in groupBox1.Controls) {
				a.Text = String.Format("{0} ({1} {2})",a.Text,a.Tag,currency);
			}
			Others(false);
		}

		private void OthersChanged(object sender, EventArgs e)
		{
			Refresh();
		}

		private void PizzaSizeChanged(object sender, EventArgs e)
		{
			Others(true);
			Refresh();
		}
		private void Others(bool input)
		{
			foreach (CheckBox a in groupBox1.Controls)
			{
				a.Enabled = input;
			}
		}
		private void Refresh()
		{
			price = 0;
			foreach (CheckBox a in groupBox1.Controls)
			{
				if (a.Checked)
				{
					price += int.Parse(a.Tag.ToString());
				}
			}
			foreach(RadioButton a in groupBox2.Controls)
			{
				if (a.Checked)
				{
					price += int.Parse(a.Tag.ToString());
				}
			}
			label1.Text = String.Format("{0} {1}", price.ToString(), currency);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			foreach(RadioButton a in groupBox2.Controls)
			{
				a.Checked = false;
			}
			Others(false);
			label1.Text = "";
		}

		private void buttonPay_Click(object sender, EventArgs e)
		{
			MessageBox.Show(label1.Text, "Payout");
			buttonDelete_Click(sender, e);
		}
	}
}
