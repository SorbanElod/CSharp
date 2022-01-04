using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_CursorPosition
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			labelCursorPosition.Top = e.Y;
			labelCursorPosition.Left = e.X;
			Random generate = new Random();
			labelCursorPosition.BackColor = Color.FromArgb(generate.Next(255), generate.Next(255), generate.Next(255));
			//labelCursorPosition.Text = "X: "+e.X.ToString()+" Y: "+e.Y.ToString();
			labelCursorPosition.Text = String.Format("X: {0,3} Y: {1,3}", e.X, e.Y);

		}

		private void labelCursorPosition_MouseMove(object sender, MouseEventArgs e)
		{
			labelCursorPosition.Top += e.Y;
			labelCursorPosition.Left += e.X;
			Random generate = new Random();
			labelCursorPosition.BackColor = Color.FromArgb(generate.Next(255), generate.Next(255), generate.Next(255));
			//labelCursorPosition.Text = "X: " + (labelCursorPosition.Left+e.X).ToString() + " Y: " + (labelCursorPosition.Top+e.Y).ToString();
			labelCursorPosition.Text = String.Format("X: {0,4} Y: {1,4}", e.X+labelCursorPosition.Left, e.Y+ labelCursorPosition.Top);
		}
	}
}
