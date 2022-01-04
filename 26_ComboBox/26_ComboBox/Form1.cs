using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_ComboBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonFill_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 10; i++)
			{
				comboBox1.Items.Add(i.ToString()+". object");
			}
		}

		private void buttonDeleteAll_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			comboBox1.Text = "";
			label1.Text = "";
		}

		private void buttonDeleteAct_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Remove(comboBox1.SelectedItem);
			comboBox1.Text = "";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			label1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
		}
	}
}
