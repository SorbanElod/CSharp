using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_RaotatePicture
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		float angle = 0f;
		const float angV = 79f;
		Image OldImg;
		public static Bitmap RotateImage(Image image, float angle)
		{
			if (image == null)
				throw new ArgumentNullException("image");

			//create a new empty bitmap to hold rotated image
			Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
			rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			//make a graphics object from the empty bitmap
			Graphics g = Graphics.FromImage(rotatedBmp);




			//Put the rotation point in the center of the image
			g.TranslateTransform(image.Width / 2, image.Width / 2);

			//rotate the image
			g.RotateTransform(angle);

			//move the image back
			g.TranslateTransform(-image.Width / 2, -image.Width / 2);

			//draw passed in image onto graphics object
			g.DrawImage(image, new PointF(0, 0));

			return rotatedBmp;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = !timer1.Enabled;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			angle += angV;
			//angle = angle % 360f;
			pictureBox1.Image = RotateImage(OldImg, angle);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			OldImg = pictureBox1.Image;
		}
	}
}
