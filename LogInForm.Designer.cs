namespace restotestng
{
    partial class LogInForm
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new JTextBox.JText_Box();
            this.password = new JTextBox.JText_Box();
            this.hide = new FontAwesome.Sharp.IconButton();
            this.show = new FontAwesome.Sharp.IconButton();
            this.button2 = new restotestng.CustomButton();
            this.button1 = new restotestng.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(255, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(256, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // username
            // 
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.username.BorderThickness = 1;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(144, 187);
            this.username.Margin = new System.Windows.Forms.Padding(5);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.username.PasswordChar = '\0';
            this.username.RoundedBorder = 15;
            this.username.Size = new System.Drawing.Size(310, 48);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.TextColor = System.Drawing.Color.White;
            this.username.TextInput = "";
            this.username.Load += new System.EventHandler(this.username_Load);
            this.username.Leave += new System.EventHandler(this.username_Leave_1);
            // 
            // password
            // 
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.password.BorderThickness = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(144, 272);
            this.password.Margin = new System.Windows.Forms.Padding(5);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.password.PasswordChar = '•';
            this.password.RoundedBorder = 15;
            this.password.Size = new System.Drawing.Size(310, 48);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.TextColor = System.Drawing.Color.White;
            this.password.TextInput = "";
            this.password.Load += new System.EventHandler(this.password_Load);
            this.password.Leave += new System.EventHandler(this.password_Leave_1);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.hide.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.hide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hide.IconSize = 30;
            this.hide.Location = new System.Drawing.Point(405, 284);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(39, 28);
            this.hide.TabIndex = 5;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.show.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.show.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.show.IconSize = 30;
            this.show.Location = new System.Drawing.Point(405, 284);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(39, 28);
            this.show.TabIndex = 5;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button2.BorderColor = System.Drawing.Color.Black;
            this.button2.BorderRadius = 15;
            this.button2.BorderSize = 1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(320, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sign Up";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.BorderRadius = 15;
            this.button1.BorderSize = 1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(119, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log In";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hide);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.show);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 556);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomButton button1;
        private CustomButton button2;
        private JTextBox.JText_Box username;
        private JTextBox.JText_Box password;
        private FontAwesome.Sharp.IconButton hide;
        private FontAwesome.Sharp.IconButton show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

