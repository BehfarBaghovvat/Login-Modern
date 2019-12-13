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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Program.Form2.Show();
			usenameTextBox.Focus();
			label2.Text = this.Left.ToString();
		}

		private void UsenameTextBox_Enter(object sender, EventArgs e)
		{
			usernamePictureBox.Image = Properties.Resources.icons8_user_100_Focus;
			usenameTextBox.ForeColor= System.Drawing.Color.FromArgb(70, 179, 210);
			if (string.Compare(usenameTextBox.Text,"Username")==0)
			{
				usenameTextBox.Clear(); 
			}
			panel1.BackColor = System.Drawing.Color.FromArgb(70, 179, 210);
		}

		private void UsenameTextBox_Leave(object sender, EventArgs e)
		{
			usernamePictureBox.Image = Properties.Resources.icons8_user_100;
			usenameTextBox.ForeColor = System.Drawing.Color.White;
			if (string.IsNullOrWhiteSpace(usenameTextBox.Text))
			{
				usenameTextBox.Text = "Username";
			}
			panel1.BackColor = System.Drawing.Color.White;
		}

		private void PasswordTextBox_Enter(object sender, EventArgs e)
		{
			passwordTextBox.Focus();
			passwordPictureBox.Image = Properties.Resources.icons8_password_100__Focus;
			passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(70, 179, 210);
			if (string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				passwordTextBox.Clear();
			}
			panel2.BackColor = System.Drawing.Color.FromArgb(70, 179, 210);
		}

		private void PasswordTextBox_Leave(object sender, EventArgs e)
		{
			passwordPictureBox.Image = Properties.Resources.icons8_password_100;
			passwordTextBox.ForeColor = System.Drawing.Color.White;
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.Text = "Password";
			}
			panel2.BackColor = System.Drawing.Color.White;
		}

		private void EmailTextBox_Enter(object sender, EventArgs e)
		{
			emailTextBox.Focus();
			emailPictureBox.Image = Properties.Resources.icons8_important_mail_100_Focus;
			emailTextBox.ForeColor = System.Drawing.Color.FromArgb(70, 179, 210);
			if (string.Compare(emailTextBox.Text,"Email")==0)
			{
				emailTextBox.Clear();
			}

			panel3.BackColor = System.Drawing.Color.FromArgb(70, 179, 210);
		}

		private void EmailTextBox_Leave(object sender, EventArgs e)
		{
			emailPictureBox.Image = Properties.Resources.icons8_important_mail_100;
			emailTextBox.ForeColor = System.Drawing.Color.White;
			if (string.IsNullOrWhiteSpace(emailTextBox.Text))
			{
				emailTextBox.Text = "Email";
			}
			panel3.BackColor = System.Drawing.Color.White;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void PictureBox4_Click(object sender, EventArgs e)
		{
			//label2.Text = "Left : " + form2.Left;
			timer1.Start();

		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			Program.Form2.Left += 7;
			if (Program.Form2.Left>=2473)
			{
				timer1.Stop();
				this.TopMost = false;
				Program.Form2.TopMost = true;
				timer2.Start();
				
			}
			
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			Program.Form2.Left -= 7;
			if (Program.Form2.Left<=2126)
			{
				//Program.Form1.Hide();
				timer2.Stop();
				
			}

		}
	}
}
