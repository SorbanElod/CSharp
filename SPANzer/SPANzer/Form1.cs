using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPANzer
{
	public partial class Form1 : Form
	{
		Image img;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			img = Image.FromFile("PanzerGut.png");
			pControl.BackColor = Color.Salmon;
			Graphics tank = pCanvas.CreateGraphics();
			tank.DrawImage(img, 10,10);
		
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{
			Graphics tank = pCanvas.CreateGraphics();
			tank.DrawImage(img, 10, 10);
		}
	}
}