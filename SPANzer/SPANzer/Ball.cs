using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPANzer
{
	public class Ball
	{
		private const float ballRadius = 3f;
		private const float bulletSpeed = 3;
		public float vX, vY;
		public PointF center;
		private Color color;
		public DateTimeOffset created;
		public TimeSpan lifeTime = TimeSpan.FromSeconds(10);

		public Ball(PointF center, float dX, float dY)
		{
			this.vX = dX * bulletSpeed;
			this.vY = dY * bulletSpeed;
			this.color = Color.Black;
			this.center = center;
			this.created = DateTime.Now;
		}
		internal void Draw(Graphics g)
		{
			Pen p = new Pen(color);
			Brush b = new SolidBrush(color);
			g.DrawEllipse(p, center.X - ballRadius, center.Y - ballRadius, ballRadius + ballRadius, ballRadius + ballRadius);
			g.FillEllipse(b, center.X - ballRadius, center.Y - ballRadius, ballRadius + ballRadius, ballRadius + ballRadius);
		}
	}
}
