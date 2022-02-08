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

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = "rtf";
			ofd.Filter = "RichText file (*.rtf)|*.rtf|Text files (*.txt)|*.txt*";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.LoadFile(ofd.FileName);
			}
		}

		private void formatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fd = new FontDialog();
			if(fd.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SelectionFont = fd.Font;
			}
		}

		private void conToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if(cd.ShowDialog () == DialogResult.OK)
			{
				richTextBox1.SelectionColor = cd.Color;
			}
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pastaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}
	}
}
