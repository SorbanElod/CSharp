using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankTrouble
{
	public partial class TestPage : Form
	{
		public TestPage()
		{
			InitializeComponent();
		}
		bool tUp,tDown,tLeft, tRight;
		int moveSpeed = 5;
		float turnSpeed = 5;

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (tUp)
			{
				pictureBox1.Top -= moveSpeed;
			}
			if (tDown)
			{
				pictureBox1.Top += moveSpeed;
			}
			if (tLeft)
			{
				Image img = RotateImage2((Bitmap)pictureBox1.Image, 360 - turnSpeed);
				//pictureBox1.Size = img.Size;
				pictureBox1.Image = img;
				
			}
			if (tRight)
			{
				Image img = RotateImage2((Bitmap)pictureBox1.Image, turnSpeed);
				//pictureBox1.Size = img.Size;
				pictureBox1.Image = img;
			}
		}

		private void TestPage_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				tLeft = false;
			}
			if (e.KeyCode == Keys.Right)
			{
				tRight = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				tDown = false;
			}
			if (e.KeyCode == Keys.Up)
			{
				tUp = false;
			}
		}

		private void TestPage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				tLeft = true;
			}
			if (e.KeyCode == Keys.Right)
			{
				tRight = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				tDown = true;
			}
			if (e.KeyCode == Keys.Up)
			{
				tUp = true;
			}
		}

		public static Bitmap RotateImage(Bitmap b, float angle)
		{
			//create a new empty bitmap to hold rotated image
			Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
			//make a graphics object from the empty bitmap
			using (Graphics g = Graphics.FromImage(returnBitmap))
			{
				//move rotation point to center of image
				g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
				//rotate
				g.RotateTransform(angle);
				//move image back
				g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
				//draw passed in image onto graphics object
				g.DrawImage(b, new Point(0, 0));
			}
			return returnBitmap;
		}
		private Bitmap RotateImage2(Bitmap bmp, float angle)
		{
			float height = bmp.Height;
			float width = bmp.Width;
			int hypotenuse = System.Convert.ToInt32(System.Math.Floor(Math.Sqrt(height * height + width * width)));
			Bitmap rotatedImage = new Bitmap(hypotenuse, hypotenuse);
			using (Graphics g = Graphics.FromImage(rotatedImage))
			{
				g.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2); //set the rotation point as the center into the matrix
				g.RotateTransform(angle); //rotate
				g.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2); //restore rotation point into the matrix
				g.DrawImage(bmp, (hypotenuse - width) / 2, (hypotenuse - height) / 2, width, height);
			}
			return rotatedImage;
		}
		private void TestPage_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
