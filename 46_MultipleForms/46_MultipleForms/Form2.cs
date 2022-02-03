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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		//public int quantity;
		public int quantity {get;set;}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			quantity = 0;
			int r;
			if (int.TryParse(textBox1.Text, out r))
			{
				quantity = r;
			}

		}
	}
}