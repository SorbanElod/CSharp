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
		Tank t1 = new Tank("PinkTank.png", 300, 300);
		Bullet b1 = new Bullet();
		//Tank t2 = new Tank("GreenTankM4.png", 20, 20);
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
			b1.DrawBullet(e.Graphics);
			//t2.DrawTank(e.Graphics);
			//e.Graphics.DrawImage(t2.img, t2.tankCo.X, t2.tankCo.Y, imgSize, imgSize);
			wall.DrawWalls(e.Graphics);
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			t1.MoveTank();
			b1.MoveBullets();
			b1.Expire();
			Console.WriteLine(b1.Bullets.Count.ToString());
			pCanvas.Refresh();
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			//t2.MoveTank();
			pCanvas.Refresh();
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = true;
			if (e.KeyCode == Keys.Left) t1.tLeft = true;
			if (e.KeyCode == Keys.Down) t1.tDown = true;
			if (e.KeyCode == Keys.Right) t1.tRight = true;
			if (e.KeyCode == Keys.Space) b1.Add(t1.cannon, t1.dX, t1.dY);
			/*
			if (e.KeyCode == Keys.W) t2.tUp = true;
			if (e.KeyCode == Keys.A) t2.tLeft = true;
			if (e.KeyCode == Keys.S) t2.tDown = true;
			if (e.KeyCode == Keys.D) t2.tRight = true;
		*/
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = false;
			if (e.KeyCode == Keys.Left) t1.tLeft = false;
			if (e.KeyCode == Keys.Down) t1.tDown = false;
			if (e.KeyCode == Keys.Right) t1.tRight = false;
			/*
			if (e.KeyCode == Keys.W) t2.tUp = false;
			if (e.KeyCode == Keys.A) t2.tLeft = false;
			if (e.KeyCode == Keys.S) t2.tDown = false;
			if (e.KeyCode == Keys.D) t2.tRight = false;
			*/
		}
	}
}