﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public class Tank
	{
		private const int cannonLength = 25;
		public bool tUp { get; set; }
		public bool tLeft { get; set; }
		public bool tDown { get; set; }
		public bool tRight { get; set; }
		public PointF tankCo = new PointF();
		public float angle = 0f;
		public bool hit;

		public static int CanvasHeight;
		private Image OldImg;
		private Image img;
		
		public float dX, dY;
		private float Vx, Vy;

		private const float moveSpeed = 3.5f;
		private const float angV = 5.5f;
		private const int imgSize = 50;
		int tmp = 0;
		public PointF center;
		public PointF cannon;

		public Tank(string str, int x, int y)
		{
			this.hit = false;
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

			//get direction
			dX = (float)(Math.Sin((angle * 0.0174532925)));
			dY = -(float)(Math.Cos((angle * 0.0174532925)));

			//If it collides then one component of the velocity will be removed (Vx or Vy)
			CollisionWithWalls();
			CollisionWithTank();

			tankCo.X += Vx;
			tankCo.Y += Vy;

			center.X = tankCo.X + imgSize / 2;
			center.Y = tankCo.Y + imgSize / 2 ;

			cannon.X = center.X + (float)((cannonLength * Math.Sin((angle * 0.0174532925))));
			cannon.Y = center.Y - (float)((cannonLength * Math.Cos((angle * 0.0174532925))));

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
			/*
			Console.WriteLine("vX = " + Vx.ToString() + "     vY = " + Vy.ToString());
			Console.WriteLine("X: " + tankCo.X.ToString() + " Y: " + tankCo.Y.ToString() + " Ang: " + angle.ToString());
			Console.WriteLine("tUp " + tUp.ToString() + " tDown " + tDown.ToString());
			Console.WriteLine("tLeft " + tLeft.ToString() + " tRight " + tRight.ToString());
			//Console.Write("\n");
			*/
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

		public void CollisionWithTank()
		{
			
			//if vertically are in line
			if(GameWindow.t1.tankCo.X + imgSize >= GameWindow.t2.tankCo.X && GameWindow.t1.tankCo.X <= GameWindow.t2.tankCo.X + imgSize)
			{
				//t1 from above, t2 from below
				if(GameWindow.t1.tankCo.Y + imgSize <= GameWindow.t2.tankCo.Y && GameWindow.t1.tankCo.Y + imgSize + GameWindow.t1.Vy >= GameWindow.t2.tankCo.Y - GameWindow.t2.Vy)
				{
					Console.WriteLine("YEOOPP" +  ++tmp );
					GameWindow.t1.Vy = 0;
				}
				if (GameWindow.t2.tankCo.Y + imgSize <= GameWindow.t1.tankCo.Y && GameWindow.t2.tankCo.Y + imgSize + GameWindow.t2.Vy >= GameWindow.t1.tankCo.Y - GameWindow.t1.Vy)
				{
					Console.WriteLine("YEOOPP" + ++tmp);
					GameWindow.t2.Vy = 0;
				}
			}
			
		}

		public void CollisionWithWalls()
		{
			foreach (Brick w in GameWindow.wall.allWalls)
			{
				if(w.vertical == false) // horizontal wall
				{
					//check if tank can collide with wall's side
					if (tankCo.X >= w.wallStart.X && tankCo.X <= w.wallEnd.X)
					{
						//collision with tehe wall above
						if (tankCo.Y > w.wallStart.Y && tankCo.Y + Vy < w.wallStart.Y)
						{
							Vy = 0;
						}
						//collision with the wall below
						if (tankCo.Y + imgSize < w.wallStart.Y && tankCo.Y + imgSize + Vy > w.wallStart.Y)
						{
							Vy = 0;
						}
					}
					//checks if tank can collide with the walls end
					if (tankCo.Y < w.wallStart.Y && tankCo.Y + imgSize > w.wallStart.Y)
					{
						//collision with the right end
						if (tankCo.X > w.wallEnd.X && tankCo.X + Vx < w.wallEnd.X)
						{
							Vx = 0;
						}
						//collision with the left end
						if (tankCo.X + imgSize < w.wallStart.X && tankCo.X + imgSize + Vx > w.wallStart.X)
						{
							Vx = 0;
						}
					}
				}
				else if(w.vertical == true) //vertical
				{
					//check if tank can collide with wall's side
					if (tankCo.Y >= w.wallStart.Y && tankCo.Y <= w.wallEnd.Y)
					{
						//collision with the wall from right
						if (tankCo.X > w.wallStart.X && tankCo.X + Vx < w.wallStart.X)
						{
							Vx = 0;
						}
						//collision with the wall from left
						if (tankCo.X + imgSize < w.wallStart.X && tankCo.X  + imgSize + Vx > w.wallStart.X)
						{
							Vx = 0;
						}
					}
					//checks if tank can collide with the walls end
					if (tankCo.X < w.wallStart.X && tankCo.X + imgSize > w.wallStart.X)
					{
						//collision with the bottom end
						if (tankCo.Y > w.wallEnd.Y && tankCo.Y + Vy < w.wallEnd.Y)
						{
							Vy = 0;
						}
						//collision with top end
						if (tankCo.Y + imgSize < w.wallStart.Y && tankCo.Y + imgSize + Vy > w.wallStart.Y)
						{
							Vy = 0;
						}
					}
				}
			}
		}
	}
}
