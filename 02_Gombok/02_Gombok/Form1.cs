using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace _02_Gombok
{
    public partial class GombokFrame : Form
    {
        public GombokFrame()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Random generate = new Random();
            this.BackColor = Color.FromArgb(generate.Next(255), generate.Next(255), generate.Next(255));
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there!","General Kenobiii");
        }
    }
}
