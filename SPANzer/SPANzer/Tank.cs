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
			
			if(tUp == tDown)
			{
				Vx = 0;
				Vy = 0;
			}
			else if (tUp)
			{
				// Calculate velocity from angle and base speed
				Vx = (float)(moveSpeed * Math.Sin((angle * 0.0174532925))); //that ugly number is PI/180
				Vy = -(float)(moveSpeed * Math.Cos((angle * 0.0174532925)));
			}
			else if (tDown)
			{
				// Calculate velocity from angle and base speed
				Vx = -(float)(moveSpeed * Math.Sin((angle * 0.0174532925)));
				Vy = (float)(moveSpeed * Math.Cos((angle * 0.0174532925)));
			}

			//If it collides then one component of the velocity will be removed (Vx or Vy)
			CollisionDetector();

			
			tankCo.X += Vx;
			tankCo.Y += Vy;
			

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
			
			Console.WriteLine("vX = " + Vx.ToString() + "     vY = " + Vy.ToString());
			Console.WriteLine("X: " + tankCo.X.ToString() + " Y: " + tankCo.Y.ToString() + " Ang: " + angle.ToString());
			Console.WriteLine(img.Width.ToString() + "   " + img.Height.ToString());
			Console.WriteLine("tUp " + tUp.ToString() + " tDown " + tDown.ToString());
			Console.WriteLine("tLeft " + tLeft.ToString() + " tRight " + tRight.ToString());
			//Console.Write("\n");
			
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
				if(w.vertical == false) // horizontal
				{
					if (tankCo.X >= w.wallStart.X && tankCo.X <= w.wallEnd.X)
					{
						if (tankCo.Y > w.wallStart.Y && tankCo.Y + Vy < w.wallStart.Y)
						{
							if(Vy < 0)
							{
								Vy = 0;
								Console.WriteLine("UP");
							}
						}
						if (tankCo.Y + imgSize < w.wallStart.Y && tankCo.Y + imgSize + Vy > w.wallStart.Y)
						{
							if (Vy > 0)
							{
								Vy = 0;
								Console.WriteLine("DOWN");
							}
						}
					}
				}
				else if(w.vertical == true) //vertical
				{
					if (tankCo.Y >= w.wallStart.Y && tankCo.Y <= w.wallEnd.Y)
					{
						if (tankCo.X > w.wallStart.X && tankCo.X + Vx < w.wallStart.X)
						{
							if(Vx < 0)
							{
								Vx = 0;
								Console.WriteLine("LEFT");
							}
						}
						if (tankCo.X + imgSize < w.wallStart.X && tankCo.X  + imgSize + Vx > w.wallStart.X)
						{
							if (Vx > 0)
							{
								Vx = 0;
								Console.WriteLine("RIGHT");
							}
						}
					}
				}
			}
		}
	}
}
