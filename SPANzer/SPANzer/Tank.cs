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
		public Image OldImg;
		public Image img;

		public const int moveSpeed = 3;
		public float angle = 0f;
		public const float angV = 5f;
		public static int CanvasHeight;

		public Tank(string str, int x, int y)
		{
			
			this.tUp = false;
			this.tLeft = false;
			this.tDown = false;
			this.tRight = false;
			this.angle = 0f;
			this.tankCo = new PointF(x,y);
			this.OldImg = Image.FromFile(str);
			this.img = this.OldImg;
		}

		/*public void DrawTank(Graphics e)
		{
			e.DrawImage(img, tankCo.X, tankCo.Y, 32, 32);
			e.DrawImage(img, tankCo.X + 100, tankCo.Y + 100, 32, 32);
		}*/

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
		public PointF getTankCo()
		{
			return tankCo;
		}

		public Image getImg()
		{
			return img;
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
