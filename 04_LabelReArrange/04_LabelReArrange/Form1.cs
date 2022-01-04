using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_LabelReArrange
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void labelOne_MouseClick(object sender, MouseEventArgs e)
		{
			int x1 = e.X / (labelOne.Width / 3);
			int y1 = e.Y / (labelOne.Height / 3);
			int num = 3 * y1 + x1;
			switch (num)
			{
				case 0: labelOne.TextAlign = ContentAlignment.TopLeft;break;
				case 1: labelOne.TextAlign = ContentAlignment.TopCenter;break;
				case 2: labelOne.TextAlign = ContentAlignment.TopRight; break;
				case 3: labelOne.TextAlign = ContentAlignment.MiddleLeft; break;
				case 4: labelOne.TextAlign = ContentAlignment.MiddleCenter; break;
				case 5: labelOne.TextAlign = ContentAlignment.MiddleRight; break;
				case 6: labelOne.TextAlign = ContentAlignment.BottomLeft; break;
				case 7: labelOne.TextAlign = ContentAlignment.BottomCenter; break;
				case 8: labelOne.TextAlign = ContentAlignment.BottomRight; break;
			}
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			labelOne.Height = this.ClientSize.Height;
			labelOne.Width = this.ClientSize.Width;
		}
	}
}
