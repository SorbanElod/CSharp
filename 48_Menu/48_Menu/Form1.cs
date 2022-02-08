using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_Menu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Help hlp = new Help();
			hlp.ShowDialog();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt = "rtf";
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SaveFile(sfd.FileName);
			}
		}
	}
}
