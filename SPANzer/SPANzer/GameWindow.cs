using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPANzer
{
	public partial class GameWindow : Form
	{
		public GameWindow()
		{
			InitializeComponent();
		}
		Walls Walls = new Walls();
		TankOne t1 = new TankOne();
		private void Form1_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.Salmon;
			Tank.CanvasHeight = pCanvas.Height;
			timer1.Enabled = true;
			//Get the Canvas' corners
			Walls.LT = new PointF(pCanvas.Left+5, pCanvas.Top+5);
			Walls.LB = new PointF(pCanvas.Left+5,pCanvas.Bottom);
			Walls.RB = new PointF(pCanvas.Right-5, pCanvas.Bottom);
			Walls.RT = new PointF(pCanvas.Right-5,pCanvas.Top+5);
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{
			t1.DrawTank(e.Graphics);
			Walls.DrawWalls(e.Graphics);
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			t1.MoveTank();
			pCanvas.Refresh();
			//label1.Text = (tankCo.X.ToString() + " " + tankCo.Y.ToString() + " " + angle.ToString());
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)		Tank.tLeft = true;
			if (e.KeyCode == Keys.Right)	Tank.tRight = true;
			if (e.KeyCode == Keys.Down)		Tank.tDown = true;
			if (e.KeyCode == Keys.Up)		Tank.tUp = true;
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)		Tank.tLeft = false;
			if (e.KeyCode == Keys.Right)	Tank.tRight = false;
			if (e.KeyCode == Keys.Down)		Tank.tDown = false;
			if (e.KeyCode == Keys.Up)		Tank.tUp = false;
		}
	}
}