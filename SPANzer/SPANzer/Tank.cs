using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public abstract class Tank
	{
		public static bool tUp, tDown, tLeft, tRight;
		public static PointF tankCo = new Point(50, 50);
		public static Image OldImg, img;
		public static int moveSpeed = 3;
		public static float angle = 0f;
		public const float angV = 5f;
		public static int CanvasHeight;
		
		public void DrawTank(Graphics e)
		{
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
				if (tankCo.Y + moveSpeed + img.Height <= CanvasHeight)
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

		public int CollisionDetector()
		{
			return 0;
		}
	}
}
