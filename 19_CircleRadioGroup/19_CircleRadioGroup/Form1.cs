using System;
using System.Windows.Forms;

namespace _19_CircleRadioGroup
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int itemIndex()
		{
			int ind = 0;
			foreach (Control a in groupBox1.Controls)
			{
				if((a as RadioButton).Checked)
				{
					ind = int.Parse ((a as RadioButton).Tag.ToString());
				}
			}
			return ind;
		}
		private void Refresh(object sender, EventArgs e)
		{
			double eredmeny = 0;
			string s = "";
			if (textBox1.Text.Length > 0)
			{
				switch (itemIndex())
				{
					case 0:
						eredmeny = 2 * Math.PI * double.Parse(textBox1.Text);
						s = "Kerulet:";
						break;
					case 1:
						eredmeny = Math.PI * double.Parse(textBox1.Text) * double.Parse(textBox1.Text);
						s = "Terulet:";
						break;
					case 2:
						eredmeny = 2 * double.Parse(textBox1.Text);
						s = "Atmero:";
						break;
				}

				if (checkBoxText.Checked == true)
				{
					textBox2.Text = string.Format("{0}\t{1:0.00}", s, eredmeny);
				}
				else textBox2.Text = string.Format("{0:0.00}", eredmeny);
			}
		}
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Refresh(sender, e);
			}
		}

		private void ChangeColor(object sender, EventArgs e)
		{
			if (checkBoxColor.Checked == true) textBox2.BackColor = System.Drawing.Color.Salmon;
		}
	}
}
