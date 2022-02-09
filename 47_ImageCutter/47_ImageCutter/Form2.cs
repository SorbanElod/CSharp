using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_ImageCutter
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private Image imgPic;
		private Bitmap bitPic;
		Button [,]g = new Button[Form1.n,Form1.n];
		private int i1, i2, j1, j2;
		int clicks;
		private void Form2_Load(object sender, EventArgs e)
		{
			MessageBox.Show(Form1.n.ToString(), "now that's something");
			clicks = 1;
			imgPic = Image.FromFile("Koala.jpg");
			bitPic = new Bitmap(imgPic, panel1.Width, panel1.Height);
			for (int i = 0; i < Form1.n; i++)
			{
				for (int j = 0; j < Form1.n; j++)
				{
					g[i, j] = new Button();
					g[i, j].Tag = Form1.n * i + j + 1;
					g[i, j].FlatAppearance.BorderSize = 0;
					g[i, j].FlatStyle = FlatStyle.Popup;
					g[i, j].Width = panel1.Width / Form1.n;
					g[i, j].Height = panel1.Height / Form1.n;
					g[i, j].Left = j * panel1.Width / Form1.n;
					g[i, j].Top = i * panel1.Height / Form1.n;
					panel1.Controls.Add(g[i, j]);
					g[i, j].Click += new EventHandler(g_Click);
					g[i, j].BackgroundImage = splitImg(bitPic,
						j * g[i, j].Width,
						i * g[i, j].Height,
						g[i, j].Width,
						g[i, j].Height);
				}
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < Form1.n; i++)
			{
				for(int j = 0; j < Form1.n; j++)
				{
					g[i, j].Dispose();
				}
			}
		}

		private void g_Click(object sender, EventArgs e)
		{
			if (clicks == 1)
			{
				i1 = (sender as Button).Top / (sender as Button).Height;
				j1 = (sender as Button).Left / (sender as Button).Width;
				clicks = 2;
			}
			else
			{
				i2 = (sender as Button).Top / (sender as Button).Height;
				j2 = (sender as Button).Left / (sender as Button).Width;
				swap(i1, j1, i2, j2);
				clicks = 1;
				if(check() == true)
				{
					MessageBox.Show("Naez");
				}
			}
		}


		private Bitmap splitImg(Bitmap Original, int startX, int startY, int x, int y)
		{
			return Original.Clone(new Rectangle(startX, startY, x, y), Original.PixelFormat);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int num = Form1.n - 1;
			for (int i = 0; i < Form1.n; i++)
			{
				for (int j = 0; j < Form1.n; j++)
				{
					if (j < num)
					{
						if (int.Parse(g[i, j].Tag.ToString()) > int.Parse(g[i, j + 1].Tag.ToString()))
						{
							swap(i, j, i, j + 1);
						}
					}
					else if (j == num && i == num)
					{
					}
					else
					{
						if (int.Parse(g[i, j].Tag.ToString()) > int.Parse(g[i + 1, 0].Tag.ToString()))
						{
							swap(i, j, i + 1, 0);
						}
					}
				}
			}
			if(check() == true)
			{
				MessageBox.Show("You cheated!");
			}
		}

		private void swap(int i1, int j1, int i2, int j2)
		{
			Image backgroundImage = g[i1, j1].BackgroundImage;
			int sw;
			sw = int.Parse(g[i1,j1].Tag.ToString());
			g[i1, j1].BackgroundImage = g[i2, j2].BackgroundImage;
			g[i2, j2].BackgroundImage = backgroundImage;
			g[i1, j1].Tag = g[i2, j2].Tag;
			g[i2, j2].Tag = sw;
		}
		private void Shuffle(object sender, EventArgs e)
		{
			Random rng = new Random();
			for(int i = 0; i < 20; i++)
			{
				i1 = rng.Next(Form1.n);
				i2 = rng.Next(Form1.n);
				j1 = rng.Next(Form1.n);
				j2 = rng.Next(Form1.n);
				swap(i1, j1, i2, j2);
			}
		}

		private bool check()
		{///kirak ugyanez csak swap
			int num = Form1.n - 1;
			for(int i = 0; i < Form1.n; i++)
			{
				for(int j = 0;j< Form1.n; j++)
				{
					if (j < num)
					{
						if (int.Parse(g[i, j].Tag.ToString()) > int.Parse(g[i, j+1].Tag.ToString()))
						{
							return false;
						}
					}else if (j == num && i == num)
					{
					}
					else
					{
						if (int.Parse(g[i, j].Tag.ToString()) > int.Parse(g[i+1, 0].Tag.ToString()))
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}
}
