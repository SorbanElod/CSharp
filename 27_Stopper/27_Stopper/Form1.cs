using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Stopper
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private DateTime startTime, stopTime;
		bool started = false;
		private void buttonStart_Click(object sender, EventArgs e)
		{
			timer1.Interval = 10;
			started = true;
			timer1.Start();
			startTime = DateTime.Now;
			buttonStart.Enabled = false;
			buttonRestart.Text = "Stop";
			buttonRestart.Enabled = true;
			buttonMode.Text = "Laptime";
			buttonMode.Enabled = true;
		}

		private void buttonRestart_Click(object sender, EventArgs e)
		{
			if(started == true)
			{
				timer1.Stop();
				stopTime = DateTime.Now;
				buttonRestart.Text = "Continuee";
				buttonMode.Text = "Null";
				started = false;
			}
			else
			{
				timer1.Start(); 
				buttonRestart.Text = "Stop";
				buttonMode.Text = "Laptime";
				started = true;
				startTime = startTime.AddMilliseconds((DateTime.Now - stopTime).TotalMilliseconds);
			}
		}

		private void buttonMode_Click(object sender, EventArgs e)
		{
			if (started)
			{
				listBox1.Items.Add((DateTime.Now - startTime).ToString("t").Substring(0, 11));
				listBox1.SelectedIndex = listBox1.Items.Count - 1;
			}
			else
			{
				labelPrint.Text = "00:00:00";
				buttonStart.Enabled = true;
				buttonRestart.Enabled = false;
				buttonMode.Enabled = false;
				listBox1.Items.Clear();
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			DialogResult answer;
			answer = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (answer == DialogResult.Yes)
				this.Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			labelPrint.Text = (DateTime.Now - startTime).ToString("t").Substring(0, 11);
		}
	}
}
