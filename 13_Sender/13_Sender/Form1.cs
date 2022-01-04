using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Sender
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ClickOnCtrl(object sender, EventArgs e)
		{
			//Control control = (Control)sender;
			labelText.Text = (sender as Control).Text;
			if (sender is Button) labelDescription.Text = "It's a Button!";
			if (sender is Label) labelDescription.Text = "It's a Label!";
			if (sender is TextBox) labelDescription.Text = "It's a TextBox!";
		}

		private void ClickOnLabel(object sender, EventArgs e)
		{
			(sender as Label).Text = "Don't";
		}
	}
}
