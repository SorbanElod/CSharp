using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49_Sheep__
{
	public partial class Form1 : Form
	{
		bool shUp, shDown, shLeft, shRight, wUp, wDown, wLeft, wRight;

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A)
			{
				wLeft = false;
			}
			if (e.KeyCode == Keys.D)
			{
				wRight = false;
			}
			if (e.KeyCode == Keys.S)
			{
				wDown = false;
			}
			if (e.KeyCode == Keys.W)
			{
				wUp = false;
			}
			if (e.KeyCode == Keys.Left)
			{
				shLeft = false;
			}
			if (e.KeyCode == Keys.Right)
			{
				shRight = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				shDown = false;
			}
			if (e.KeyCode == Keys.Up)
			{
				shUp = false;
			}
		}

		int move = 5;
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A)
			{
				wLeft = true;
			}
			if (e.KeyCode == Keys.D)
			{
				wRight = true;
			}
			if (e.KeyCode == Keys.S)
			{
				wDown = true;
			}
			if(e.KeyCode == Keys.W)
			{
				wUp = true;
			}
			if(e.KeyCode == Keys.Left)
			{
				shLeft = true;
			}
			if(e.KeyCode== Keys.Right)
			{
				shRight = true;
			}
			if(e.KeyCode == Keys.Down)
			{
				shDown = true;
			}
			if(e.KeyCode == Keys.Up)
			{
				shUp = true;
			}

		}

		public Form1()
		{
			InitializeComponent();

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			foreach (Control control in this.Controls)
			{
				control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
			}
			this.KeyPreview = true;//hogy a form kapja el először a key-eventet
		}

		void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			/*Some key presses, such as the TAB, RETURN, ESC, and arrow keys, are typically ignored by some controls
             * because they are not considered input key presses. For example, by default, a Button control ignores 
             * the arrow keys. Pressing the arrow keys typically causes the focus to move to the previous or next 
             * control. The arrow keys are considered navigation keys and pressing these keys typically do not raise
             * the KeyDown event for aButton. However, pressing the arrow keys for a Button does raise the PreviewKeyDown event. 
             * By handling the PreviewKeyDown event for a Button and setting the IsInputKey property to true, 
             * you can raise the KeyDown event when the arrow keys are pressed. 
             * However, if you handle the arrow keys, the focus will no longer move to the previous or next control.*/
			if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
			{
				e.IsInputKey = true;//Gets or sets a value indicating whether a key is a regular input key.
									//a fokust ne allitsa at
			}
		}
		/* !important
		bool ham(PictureBox p1,PictureBox p2)
		{
			double x01 = p1.Left + p1.Width / 2, y01 = p1.Top + p1.Height / 2, x02 = p2.Left + p2.Width / 2, y02 = p2.Top + p2.Height / 2;
			double d = Math.Sqrt((x01 - x02) * (x01 - x02) + (y01 - y02) * (y01 - y02));
			if(d<(p1.Width + p2.Width) / 2 - 20)
			{
				return true;
			}
			return false;
		}
		*/
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pictureBoxWolf.Bounds.IntersectsWith(pictureBoxSheep.Bounds)|| pictureBoxSheep.Bounds.IntersectsWith(pictureBoxWolf.Bounds))
			{
				//pictureBoxSheep.Image = Image.FromFile("bari5.png");
				pictureBoxSheep.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
				pictureBoxSheep.Refresh();
				timer1.Enabled = false;
			}
			if (shUp)
			{
				pictureBoxSheep.Top -= move;
			}
			if (shDown)
			{
				pictureBoxSheep.Top += move;
			}
			if (shLeft)
			{
				pictureBoxSheep.Left -= move;
			}
			if (shRight)
			{
				pictureBoxSheep.Left += move;
			}
			if (wUp)
			{
				pictureBoxWolf.Top -= move;
			}
			if (wDown)
			{
				pictureBoxWolf.Top += move;
			}
			if (wLeft)
			{
				pictureBoxWolf.Left -= move;
			}
			if (wRight)
			{
				pictureBoxWolf.Left += move;
			}
		}
	}
}
