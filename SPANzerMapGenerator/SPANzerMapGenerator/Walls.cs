using SPANzerMapGenerator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace SPANzerMapGenerator
{
	public class Walls
	{
		public List<Brick> allWalls = new List<Brick>();
		public PointF LT, RT, RB, LB;
		public void Build(string fileName)
		{
			allWalls.Add(new Brick(LT, RT));
			allWalls.Add(new Brick(RT, RB));
			allWalls.Add(new Brick(LB, LT));
			allWalls.Add(new Brick(RB, LB));
			bool spawned = false;
			PointF st = new PointF();
			PointF en = new PointF();
			string str;
			string path = Path.Combine(Environment.CurrentDirectory, @"Resources\Maps\", fileName);
			StreamReader f = new StreamReader(path);
			while (f.EndOfStream == false)
			{
				do
				{
					str = f.ReadLine();
				} while (str.Contains("#"));
				if (spawned == false)
				{
					string[] spNum = str.Split(' ');
					Main.t1Spawn.X = int.Parse(spNum[0]);
					Main.t1Spawn.Y = int.Parse(spNum[0]);
					do
					{
						str = f.ReadLine();
					} while (str.Contains("#"));
					spNum = str.Split(' ');
					Main.t2Spawn.X = int.Parse(spNum[0]);
					Main.t2Spawn.Y = int.Parse(spNum[0]);
					spawned = true;
				}
				else
				{
					string[] num = str.Split(' ');
					st.X = int.Parse(num[0]);
					st.Y = int.Parse(num[1]);
					en.X = int.Parse(num[2]);
					en.Y = int.Parse(num[3]);
					allWalls.Add(new Brick(st, en));
				}
			}
		}

		public void DrawWalls(Graphics g)
		{
			foreach (Brick w in allWalls)
			{
				w.Draw(g);
			}
		}
	}
}
