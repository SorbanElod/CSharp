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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Walls Walls = new Walls();
		bool tUp, tDown, tLeft, tRight;
		int moveSpeed = 3;
		float angle = 0f;
		const float angV = 5f;
		Image OldImg, img;
		PointF tankCo = new Point(50,50);
		private void Form1_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.Salmon;
			OldImg = Image.FromFile("PanzerGut.png");
			img = OldImg;
			timer1.Enabled = true;
		}

		private void pCanvas_Paint(object sender, PaintEventArgs e)
		{

			e.Graphics.DrawImage(img, tankCo.X,tankCo.Y,32,32);
			Walls.DrawWalls(e.Graphics);
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			MoveTank();
			pCanvas.Refresh();
			label1.Text = (tankCo.X.ToString() + " " + tankCo.Y.ToString() + " " + angle.ToString());
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left) tLeft = true;
			if (e.KeyCode == Keys.Right) tRight = true;
			if (e.KeyCode == Keys.Down) tDown = true;
			if (e.KeyCode == Keys.Up) tUp = true;
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			label2.Text = MousePosition.X.ToString() + MousePosition.Y.ToString();
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)		tLeft = false;
			if (e.KeyCode == Keys.Right)	tRight = false;
			if (e.KeyCode == Keys.Down)		tDown = false;
			if (e.KeyCode == Keys.Up)		tUp = false;
		}

		public static Bitmap RotateImage(Image image, float angle)
		{
			Bitmap rotatedBmp = new Bitmap(image.Width, image.Height); //new bmp
			rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution); //set resolution
			Graphics g = Graphics.FromImage(rotatedBmp); //new graphics for the rotated bmp
			g.TranslateTransform(image.Width / 2, image.Width / 2); //center the image
			g.RotateTransform(angle); //rotate
			g.TranslateTransform(-image.Width / 2, -image.Width / 2); //recenter the image
			g.DrawImage(image, new PointF(0, 0)); //draw image to bmp
			return rotatedBmp;
		}

		public void MoveTank()
		{
			///vX vY kerekites
			if (tUp)
			{
				if (tankCo.Y - moveSpeed >= 0)
				{
					tankCo.Y -= (float)(moveSpeed * Math.Cos((angle * 0.0174532925)));
					tankCo.X += (float)(moveSpeed * Math.Sin((angle * 0.0174532925)));
				}
			}
			if (tDown)
			{
				if (tankCo.Y + moveSpeed + img.Height <= pCanvas.Height)
				{

					tankCo.Y += (float)(moveSpeed * Math.Cos((angle * 0.0174532925)));
					tankCo.X -= (float)(moveSpeed * Math.Sin((angle * 0.0174532925)));
				}
			}
			if (tLeft)
			{
				angle -= angV;
				if (angle < 0)
				{
					angle = 360 + angle;
				}
				angle = angle % 360;
				img = RotateImage(OldImg, angle);
			}
			if (tRight)
			{
				angle += angV;
				angle = angle % 360;
				if (angle < 0)
				{
					angle = 360 + angle;
				}
				img = RotateImage(OldImg, angle);
			}
		}

		public int CollisionDetector()
		{
			return 0;
		}
	}
}