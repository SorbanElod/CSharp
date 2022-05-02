using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SPANzer
{
	public partial class GameWindow : Form
	{
		public GameWindow()
		{
			InitializeComponent();
		}

		private DateTime tNow;
		public static Walls wall = new Walls();
		public static Point t1Spawn;
		public static Point t2Spawn;

		public static Tank t1;
		public static Bullet b1 = new Bullet();

		public static Tank t2;
		public static Bullet b2 = new Bullet();

		bool t1Fire = false;
		bool t2Fire = false;

		int p1 = 0;
		int p2 = 0;
		
		string path = Path.Combine(Environment.CurrentDirectory, @"Resources\Maps\");

		public void Spawn()
		{
			Random RNG = new Random();
			int mapNum = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
			int i = RNG.Next(1,mapNum + 1);
			//i = 26;
			string map = "walls" + i.ToString() + ".txt";
			//map = "walls26.txt";
			wall.RemoveWalls();
			Console.WriteLine(i);
			wall.Build(map);
			t1 = new Tank("PinkTank.png", t1Spawn.X, t1Spawn.Y);
			t2 = new Tank("GreenTank.png", t2Spawn.X, t2Spawn.Y);

			GTimer1.Enabled = true;
			GTimer2.Enabled = true;
			fireRate.Enabled = true;
			Refresh.Enabled = true;
		}

		private void GameWindow_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.LightGray;
			Tank.CanvasHeight = pCanvas.Height;
			label1.Text = p2 + " : " + p1;
			//Get the Canvas' corners
			wall.LT = new PointF(pCanvas.Left + 5, pCanvas.Top + 5);
			wall.LB = new PointF(pCanvas.Left + 5, pCanvas.Bottom - 5);
			wall.RB = new PointF(pCanvas.Right - 5, pCanvas.Bottom - 5);
			wall.RT = new PointF(pCanvas.Right - 5, pCanvas.Top + 5);
			Spawn();
		}
		public void t1Hit()
		{
			p2++;
			t1.Kill();
			endGame();
		}

		public void t2Hit()
		{
			p1++;
			t2.Kill();
			endGame();
		} 
		
		private void endGame()
		{
			GTimer1.Enabled = false;
			GTimer2.Enabled = false;
			fireRate.Enabled = false;
			Refresh.Enabled = false;

			tNow = DateTime.Now;
			b1.RemoveBullets();
			b2.RemoveBullets();
			label1.Text = p2 + " : " + p1;
			pCanvas.Refresh();
			Intermezzo.Start();
		}
		
		private void Intermezzo_Tick(object sender, EventArgs e)
		{
			if(DateTime.Now - tNow >= TimeSpan.FromSeconds(1))
			{
				Spawn();
				Intermezzo.Stop();
			}
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{
			wall.DrawWalls(e.Graphics);
			t1.DrawTank(e.Graphics);
			t2.DrawTank(e.Graphics);
			b1.DrawBullet(e.Graphics);
			b2.DrawBullet(e.Graphics);
		}
		
		private void GTimer1_Tick(object sender, EventArgs e)
		{
			if (t1.hit)
			{
				t1.hit = false;
				t1Hit();
			}
			t1.MoveTank();
			b1.MoveBullets();
			b1.Expire();
		}

		private void GTimer2_Tick(object sender, EventArgs e)
		{
			if (t2.hit)
			{
				t2.hit = false;
				t2Hit();
			}
			t2.MoveTank();
			b2.MoveBullets();
			b2.Expire();
		}

		private void Refresh_Tick(object sender, EventArgs e)
		{
			pCanvas.Refresh();
			Console.WriteLine(t1.angle.ToString());
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
			if (e.KeyCode == Keys.M) t1Fire = false;

			if (e.KeyCode == Keys.E) t2.tUp = false;
			if (e.KeyCode == Keys.S) t2.tLeft = false;
			if (e.KeyCode == Keys.D) t2.tDown = false;
			if (e.KeyCode == Keys.F) t2.tRight = false;
			if (e.KeyCode == Keys.Q) t2Fire = false;
		}

		private void GameWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up) t1.tUp = true;
			if (e.KeyCode == Keys.Left) t1.tLeft = true;
			if (e.KeyCode == Keys.Down) t1.tDown = true;
			if (e.KeyCode == Keys.Right) t1.tRight = true;
			if (e.KeyCode == Keys.M) t1Fire = true;

			if (e.KeyCode == Keys.E) t2.tUp = true;
			if (e.KeyCode == Keys.S) t2.tLeft = true;
			if (e.KeyCode == Keys.D) t2.tDown = true;
			if (e.KeyCode == Keys.F) t2.tRight = true;
			if (e.KeyCode == Keys.Q) t2Fire = true;
		}
	}
}