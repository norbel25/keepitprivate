namespace restotestng
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleradiobutton = new CustomControls.CustomRadioButton();
            this.maleradiobutton = new CustomControls.CustomRadioButton();
            this.firstname = new JTextBox.JText_Box();
            this.lastname = new JTextBox.JText_Box();
            this.phonenumber = new JTextBox.JText_Box();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new JTextBox.JText_Box();
            this.username = new JTextBox.JText_Box();
            this.firstnamewarning = new FontAwesome.Sharp.IconPictureBox();
            this.passwordwarning = new FontAwesome.Sharp.IconPictureBox();
            this.lastnamewarning = new FontAwesome.Sharp.IconPictureBox();
            this.phonenumberwarning = new FontAwesome.Sharp.IconPictureBox();
            this.usernamewarning = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new restotestng.CustomButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnamewarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordwarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnamewarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonenumberwarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamewarning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(405, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(405, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(689, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(690, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label5.Location = new System.Drawing.Point(677, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.groupBox1.Controls.Add(this.femaleradiobutton);
            this.groupBox1.Controls.Add(this.maleradiobutton);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.groupBox1.Location = new System.Drawing.Point(379, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.femaleradiobutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradiobutton.Location = new System.Drawing.Point(15, 80);
            this.femaleradiobutton.MinimumSize = new System.Drawing.Size(0, 21);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.femaleradiobutton.Size = new System.Drawing.Size(92, 21);
            this.femaleradiobutton.TabIndex = 10;
            this.femaleradiobutton.TabStop = true;
            this.femaleradiobutton.Text = "Female";
            this.femaleradiobutton.UnCheckedColor = System.Drawing.Color.Gray;
            this.femaleradiobutton.UseVisualStyleBackColor = true;
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Checked = true;
            this.maleradiobutton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.maleradiobutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradiobutton.Location = new System.Drawing.Point(15, 38);
            this.maleradiobutton.MinimumSize = new System.Drawing.Size(0, 21);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.maleradiobutton.Size = new System.Drawing.Size(73, 21);
            this.maleradiobutton.TabIndex = 10;
            this.maleradiobutton.TabStop = true;
            this.maleradiobutton.Text = "Male";
            this.maleradiobutton.UnCheckedColor = System.Drawing.Color.Gray;
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.firstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.firstname.BorderThickness = 2;
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.White;
            this.firstname.Location = new System.Drawing.Point(613, 106);
            this.firstname.Margin = new System.Windows.Forms.Padding(5);
            this.firstname.MaxLength = 32767;
            this.firstname.Name = "firstname";
            this.firstname.onFocusBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.firstname.PasswordChar = '\0';
            this.firstname.RoundedBorder = 10;
            this.firstname.Size = new System.Drawing.Size(264, 46);
            this.firstname.TabIndex = 3;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstname.TextColor = System.Drawing.Color.White;
            this.firstname.TextInput = "";
            this.firstname.Enter += new System.EventHandler(this.firstname_Enter);
            this.firstname.Leave += new System.EventHandler(this.firstname_Leave);
            this.firstname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.firstname_MouseDown);
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.lastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.lastname.BorderThickness = 2;
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.White;
            this.lastname.Location = new System.Drawing.Point(613, 194);
            this.lastname.Margin = new System.Windows.Forms.Padding(5);
            this.lastname.MaxLength = 32767;
            this.lastname.Name = "lastname";
            this.lastname.onFocusBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.lastname.PasswordChar = '\0';
            this.lastname.RoundedBorder = 10;
            this.lastname.Size = new System.Drawing.Size(264, 46);
            this.lastname.TabIndex = 4;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastname.TextColor = System.Drawing.Color.White;
            this.lastname.TextInput = "";
            this.lastname.Enter += new System.EventHandler(this.lastname_Enter);
            this.lastname.Leave += new System.EventHandler(this.lastname_Leave);
            this.lastname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lastname_MouseDown);
            // 
            // phonenumber
            // 
            this.phonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.phonenumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.phonenumber.BorderThickness = 2;
            this.phonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonenumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.ForeColor = System.Drawing.Color.White;
            this.phonenumber.Location = new System.Drawing.Point(613, 275);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(5);
            this.phonenumber.MaxLength = 32767;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.onFocusBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.phonenumber.PasswordChar = '\0';
            this.phonenumber.RoundedBorder = 10;
            this.phonenumber.Size = new System.Drawing.Size(264, 46);
            this.phonenumber.TabIndex = 5;
            this.phonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phonenumber.TextColor = System.Drawing.Color.White;
            this.phonenumber.TextInput = "";
            this.phonenumber.Enter += new System.EventHandler(this.phonenumber_Enter);
            this.phonenumber.Leave += new System.EventHandler(this.phonenumber_Leave);
            this.phonenumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phonenumber_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(333, 194);
            this.password.Margin = new System.Windows.Forms.Padding(5);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.onFocusBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.password.PasswordChar = '\0';
            this.password.RoundedBorder = 10;
            this.password.Size = new System.Drawing.Size(235, 46);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.TextColor = System.Drawing.Color.White;
            this.password.TextInput = "";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            this.password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.password_MouseDown);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.username.BorderThickness = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.FontStyles = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(333, 106);
            this.username.Margin = new System.Windows.Forms.Padding(5);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.onFocusBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.username.PasswordChar = '\0';
            this.username.RoundedBorder = 10;
            this.username.Size = new System.Drawing.Size(235, 46);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.TextColor = System.Drawing.Color.White;
            this.username.TextInput = "";
            this.username.Load += new System.EventHandler(this.username_Load);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            this.username.MouseDown += new System.Windows.Forms.MouseEventHandler(this.username_MouseDown_1);
            // 
            // firstnamewarning
            // 
            this.firstnamewarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.firstnamewarning.ForeColor = System.Drawing.Color.Red;
            this.firstnamewarning.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.firstnamewarning.IconColor = System.Drawing.Color.Red;
            this.firstnamewarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.firstnamewarning.IconSize = 37;
            this.firstnamewarning.Location = new System.Drawing.Point(830, 114);
            this.firstnamewarning.Name = "firstnamewarning";
            this.firstnamewarning.Size = new System.Drawing.Size(37, 37);
            this.firstnamewarning.TabIndex = 10;
            this.firstnamewarning.TabStop = false;
            this.firstnamewarning.Visible = false;
            // 
            // passwordwarning
            // 
            this.passwordwarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.passwordwarning.ForeColor = System.Drawing.Color.Red;
            this.passwordwarning.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.passwordwarning.IconColor = System.Drawing.Color.Red;
            this.passwordwarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordwarning.IconSize = 37;
            this.passwordwarning.Location = new System.Drawing.Point(521, 203);
            this.passwordwarning.Name = "passwordwarning";
            this.passwordwarning.Size = new System.Drawing.Size(37, 37);
            this.passwordwarning.TabIndex = 10;
            this.passwordwarning.TabStop = false;
            this.passwordwarning.Visible = false;
            // 
            // lastnamewarning
            // 
            this.lastnamewarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.lastnamewarning.ForeColor = System.Drawing.Color.Red;
            this.lastnamewarning.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.lastnamewarning.IconColor = System.Drawing.Color.Red;
            this.lastnamewarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lastnamewarning.IconSize = 37;
            this.lastnamewarning.Location = new System.Drawing.Point(830, 203);
            this.lastnamewarning.Name = "lastnamewarning";
            this.lastnamewarning.Size = new System.Drawing.Size(37, 37);
            this.lastnamewarning.TabIndex = 10;
            this.lastnamewarning.TabStop = false;
            this.lastnamewarning.Visible = false;
            // 
            // phonenumberwarning
            // 
            this.phonenumberwarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.phonenumberwarning.ForeColor = System.Drawing.Color.Red;
            this.phonenumberwarning.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.phonenumberwarning.IconColor = System.Drawing.Color.Red;
            this.phonenumberwarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.phonenumberwarning.IconSize = 37;
            this.phonenumberwarning.Location = new System.Drawing.Point(830, 282);
            this.phonenumberwarning.Name = "phonenumberwarning";
            this.phonenumberwarning.Size = new System.Drawing.Size(37, 38);
            this.phonenumberwarning.TabIndex = 10;
            this.phonenumberwarning.TabStop = false;
            this.phonenumberwarning.Visible = false;
            // 
            // usernamewarning
            // 
            this.usernamewarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.usernamewarning.ForeColor = System.Drawing.Color.Red;
            this.usernamewarning.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.usernamewarning.IconColor = System.Drawing.Color.Red;
            this.usernamewarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usernamewarning.IconSize = 37;
            this.usernamewarning.Location = new System.Drawing.Point(521, 113);
            this.usernamewarning.Name = "usernamewarning";
            this.usernamewarning.Size = new System.Drawing.Size(37, 38);
            this.usernamewarning.TabIndex = 10;
            this.usernamewarning.TabStop = false;
            this.usernamewarning.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.button1.BorderRadius = 20;
            this.button1.BorderSize = 2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(661, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sign Up";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 509);
            this.Controls.Add(this.passwordwarning);
            this.Controls.Add(this.phonenumberwarning);
            this.Controls.Add(this.lastnamewarning);
            this.Controls.Add(this.usernamewarning);
            this.Controls.Add(this.firstnamewarning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnamewarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordwarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnamewarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonenumberwarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamewarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private JTextBox.JText_Box firstname;
        private JTextBox.JText_Box lastname;
        private JTextBox.JText_Box phonenumber;
        private CustomButton button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JTextBox.JText_Box password;
        private JTextBox.JText_Box username;
        private CustomControls.CustomRadioButton femaleradiobutton;
        private CustomControls.CustomRadioButton maleradiobutton;
        private FontAwesome.Sharp.IconPictureBox firstnamewarning;
        private FontAwesome.Sharp.IconPictureBox passwordwarning;
        private FontAwesome.Sharp.IconPictureBox lastnamewarning;
        private FontAwesome.Sharp.IconPictureBox phonenumberwarning;
        private FontAwesome.Sharp.IconPictureBox usernamewarning;
    }
}