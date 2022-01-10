using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void NumberIn(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void PlusMinus(object sender, EventArgs e)
		{
			if(textBox1.Text.Length > 0)
			{
				if (textBox1.Text.Contains("-") == false)
				{
					textBox1.Text = "-" + textBox1.Text;
				}
				else
				{
					textBox1.Text = textBox1.Text.Substring(1);
				}
			}
		}

		private void InsertDot(object sender, EventArgs e)
		{
			if(textBox1.Text.Length > 0)
			{
				if (textBox1.Text.Contains(".") == false)
				{
					textBox1.Text += ".";
				}
			}
			else
			{
				textBox1.Text = "0.";
			}
		}
	}
}
/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _30Szamologep
{
    public partial class Form1 : Form
    {
        double x;
        char op;
        Color c;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + (sender as Button).Text;
        }

       
        private void bpz_Click(object sender, EventArgs e)
        {
            if (!tb1.Text.Contains('.'))
            {
                tb1.Text = tb1.Text + ".";
            }
        }

        private void bpm_Click(object sender, EventArgs e)
        {
            if (tb1.Text[0] == '-')
                tb1.Text = tb1.Text.Substring(1);
            else 
                tb1.Text = "-" + tb1.Text;
        }

        private void bp_Click(object sender, EventArgs e)
        {
            x = 0;
            if (tb1.Text != "")
            {
                x = double.Parse(tb1.Text);
                op = '+';
                tb1.Text = "";
            }       
        }

        private void bm_Click(object sender, EventArgs e)
        {
            x = 0;
            if (tb1.Text != "")
            {
                x = double.Parse(tb1.Text);
                op = '-';
                tb1.Text = "";
            }
        }

        private void bo_Click(object sender, EventArgs e)
        {
            x = 0;
            if (tb1.Text != "")
            {
                x = double.Parse(tb1.Text);
                op = '*';
                tb1.Text = "";
            }
        }

        private void bi_Click(object sender, EventArgs e)
        {
            x = 0;
            if (tb1.Text != "")
            {
                x = double.Parse(tb1.Text);
                op = '/';
                tb1.Text = "";
            }
        }

        private void be_Click(object sender, EventArgs e)
        {
            double r=0;
            if(tb1.Text!="")
            {
                r=double.Parse(tb1.Text);
                if (op == '+') r = x + r;
                if (op == '-') r = x - r;
                if (op == '*') r = x * r;
                if (op == '/' && r!=0) r = x / r;
            }
            tb1.Text = r.ToString();
        }

        private void bc_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }

        private void bbs_Click(object sender, EventArgs e)
        {
            if (tb1.Text!="") tb1.Text = tb1.Text.Substring(0, tb1.Text.Length - 1);
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If you set Handled to true on a TextBox, that control will not pass the key press events
            // Stop the character from being entered into the control since it is non-numerical.
            if (e.KeyChar == '.' && tb1.Text.Contains('.')) e.Handled = true;
           if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar!='.')
                e.Handled = true;
        }

        private void bc_MouseHover(object sender, EventArgs e)
        {
            c = bc.BackColor;
            bc.BackColor = Color.Red;
        }

        private void bc_MouseLeave(object sender, EventArgs e)
        {
            bc.BackColor = c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
szamologep.cs
szamologep.cs megjelenítése.
 * */