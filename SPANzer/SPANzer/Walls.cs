using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	class Walls
	{
		public const float WALL_THICKNESS = 2;
		private List<Wall> allWalls;
		

		public  void DrawWalls(Graphics g)
		{
			foreach (Wall w in allWalls)
				w.Draw(g);
		}
        private class Wall
        {
            public PointF wallStart;
            public PointF wallEnd;
            private Color color = Color.Black;
            
            public Wall(PointF wallStart, PointF wallEnd)
			{ 
                this.wallStart = wallStart;
                this.wallEnd = wallEnd;
            }
            internal void Draw(Graphics g)
            {
                Pen p = new Pen(color, WALL_THICKNESS);
                g.DrawLine(p, wallStart, wallEnd);
            }
        }
    }
}
