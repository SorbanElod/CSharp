using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorbanElod
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int price;
		private void Disable()
		{
			foreach(CheckBox cb in groupBoxHozzavalok.Controls)
			{
				cb.Enabled = false;
				cb.Checked = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Disable();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonFizet_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Az on szamlaja "+price.ToString()+" lej");
			buttonTorol_Click(sender, e);
		}
		private void buttonTorol_Click(object sender, EventArgs e)
		{
			Disable();
			foreach (RadioButton rb in groupBoxEdesseg.Controls)
			{
				rb.Checked = false;
			}
			labelPrint.Text = "";
		}
		private void Refresh(object sender, EventArgs e)
		{
			price = 0;
			foreach(RadioButton rb in groupBoxEdesseg.Controls)
			{
				if(rb.Checked == true)
				{
					price += int.Parse(rb.Tag.ToString());
				}
			}
			foreach (CheckBox cb in groupBoxHozzavalok.Controls)
			{
				if(cb.Checked == true)
				{
					price += int.Parse(cb.Tag.ToString());
				}
			}
			labelPrint.Text = price.ToString() + " lej";
		}


		private void Changed(object sender, EventArgs e)
		{
			Disable();
			if(radioButtonFagyi.Checked == true)
			{
				checkBoxOntet.Enabled = true;
				checkBoxPiskota.Enabled = true;
				checkBoxTejszin.Enabled = true;
			}
			else if(radioButtonUdito.Checked == true)
			{
				checkBoxJeg.Enabled = true;
			}
			else if(radioButtonFrappe.Checked == true)
			{
				checkBoxJeg.Enabled = true;
				checkBoxTejszin.Enabled = true;
			}
			Refresh(sender,e);
		}
	}
}
