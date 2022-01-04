using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_TextFormat
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private Color colour()
		{
			return Color.FromArgb(checkBoxR.Checked ? 255 : 0, checkBoxG.Checked ? 255 : 0, checkBoxB.Checked ? 255 : 0);
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			labelPrint.Text = textBox1.Text;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0)
			{
				labelPrint.ForeColor = colour();
			}
			else
			{
				labelPrint.BackColor = colour();
			}
		}

		private string Betutipus()
		{
			if (radioButtonArial.Checked) return "Arial";
			if (radioButtonAurebesh.Checked) return "Aurebesh";
			if (radioButtonTimes.Checked) return "Times New Roman";
			if (radioButtonComic.Checked) return "Comic Sans Ms";
			else return "Book Antiqua";
		}

		private FontStyle BetuStilus()
		{
			FontStyle st = FontStyle.Regular;
			if(checkBoxBold.Checked == true) st |= FontStyle.Bold;
			if(checkBoxItalic.Checked == true) st |= FontStyle.Italic;
			if (checkBoxUnder.Checked == true) st |= FontStyle.Underline;
			return st;
		}

		private void SetFont()
		{
			labelPrint.Font = new Font(Betutipus(), (float)numericUpDown1.Value, BetuStilus());
		}

		private void StyleChange(object sender, EventArgs e)
		{
			SetFont();
		}

		private void FontChange(object sender, EventArgs e)
		{
			SetFont();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			SetFont();
		}
	}
}
