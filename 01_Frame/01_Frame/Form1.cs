﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Frame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonOn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
