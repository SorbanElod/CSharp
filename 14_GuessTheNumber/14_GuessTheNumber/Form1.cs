using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_GuessTheNumber
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int szam;
		private Random r = new Random(); 
		private void Form1_Load(object sender, EventArgs e)
		{
			szam = r.Next(1,101);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a;
			if(int.TryParse(textBox1.Text,out a))
			{
				if (a > szam) label1.Text = "Én kissebbre gondoltam";
				else if (a < szam) label1.Text = "Én nagyobbra gondoltam";
				else
				{
					label1.Text = "Eltalaltad :) \n Gondoltam egy uj szamra";
					szam = r.Next(1, 101);
				}
			}
			textBox1.Focus();
			textBox1.SelectAll();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				button1_Click(sender, e);
			}
		}
	}
}
