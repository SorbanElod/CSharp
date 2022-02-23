using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	class Walls
	{
	    private const float wALL_THICKNESS = 3;
	    private List<Brick> allWalls = new List<Brick>();

		public static float WALL_THICKNESS => wALL_THICKNESS;

		private List<Brick> AllWalls { get => allWalls; set => allWalls = value; }

		public void Build()
		{
            //AllWalls.Add(new Brick());        
            PointF st = new PointF();
            PointF en = new PointF();
            string str;
            StreamReader f = new StreamReader("walls.txt");
            while (f.EndOfStream == false)
			{
				do
                {
                    str = f.ReadLine();
                    str = str.Trim();
                } while (str.Contains("#"));
                string[] num = str.Split(' ');
                st.X = int.Parse(num[0]);
                st.Y = int.Parse(num[1]);
                en.X = int.Parse(num[2]);
                en.Y = int.Parse(num[3]);
                AllWalls.Add(new Brick(st, en));
            }
        }

		public  void DrawWalls(Graphics g)
		{
            Build();
            foreach (Brick w in AllWalls)
				w.Draw(g);
		}
        private class Brick
        {
            public PointF wallStart { get; set; }
            public PointF wallEnd { get; set; }
			public Color Color { get => color; set => color = value; }

			private Color color;
            
            public Brick(PointF wallStart, PointF wallEnd)
			{ 
                this.wallStart = wallStart;
                this.wallEnd = wallEnd;
                this.Color = Color.Black;
            }
            public Brick(float stX,float stY,float enX,float enY)
            {
                this.wallStart = new PointF(stX, stY);
                this.wallEnd = new PointF(enX, enY);
                this.Color = Color.Black;
            }
            internal void Draw(Graphics g)
            {
                Pen p = new Pen(Color, WALL_THICKNESS);
                g.DrawLine(p, wallStart, wallEnd);
            }
        }
    }
}
