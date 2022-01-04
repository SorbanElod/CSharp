using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_BusTicket
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private double price;
		private double finalPrice;
		private void buttonPrint_Click(object sender, EventArgs e)
		{
			bool[] boxok = new bool[5];
			boxok[0] = checkBoxDiscDiak.Checked;
			boxok[1] = checkBoxDiscNyugi.Checked;
			boxok[2] = checkBoxDiscTorzs.Checked;
			boxok[3] = checkBoxOthKuta.Checked;
			boxok[4] = checkBoxOthBic.Checked;
			if (boxok[0] == true && boxok[2])
			{
				finalPrice = price / 2 * 90 / 100;
			}
			else if (boxok[1] == true && boxok[2])
			{
				finalPrice = price / 3 * 90 / 100;
			}
			else if (boxok[0] == true)
			{
				finalPrice = price / 2;
			}
			else if (boxok[1] == true)
			{
				finalPrice = price / 3;
			}
			else if (boxok[2] == true)
			{
				finalPrice = price * 90 / 100;
			}
			else finalPrice = price;

			if (boxok[3] == true)
			{
				finalPrice = finalPrice + 6;
			}
			if (boxok[4] == true)
			{
				finalPrice = finalPrice + 5;
			}
			if (boxok[0] == true && boxok[1] == true)
			{
				labelPrint.Text = "Error";
			}
			else labelPrint.Text = finalPrice.ToString();
		}

		private void DestinationChanged(object sender, EventArgs e)
		{
			price = double.Parse((sender as RadioButton).Tag.ToString());
			buttonPrint_Click(sender,e);
		}

		private void DiscountChanged(object sender, EventArgs e)
		{
			buttonPrint_Click(sender, e);
		}

		private void OthersChanged(object sender, EventArgs e)
		{
			buttonPrint_Click(sender, e);
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			checkBoxDiscDiak.Checked = false;
			checkBoxDiscNyugi.Checked = false;
			checkBoxDiscTorzs.Checked = false;
			checkBoxOthKuta.Checked = false;
			checkBoxOthBic.Checked = false;
			labelPrint.Text = "";
		}
	}
}
