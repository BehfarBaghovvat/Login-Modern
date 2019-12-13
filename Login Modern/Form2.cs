using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Modern
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			timer2.Start();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			Program.Form1.Left -= 7;
			if (Program.Form1.Left <= 2126)
			{
				//Program.Form2.Hide();
				timer1.Stop();
				
			}
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			
			Program.Form1.Left += 7;
			if (Program.Form1.Left >= 2473)
			{
				timer2.Stop();
				Program.Form1.TopMost = true;
				Program.Form2.TopMost = false;
				timer1.Start();
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Program.Form1.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
