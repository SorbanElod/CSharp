using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Coffee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int price = 0;
		private string currency = "Romanian Peso";
		private void Refresh(object sender, EventArgs e)
		{
			price = 0;
			foreach(Control a in groupBoxDrink.Controls)
			{
				if((a as RadioButton).Checked)
				{
					price += int.Parse((a as RadioButton).Tag.ToString());
				}
			}
			foreach (Control a in groupBoxOthers.Controls)
			{
				if ((a as CheckBox).Checked)
				{
					price += int.Parse((a as CheckBox).Tag.ToString());
				}
			}
			label1.Text = String.Format("{0,2}  {1}",price,currency);
		}

		private void DisableOthers(object sender, EventArgs e)
		{
			foreach(Control a in groupBoxOthers.Controls)
			{
				a.Enabled = false;
				(a as CheckBox).Checked = false;
			}
		}

		private void EnableSuitableOthers(object sender, EventArgs e)
		{
			foreach(Control a in groupBoxDrink.Controls)
			{
				//Coffee
				if(radioButtonC.Checked == true)
				{
					checkBox1.Enabled = true;
					checkBox3.Enabled = true;
					checkBox4.Enabled = true;
				}
				//Tea
				if (radioButtonT.Checked == true)
				{
					checkBox1.Enabled = true;
					checkBox2.Enabled = true;
					checkBox3.Enabled = true;
				}
				//HotChockolate
				if (radioButtonH.Checked == true)
				{
					checkBox1.Enabled = true;
					checkBox4.Enabled = true;
				}
			}
		}

		private void DrinkClicked(object sender, EventArgs e)
		{
			Refresh(sender, e);
			DisableOthers(sender, e);
			EnableSuitableOthers(sender, e);
		}

		private void OthersClicked(object sender, EventArgs e)
		{
			Refresh(sender, e);
		}
		//Uncheck everything
		private void Clear()
		{
			foreach(Control a in groupBoxOthers.Controls)
			{
				(a as CheckBox).Checked = false;
			}
			foreach(Control a in groupBoxDrink.Controls)
			{
				(a as RadioButton).Checked = false;
			}
			label1.Text = "";
		}

		private void buttonPay_Click(object sender, EventArgs e)
		{
			MessageBox.Show(label1.Text, "Payout");
			Clear();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DisableOthers(sender, e);
		}
	}
}
