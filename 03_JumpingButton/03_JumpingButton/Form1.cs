using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_JumpingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
			Random r= new Random();
			int a = r.Next();
			MessageBox.Show("Errorcode: "+a,"ERROR");
		}
		
		private void buttonYes_Click(object sender, EventArgs e)
		{
		    MessageBox.Show("Oh I don't think so", "Yes?");
		}

		private void buttonYes_MouseEnter(object sender, EventArgs e)
		{
		    Random generate = new Random();
		    buttonYes.Location = new Point(generate.Next(this.ClientSize.Width-buttonYes.Width), generate.Next(this.ClientSize.Height - buttonYes.Height));
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			/*
			if(keyData == Keys.Up)
			{
				return true;
			}
			if (keyData == Keys.Down)
			{
				return true;
			}
			if (keyData == Keys.Left)
			{
				return true;
			}
			if (keyData == Keys.Right)
			{
				return true;
			}if(keyData == Keys.Up)
			{
				return true;
			}
			if (keyData == (Keys.Up | Keys.Shift))
			{
				return true;
			}
			if (keyData == (Keys.Down | Keys.Shift))
			{
				return true;
			}
			if (keyData == (Keys.Left | Keys.Shift))
			{
				return true;
			}
			if (keyData == (Keys.Right | Keys.Shift))
			{
				return true;
			}
			if (keyData == Keys.Tab)
			{
				return true;
			}
			*/
			if (keyData == Keys.Enter)
			{
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
