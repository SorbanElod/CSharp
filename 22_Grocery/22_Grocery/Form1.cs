using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Grocery
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private string currency = "lej";
		private int price = 0;
		private void Form1_Load(object sender, EventArgs e)
		{
			foreach(Control control in groupBox1.Controls)
			{
				Disable();
				if(control is Label)
				{
					label1.Text = "Pityoka (" + label1.Tag.ToString() + " " + currency + ")";
					label2.Text = "Murok (" + label2.Tag.ToString() + " " + currency + ")";
					label3.Text = "Alma (" + label3.Tag.ToString() + " " + currency + ")";
					label4.Text = "Narancs (" + label4.Tag.ToString() + " " + currency + ")";
					label5.Text = "Tej (" + label5.Tag.ToString() + " " + currency + ")";
					label6.Text = "Sajt (" + label6.Tag.ToString() + " " + currency + ")";
				}
			}
		}

		private void NewInput(object sender, EventArgs e)
		{
			price = 0;
			foreach(Control control in groupBox1.Controls)
			{
				if(control is TextBox)
				{
					if (!int.TryParse(control.Text, out int db))
					{
							control.Focus();
							(control as TextBox).SelectAll();
							return;
					}
						else price += db*int.Parse((control as TextBox).Tag.ToString());
				}
			}
			if (ShopExists())
			{
				labelPrint.Text = String.Format("{0} {1}",price.ToString(),currency);
			}
			else labelPrint.Text = "";
		}

		private void Disable()
		{
			foreach(Control control in groupBox1.Controls)
			{
				control.Enabled = false;
				if ( control is TextBox)
				{
					control.Text = "0";
				}
			}
		}
		private void UncheckRadio()
		{
			foreach(RadioButton rb in groupBox2.Controls)
			{
				rb.Checked = false;
			}
		}
		private void ReEnable()
		{
			if(radioButton1.Checked == true)
			{
				label1.Enabled = true;
				label2.Enabled = true;
				textBox1.Enabled = true;
				textBox2.Enabled = true;
			}
			if (radioButton2.Checked == true)
			{
				label3.Enabled = true;
				label4.Enabled = true;
				textBox3.Enabled = true;
				textBox4.Enabled = true;
			}
			if (radioButton3.Checked == true)
			{
				label5.Enabled = true;
				label6.Enabled = true;
				textBox5.Enabled = true;
				textBox6.Enabled = true;
			}
		}

		private bool ShopExists()
		{
			foreach(RadioButton rb in groupBox2.Controls)
			{
				if(rb.Checked == true)return true;
			}
			return false;
		}

		private void ShopType(object sender, EventArgs e)
		{
			Disable();
			ReEnable();
			NewInput(sender, e);
		}

		private void buttonPay_Click(object sender, EventArgs e)
		{
			MessageBox.Show(labelPrint.Text, "Fizess!");
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{
			Disable();
			UncheckRadio();
			labelPrint.Text = "0";
		}
	}
}
