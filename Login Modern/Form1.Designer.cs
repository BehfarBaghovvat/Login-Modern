namespace Login_Modern
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.usenameTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.emailPictureBox = new System.Windows.Forms.PictureBox();
			this.passwordPictureBox = new System.Windows.Forms.PictureBox();
			this.usernamePictureBox = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// usenameTextBox
			// 
			this.usenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.usenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usenameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usenameTextBox.ForeColor = System.Drawing.Color.White;
			this.usenameTextBox.Location = new System.Drawing.Point(106, 169);
			this.usenameTextBox.Name = "usenameTextBox";
			this.usenameTextBox.Size = new System.Drawing.Size(198, 22);
			this.usenameTextBox.TabIndex = 2;
			this.usenameTextBox.Text = "Username";
			this.usenameTextBox.Enter += new System.EventHandler(this.UsenameTextBox_Enter);
			this.usenameTextBox.Leave += new System.EventHandler(this.UsenameTextBox_Leave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(66, 197);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 2);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(66, 256);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(269, 2);
			this.panel2.TabIndex = 6;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.White;
			this.passwordTextBox.Location = new System.Drawing.Point(106, 228);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(198, 22);
			this.passwordTextBox.TabIndex = 5;
			this.passwordTextBox.Text = "Password";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(66, 315);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(269, 2);
			this.panel3.TabIndex = 9;
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.ForeColor = System.Drawing.Color.White;
			this.emailTextBox.Location = new System.Drawing.Point(106, 287);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(198, 22);
			this.emailTextBox.TabIndex = 8;
			this.emailTextBox.Text = "Email";
			this.emailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
			this.emailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(210)))));
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.Location = new System.Drawing.Point(66, 340);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(269, 40);
			this.loginButton.TabIndex = 10;
			this.loginButton.Text = "Sing In";
			this.loginButton.UseVisualStyleBackColor = false;
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerButton.ForeColor = System.Drawing.Color.White;
			this.registerButton.Location = new System.Drawing.Point(66, 392);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(269, 40);
			this.registerButton.TabIndex = 11;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(373, -1);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(15, 25);
			this.button3.TabIndex = 15;
			this.button3.Text = "X";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(164, 465);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 16;
			this.label1.Text = "login with";
			// 
			// minimizeButton
			// 
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeButton.Location = new System.Drawing.Point(350, 0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 24);
			this.minimizeButton.TabIndex = 17;
			this.minimizeButton.Text = "_";
			this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Login_Modern.Properties.Resources.Twitter_unselect;
			this.pictureBox6.Location = new System.Drawing.Point(261, 510);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(75, 75);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 14;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Login_Modern.Properties.Resources.Google_Plus_Unselect;
			this.pictureBox5.Location = new System.Drawing.Point(165, 510);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(75, 75);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Login_Modern.Properties.Resources.FaceBook_Unselect;
			this.pictureBox4.Location = new System.Drawing.Point(65, 510);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(75, 75);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
			// 
			// emailPictureBox
			// 
			this.emailPictureBox.Image = global::Login_Modern.Properties.Resources.icons8_important_mail_100;
			this.emailPictureBox.Location = new System.Drawing.Point(66, 279);
			this.emailPictureBox.Name = "emailPictureBox";
			this.emailPictureBox.Size = new System.Drawing.Size(30, 30);
			this.emailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.emailPictureBox.TabIndex = 7;
			this.emailPictureBox.TabStop = false;
			// 
			// passwordPictureBox
			// 
			this.passwordPictureBox.Image = global::Login_Modern.Properties.Resources.icons8_password_100;
			this.passwordPictureBox.Location = new System.Drawing.Point(66, 220);
			this.passwordPictureBox.Name = "passwordPictureBox";
			this.passwordPictureBox.Size = new System.Drawing.Size(30, 30);
			this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordPictureBox.TabIndex = 4;
			this.passwordPictureBox.TabStop = false;
			// 
			// usernamePictureBox
			// 
			this.usernamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usernamePictureBox.Image")));
			this.usernamePictureBox.Location = new System.Drawing.Point(66, 161);
			this.usernamePictureBox.Name = "usernamePictureBox";
			this.usernamePictureBox.Size = new System.Drawing.Size(30, 30);
			this.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.usernamePictureBox.TabIndex = 1;
			this.usernamePictureBox.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Login_Modern.Properties.Resources.icons8_sent_100;
			this.pictureBox1.Location = new System.Drawing.Point(150, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 10;
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 18);
			this.label2.TabIndex = 18;
			this.label2.Text = "Left : ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(400, 600);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.minimizeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.emailPictureBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordPictureBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.usenameTextBox);
			this.Controls.Add(this.usernamePictureBox);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox usernamePictureBox;
		private System.Windows.Forms.TextBox usenameTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.PictureBox passwordPictureBox;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.PictureBox emailPictureBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label2;
	}
}

