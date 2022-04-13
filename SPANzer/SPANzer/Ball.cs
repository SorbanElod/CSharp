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
		public const float ballRadius = 2.5f;
		private const float bulletSpeed = 5;
		public float vX, vY;
		public PointF center;
		private Color color;
		public DateTimeOffset created;
		public TimeSpan lifeTime = TimeSpan.FromSeconds(10);
		public int opacity;

		public Ball(PointF center, float dX, float dY)
		{
			this.opacity = 0;
			this.vX = dX * bulletSpeed;
			this.vY = dY * bulletSpeed;
			this.color = Color.FromArgb(opacity,opacity,opacity);
			this.center = center;
			this.created = DateTime.Now;
		}

		internal void Draw(Graphics g)
		{
			Pen p = new Pen(color);
			color = Color.FromArgb(opacity, opacity, opacity);
			Brush b = new SolidBrush(color);
			g.DrawEllipse(p, center.X - ballRadius, center.Y - ballRadius, ballRadius + ballRadius, ballRadius + ballRadius);
			g.FillEllipse(b, center.X - ballRadius, center.Y - ballRadius, ballRadius + ballRadius, ballRadius + ballRadius);
		}
	}
}
