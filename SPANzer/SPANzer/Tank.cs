using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public class Tank
	{
		public bool tUp { get; set; }
		public bool tLeft { get; set; }
		public bool tDown { get; set; }
		public bool tRight { get; set; }
		public PointF tankCo;
		public float angle = 0f;
		public static int CanvasHeight;
		public bool up, down, left, right;
		private Image OldImg;
		private Image img;
		private float Vx, Vy;
		private const float moveSpeed = 3.5f;
		private const float angV = 5.5f;
		private const int imgSize = 50;

		public Tank(string str, int x, int y)
		{
			this.up = false;
			this.down = false;
			this.left = false;
			this.right = false;
			this.Vx = 0;
			this.Vy = 0;
			this.tUp = false;
			this.tLeft = false;
			this.tDown = false;
			this.tRight = false;
			this.angle = 0f;
			this.tankCo = new PointF(x,y);
			this.OldImg = Image.FromFile(str);
			this.img = this.OldImg;
		}

		public void DrawTank(Graphics e)
		{
			//e.DrawImage(this.img, this.tankCo.X, this.tankCo.Y, imgSize, imgSize);
			e.DrawImage(img, tankCo.X, tankCo.Y, imgSize, imgSize);
			//e.DrawImage(img, tankCo.X + 100, tankCo.Y + 100, 32, 32);
		}

		public void MoveTank()
		{

			// Calculate velocity from angle and base speed
			Vx = (float)(moveSpeed * Math.Sin((angle * 0.0174532925)));
			Vy = (float)(moveSpeed * Math.Cos((angle * 0.0174532925)));

			//Vertical and horizontal velocity
			CollisionDetector();

			GameWindow.tt1 = Vx;
			GameWindow.tt2 = Vy;

			if (up == true)
			{
				Vy = 0;
			}
			if (down == true)
			{
				Vy = 0;
			}
			if (left == true)
			{
				Vx = 0;
			}
			if (right == true)
			{
				Vx = 0;
			}
			up = false;
			down = false;
			left = false;
			right = false;

			if (tUp)
			{
				tankCo.Y -= Vy;
				tankCo.X += Vx;
			}
			if (tDown)
			{
				tankCo.Y += Vy;
				tankCo.X -= Vx;
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

		public void CollisionDetector()
		{
			foreach (Walls.Brick w in GameWindow.wall.allWalls)
			{
				if(w.vertical == true)
				{
					if (this.tankCo.X > w.wallStart.X && this.tankCo.X + this.Vx < w.wallStart.X)
					{
						this.left = true;
					}
					else if (this.tankCo.X < w.wallStart.X && this.tankCo.X + this.Vx > w.wallStart.X)
					{
						this.right = true;
					}
					
				}
				else if(w.vertical == false)
				{
					if (this.tankCo.Y > w.wallStart.Y && this.tankCo.Y + this.Vy < w.wallStart.Y) 
					{
						this.up = true;
					}
					else if (this.tankCo.Y < w.wallStart.Y && this.tankCo.Y + this.Vy > w.wallStart.Y)
					{
						this.down = true;
					}
				}
			}
		}
	}
}
