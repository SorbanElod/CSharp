using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46_MultipleForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonAsk_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			if (f2.ShowDialog() == DialogResult.OK)
			{
				int num1 = f2.quantity;
				labelPrint.Text = f2.quantity.ToString();
			}
		}

		private void buttonNonModal_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
		}
	}
}
