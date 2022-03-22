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

		public static Tank t1 = new Tank("PinkTank.png", 300, 300);
		public static Bullet b1 = new Bullet();

		public static Tank t2 = new Tank("GreenTank.png", 20, 20);
		public static Bullet b2 = new Bullet();

		bool t1Fire = false;
		bool t2Fire = false;

		int p1 = 0;
		int p2 = 0;

		private void GameWindow_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.LightGray;
			Tank.CanvasHeight = pCanvas.Height;

			GameTimer.Enabled = true;
			//timer2.Enabled = true;
			fireRate.Enabled = true;

			//label1.Text = 

			//Get the Canvas' corners
			wall.LT = new PointF(pCanvas.Left + 5, pCanvas.Top + 5);
			wall.LB = new PointF(pCanvas.Left + 5, pCanvas.Bottom - 5);
			wall.RB = new PointF(pCanvas.Right - 5, pCanvas.Bottom - 5);
			wall.RT = new PointF(pCanvas.Right - 5, pCanvas.Top + 5);
			wall.Build();
		}
		public void t1Hit()
		{
			//GameTimer.Enabled = false;
			//fireRate.Enabled = false;
			p2++;
			label1.Text = p1 + ": " + p2;
		}

		public void t2Hit()
		{
			//GameTimer.Enabled = false;
			//fireRate.Enabled = false;
			p1++;
			label1.Text = p1 + ": " + p2;
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{
			wall.DrawWalls(e.Graphics);
			t1.DrawTank(e.Graphics);
			t2.DrawTank(e.Graphics);
			b1.DrawBullet(e.Graphics);
			b2.DrawBullet(e.Graphics);
		}
		
		private void GameTimer_Tick(object sender, EventArgs e)
		{
			if (t1.hit)
			{
				t1.hit = false;
				t1Hit();
			}
			if (t2.hit)
			{
				t2.hit = false;
				t2Hit();
			}
			t1.MoveTank();
			t2.MoveTank();
			b1.MoveBullets();
			b2.MoveBullets();
			b1.Expire();
			b2.Expire();
			pCanvas.Refresh();
		}

		private void fireRate_Tick(object sender, EventArgs e)
		{
			if (t1Fire)
			{
				b1.Add(t1.cannon, t1.dX, t1.dY);
			}
			if (t2Fire)
			{
				b2.Add(t2.cannon, t2.dX, t2.dY);
			}
		}

		private void GameWindow_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = false;
			if (e.KeyCode == Keys.Left) t1.tLeft = false;
			if (e.KeyCode == Keys.Down) t1.tDown = false;
			if (e.KeyCode == Keys.Right) t1.tRight = false;
			if (e.KeyCode == Keys.Space) t1Fire = false;

			if (e.KeyCode == Keys.W) t2.tUp = false;
			if (e.KeyCode == Keys.A) t2.tLeft = false;
			if (e.KeyCode == Keys.S) t2.tDown = false;
			if (e.KeyCode == Keys.D) t2.tRight = false;
			if (e.KeyCode == Keys.Q) t2Fire = false;
		}

		private void GameWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = true;
			if (e.KeyCode == Keys.Left) t1.tLeft = true;
			if (e.KeyCode == Keys.Down) t1.tDown = true;
			if (e.KeyCode == Keys.Right) t1.tRight = true;
			if (e.KeyCode == Keys.Space) t1Fire = true;

			if (e.KeyCode == Keys.W) t2.tUp = true;
			if (e.KeyCode == Keys.A) t2.tLeft = true;
			if (e.KeyCode == Keys.S) t2.tDown = true;
			if (e.KeyCode == Keys.D) t2.tRight = true;
			if (e.KeyCode == Keys.Q) t2Fire = true;
		}
	}
}