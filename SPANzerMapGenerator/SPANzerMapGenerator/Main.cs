using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPANzerMapGenerator
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}
		public static Walls wall = new Walls();
		public static PointF t1Spawn;
		public static PointF t2Spawn;
		private void Main_Load(object sender, EventArgs e)
		{
			pControl.BackColor = Color.LightGray;
			//Get the Canvas' corners
			wall.LT = new PointF(pCanvas.Left + 5, pCanvas.Top + 5);
			wall.LB = new PointF(pCanvas.Left + 5, pCanvas.Bottom - 5);
			wall.RB = new PointF(pCanvas.Right - 5, pCanvas.Bottom - 5);
			wall.RT = new PointF(pCanvas.Right - 5, pCanvas.Top + 5);
		}
	}
}
