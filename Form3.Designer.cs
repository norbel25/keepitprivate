namespace restotestng
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.PendingButton = new FontAwesome.Sharp.IconButton();
            this.LogoutButton = new FontAwesome.Sharp.IconButton();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.ProductButton = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.xitButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardpanel.SuspendLayout();
            this.leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dashboardpanel.Controls.Add(this.homeButton);
            this.dashboardpanel.Controls.Add(this.PendingButton);
            this.dashboardpanel.Controls.Add(this.LogoutButton);
            this.dashboardpanel.Controls.Add(this.leftpanel);
            this.dashboardpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardpanel.Location = new System.Drawing.Point(0, 80);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(207, 975);
            this.dashboardpanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.homeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(3, 242);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(201, 67);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = " Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // PendingButton
            // 
            this.PendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.PendingButton.FlatAppearance.BorderSize = 0;
            this.PendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.PendingButton.IconChar = FontAwesome.Sharp.IconChar.PesoSign;
            this.PendingButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.PendingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PendingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PendingButton.Location = new System.Drawing.Point(3, 377);
            this.PendingButton.Name = "PendingButton";
            this.PendingButton.Size = new System.Drawing.Size(201, 67);
            this.PendingButton.TabIndex = 3;
            this.PendingButton.Text = "Pending";
            this.PendingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PendingButton.UseVisualStyleBackColor = false;
            this.PendingButton.Click += new System.EventHandler(this.PendingButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.LogoutButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.LogoutButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.LogoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(2, 860);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(204, 63);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.leftpanel.Controls.Add(this.btnHome);
            this.leftpanel.Controls.Add(this.ProductButton);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(207, 975);
            this.leftpanel.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1, 29);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(205, 187);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 4;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_2);
            // 
            // ProductButton
            // 
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ProductButton.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.ProductButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductButton.Location = new System.Drawing.Point(3, 517);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(201, 67);
            this.ProductButton.TabIndex = 3;
            this.ProductButton.Text = "Product";
            this.ProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Visible = false;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(207, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1717, 975);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1717, 975);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Jenkins;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 77;
            this.iconCurrentChildForm.InitialImage = null;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(12, 6);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(79, 77);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(97, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(197, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Archipelago Appetite";
            // 
            // xitButton
            // 
            this.xitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xitButton.FlatAppearance.BorderSize = 0;
            this.xitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.xitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.xitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xitButton.IconSize = 28;
            this.xitButton.Location = new System.Drawing.Point(1868, 12);
            this.xitButton.Name = "xitButton";
            this.xitButton.Size = new System.Drawing.Size(44, 32);
            this.xitButton.TabIndex = 3;
            this.xitButton.UseVisualStyleBackColor = true;
            this.xitButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 28;
            this.MaximizeButton.Location = new System.Drawing.Point(1818, 12);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(44, 32);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.MinimizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 28;
            this.MinimizeButton.Location = new System.Drawing.Point(1768, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(44, 32);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.MaximizeButton);
            this.panel2.Controls.Add(this.xitButton);
            this.panel2.Controls.Add(this.lblTitleChildForm);
            this.panel2.Controls.Add(this.iconCurrentChildForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 80);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(494, 816);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome sabi ni Jayrald";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.dashboardpanel);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.dashboardpanel.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dashboardpanel;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton PendingButton;
        private FontAwesome.Sharp.IconButton LogoutButton;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton xitButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ProductButton;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}