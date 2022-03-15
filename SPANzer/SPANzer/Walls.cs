using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public class Walls
	{
		private const float WALL_THICKNESS = 3;
		public List<Brick> allWalls = new List<Brick>();
		public PointF LT, RT, RB, LB;
		
		public void Build()
		{
			/*
			allWalls.Add(new Brick(LT, RT));
			allWalls.Add(new Brick(RT, RB));
			allWalls.Add(new Brick(RB, LB));
			allWalls.Add(new Brick(LB, LT));
			
			Console.WriteLine("LT" + LT.ToString());
			Console.WriteLine("LB" + LB.ToString());
			Console.WriteLine("RT" + RT.ToString());
			Console.WriteLine("RB" + RB.ToString());
			*/
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
				allWalls.Add(new Brick(st, en));
			}
		}
		public void DrawWalls(Graphics g)
		{
			foreach (Brick w in allWalls)
			{
				w.Draw(g);
			}
		}
		public class Brick
		{
			public PointF wallStart { get; set; }
			public PointF wallEnd { get; set; }
			public Color Color { get => color; set => color = value; }
			public bool vertical;      //true if vertical, false if horizontal
			private Color color;
			
			public Brick(PointF wallStart, PointF wallEnd)
			{
				this.wallStart = wallStart;
				this.wallEnd = wallEnd;
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
