using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzerMapGenerator
{
	public class Brick
	{
		public PointF wallStart { get; set; }
		public PointF wallEnd { get; set; }
		private const float WALL_THICKNESS = 3;
		public bool vertical;      //true if vertical, false if horizontal
		private Color color;

		public Brick(PointF wallStart, PointF wallEnd)
		{
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
