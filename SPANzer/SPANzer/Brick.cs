using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public class Brick
	{
		public PointF wallStart { get; set; }
		public PointF wallEnd { get; set; }
		public const float WALL_THICKNESS = 3;
		public bool vertical;      //true if vertical, false if horizontal
		private Color color;

		public Brick(PointF wallStart, PointF wallEnd)
		{	//swap start and end coordnates if necessary
			if (wallStart.X > wallEnd.X || wallStart.Y > wallEnd.Y)
			{
				this.wallStart = wallEnd;
				this.wallEnd = wallStart;
			}
			else
			{
				this.wallStart = wallStart;
				this.wallEnd = wallEnd;
			}
			//check if it's vertical
			if (wallStart.X == wallEnd.X)
			{
				this.vertical = true; //aka. vertical
			}
			else if (wallStart.Y == wallEnd.Y)
			{
				this.vertical = false; //aka. horizontal
			}
			else
			{
				throw new Exception("a wall is not vertical, nor horizontal");
			}
			this.color = Color.Black;
		}

		internal void Draw(Graphics g)
		{
			Pen p = new Pen(color, WALL_THICKNESS);
			g.DrawLine(p, wallStart, wallEnd);
		}
	}
}
