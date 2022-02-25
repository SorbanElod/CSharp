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
		public PointF LT, RT, RB, LB;
		public bool dr = false;
		public void Build()
		{
			allWalls.Add(new Brick(LT, RT));
			allWalls.Add(new Brick(RT, RB));
			allWalls.Add(new Brick(RB, LB));
			allWalls.Add(new Brick(LB, LT));
			PointF st = new PointF();
			PointF en = new PointF();
			string str;
			//Bitmap bmp;
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
				allWalls.Add(new Brick(st, en));
			}
		}
		public void DrawWalls(Graphics g)
		{
			if (dr == false)
			{
				Build();
				dr = true;
			}
			foreach (Brick w in allWalls)
			{
				w.Draw(g);
			}
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
			public Brick(float stX, float stY, float enX, float enY)
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
