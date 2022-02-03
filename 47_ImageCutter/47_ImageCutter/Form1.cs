using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_ImageCutter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static int n = 100;
		private void buttonGame_Click(object sender, EventArgs e)
		{
			n = (int)(numericUpDown1.Value);
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			numericUpDown1.Minimum = 1;
			numericUpDown1.Maximum = n;
		}
	}
}
