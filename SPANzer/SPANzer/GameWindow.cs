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
		public static Walls wall = new Walls();
		public static float tt1, tt2;
		Tank t1 = new Tank("GreenTankM4.png", 300, 300);
		Tank t2 = new Tank("GreenTankM4.png", 20, 20);
		private void Form1_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.Salmon;
			Tank.CanvasHeight = pCanvas.Height;
			timer1.Enabled = true;
			timer2.Enabled = true;
			//Get the Canvas' corners
			wall.LT = new PointF(pCanvas.Left + 5, pCanvas.Top + 5);
			wall.LB = new PointF(pCanvas.Left + 5, pCanvas.Bottom - 5);
			wall.RB = new PointF(pCanvas.Right - 5, pCanvas.Bottom - 5);
			wall.RT = new PointF(pCanvas.Right - 5, pCanvas.Top + 5);
			wall.Build();
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{
			//e.Graphics.DrawImage(t1.img, t1.tankCo.X, t1.tankCo.Y, imgSize, imgSize);
			t1.DrawTank(e.Graphics);
			t2.DrawTank(e.Graphics);
			//e.Graphics.DrawImage(t2.img, t2.tankCo.X, t2.tankCo.Y, imgSize, imgSize);
			wall.DrawWalls(e.Graphics);
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			t1.MoveTank();
			pCanvas.Refresh();
			label2.Text = "up: " + t1.up.ToString() + "  down: " + t1.down.ToString() + "  left: " + t1.left.ToString() + "  right: " + t1.right.ToString();
			label3.Text = "vX = " + tt1.ToString() + "     vY = " + tt2.ToString();
			label1.Text = (t1.tankCo.X.ToString() + " " + t1.tankCo.Y.ToString() + " " + t1.angle.ToString());
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			t2.MoveTank();
			pCanvas.Refresh();
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = true;
			if (e.KeyCode == Keys.Left) t1.tLeft = true;
			if (e.KeyCode == Keys.Down) t1.tDown = true;
			if (e.KeyCode == Keys.Right) t1.tRight = true;

			if (e.KeyCode == Keys.W) t2.tUp = true;
			if (e.KeyCode == Keys.A) t2.tLeft = true;
			if (e.KeyCode == Keys.S) t2.tDown = true;
			if (e.KeyCode == Keys.D) t2.tRight = true;
		}

		private void pCanvas_Click(object sender, EventArgs e)
		{
			t1.up = false;
			t1.down = false;
			t1.left = false;
			t1.right = false;
			label2.Text = "up: " + t1.up.ToString() + "  down: " + t1.down.ToString() + "  left: " + t1.left.ToString() + "  right: " + t1.right.ToString();
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = false;
			if (e.KeyCode == Keys.Left) t1.tLeft = false;
			if (e.KeyCode == Keys.Down) t1.tDown = false;
			if (e.KeyCode == Keys.Right) t1.tRight = false;

			if (e.KeyCode == Keys.W) t2.tUp = false;
			if (e.KeyCode == Keys.A) t2.tLeft = false;
			if (e.KeyCode == Keys.S) t2.tDown = false;
			if (e.KeyCode == Keys.D) t2.tRight = false;
		}
	}
}