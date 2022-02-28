using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	class TankOne : Tank
	{
		public TankOne()
		{
			OldImg = Image.FromFile("PanzerGut.png");
			img = OldImg;
		}
		public void DrawTank(Graphics e)
		{
			e.DrawImage(img, tankCo.X, tankCo.Y, 32, 32);
		}
	}
}
