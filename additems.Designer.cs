namespace restotestng
{
    partial class additems
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
            this.customPanel1 = new restotestng.CustomPanel();
            this.qtytb = new JTextBox.JText_Box();
            this.total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saucecb = new System.Windows.Forms.CheckBox();
            this.ricecb = new System.Windows.Forms.CheckBox();
            this.jayraldcb = new System.Windows.Forms.CheckBox();
            this.neilcb = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmbutton = new restotestng.CustomButton();
            this.largerb = new CustomControls.CustomRadioButton();
            this.mediumrb = new CustomControls.CustomRadioButton();
            this.smallrb = new CustomControls.CustomRadioButton();
            this.decrementbutton = new FontAwesome.Sharp.IconButton();
            this.incrementbutton = new FontAwesome.Sharp.IconButton();
            this.customButton3 = new restotestng.CustomButton();
            this.customButton2 = new restotestng.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitbutton = new FontAwesome.Sharp.IconButton();
            this.customButton1 = new restotestng.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.qtytb);
            this.customPanel1.Controls.Add(this.total);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.saucecb);
            this.customPanel1.Controls.Add(this.ricecb);
            this.customPanel1.Controls.Add(this.jayraldcb);
            this.customPanel1.Controls.Add(this.neilcb);
            this.customPanel1.Controls.Add(this.panel2);
            this.customPanel1.Controls.Add(this.largerb);
            this.customPanel1.Controls.Add(this.mediumrb);
            this.customPanel1.Controls.Add(this.smallrb);
            this.customPanel1.Controls.Add(this.decrementbutton);
            this.customPanel1.Controls.Add(this.incrementbutton);
            this.customPanel1.Controls.Add(this.customButton3);
            this.customPanel1.Controls.Add(this.customButton2);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(32, 29);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(777, 376);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // qtytb
            // 
            this.qtytb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.qtytb.BorderColor = System.Drawing.Color.DarkBlue;
            this.qtytb.BorderThickness = 1;
            this.qtytb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytb.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytb.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qtytb.Location = new System.Drawing.Point(70, 115);
            this.qtytb.Margin = new System.Windows.Forms.Padding(5);
            this.qtytb.MaxLength = 32767;
            this.qtytb.Name = "qtytb";
            this.qtytb.onFocusBorderColor = System.Drawing.Color.Magenta;
            this.qtytb.PasswordChar = '\0';
            this.qtytb.RoundedBorder = 5;
            this.qtytb.Size = new System.Drawing.Size(200, 40);
            this.qtytb.TabIndex = 8;
            this.qtytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qtytb.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qtytb.TextInput = "";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Orange;
            this.total.Location = new System.Drawing.Point(629, 224);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(54, 21);
            this.total.TabIndex = 7;
            this.total.Text = "Total";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // saucecb
            // 
            this.saucecb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saucecb.AutoSize = true;
            this.saucecb.Location = new System.Drawing.Point(626, 120);
            this.saucecb.Name = "saucecb";
            this.saucecb.Size = new System.Drawing.Size(97, 20);
            this.saucecb.TabIndex = 6;
            this.saucecb.Text = "With Sauce";
            this.saucecb.UseVisualStyleBackColor = true;
            this.saucecb.CheckedChanged += new System.EventHandler(this.saucecb_CheckedChanged);
            // 
            // ricecb
            // 
            this.ricecb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ricecb.AutoSize = true;
            this.ricecb.Location = new System.Drawing.Point(480, 120);
            this.ricecb.Name = "ricecb";
            this.ricecb.Size = new System.Drawing.Size(86, 20);
            this.ricecb.TabIndex = 6;
            this.ricecb.Text = "With Rice";
            this.ricecb.UseVisualStyleBackColor = true;
            this.ricecb.CheckedChanged += new System.EventHandler(this.ricecb_CheckedChanged);
            // 
            // jayraldcb
            // 
            this.jayraldcb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jayraldcb.AutoSize = true;
            this.jayraldcb.Location = new System.Drawing.Point(626, 165);
            this.jayraldcb.Name = "jayraldcb";
            this.jayraldcb.Size = new System.Drawing.Size(112, 20);
            this.jayraldcb.TabIndex = 6;
            this.jayraldcb.Text = "Jayrald\'s Kiss";
            this.jayraldcb.UseVisualStyleBackColor = true;
            // 
            // neilcb
            // 
            this.neilcb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neilcb.AutoSize = true;
            this.neilcb.Location = new System.Drawing.Point(480, 165);
            this.neilcb.Name = "neilcb";
            this.neilcb.Size = new System.Drawing.Size(91, 20);
            this.neilcb.TabIndex = 6;
            this.neilcb.Text = "Neil\'s Kiss";
            this.neilcb.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.confirmbutton);
            this.panel2.Location = new System.Drawing.Point(35, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 101);
            this.panel2.TabIndex = 5;
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.White;
            this.confirmbutton.BackgroundColor = System.Drawing.Color.White;
            this.confirmbutton.BorderColor = System.Drawing.Color.DarkBlue;
            this.confirmbutton.BorderRadius = 5;
            this.confirmbutton.BorderSize = 1;
            this.confirmbutton.FlatAppearance.BorderSize = 0;
            this.confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.confirmbutton.Location = new System.Drawing.Point(214, 25);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(253, 49);
            this.confirmbutton.TabIndex = 0;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.TextColor = System.Drawing.Color.DarkBlue;
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // largerb
            // 
            this.largerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.largerb.AutoSize = true;
            this.largerb.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.largerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largerb.Location = new System.Drawing.Point(513, 220);
            this.largerb.MinimumSize = new System.Drawing.Size(0, 21);
            this.largerb.Name = "largerb";
            this.largerb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.largerb.Size = new System.Drawing.Size(76, 22);
            this.largerb.TabIndex = 4;
            this.largerb.Text = "Large";
            this.largerb.UnCheckedColor = System.Drawing.Color.Gray;
            this.largerb.UseVisualStyleBackColor = true;
            this.largerb.CheckedChanged += new System.EventHandler(this.largerb_CheckedChanged);
            // 
            // mediumrb
            // 
            this.mediumrb.AutoSize = true;
            this.mediumrb.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.mediumrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumrb.Location = new System.Drawing.Point(275, 220);
            this.mediumrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.mediumrb.Name = "mediumrb";
            this.mediumrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mediumrb.Size = new System.Drawing.Size(92, 22);
            this.mediumrb.TabIndex = 4;
            this.mediumrb.Text = "Medium";
            this.mediumrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.mediumrb.UseVisualStyleBackColor = true;
            this.mediumrb.CheckedChanged += new System.EventHandler(this.mediumrb_CheckedChanged);
            // 
            // smallrb
            // 
            this.smallrb.AutoSize = true;
            this.smallrb.Checked = true;
            this.smallrb.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.smallrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallrb.Location = new System.Drawing.Point(53, 220);
            this.smallrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.smallrb.Name = "smallrb";
            this.smallrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.smallrb.Size = new System.Drawing.Size(76, 22);
            this.smallrb.TabIndex = 4;
            this.smallrb.TabStop = true;
            this.smallrb.Text = "Small";
            this.smallrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.smallrb.UseVisualStyleBackColor = true;
            this.smallrb.CheckedChanged += new System.EventHandler(this.smallrb_CheckedChanged);
            // 
            // decrementbutton
            // 
            this.decrementbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.decrementbutton.FlatAppearance.BorderSize = 0;
            this.decrementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrementbutton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.decrementbutton.IconColor = System.Drawing.Color.MediumBlue;
            this.decrementbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.decrementbutton.IconSize = 40;
            this.decrementbutton.Location = new System.Drawing.Point(345, 121);
            this.decrementbutton.Name = "decrementbutton";
            this.decrementbutton.Size = new System.Drawing.Size(39, 40);
            this.decrementbutton.TabIndex = 2;
            this.decrementbutton.UseVisualStyleBackColor = true;
            this.decrementbutton.Click += new System.EventHandler(this.decrementbutton_Click);
            // 
            // incrementbutton
            // 
            this.incrementbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incrementbutton.FlatAppearance.BorderSize = 0;
            this.incrementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementbutton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.incrementbutton.IconColor = System.Drawing.Color.MediumBlue;
            this.incrementbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.incrementbutton.IconSize = 40;
            this.incrementbutton.Location = new System.Drawing.Point(287, 121);
            this.incrementbutton.Name = "incrementbutton";
            this.incrementbutton.Size = new System.Drawing.Size(41, 40);
            this.incrementbutton.TabIndex = 2;
            this.incrementbutton.UseVisualStyleBackColor = true;
            this.incrementbutton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customButton3.BackColor = System.Drawing.Color.White;
            this.customButton3.BackgroundColor = System.Drawing.Color.White;
            this.customButton3.BorderColor = System.Drawing.Color.DarkBlue;
            this.customButton3.BorderRadius = 5;
            this.customButton3.BorderSize = 1;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(337, 115);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(53, 48);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "customButton2";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.BackgroundColor = System.Drawing.Color.White;
            this.customButton2.BorderColor = System.Drawing.Color.DarkBlue;
            this.customButton2.BorderRadius = 5;
            this.customButton2.BorderSize = 1;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(280, 115);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(53, 48);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "customButton2";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 89);
            this.panel1.TabIndex = 0;
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exitbutton.IconColor = System.Drawing.Color.DarkBlue;
            this.exitbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitbutton.Location = new System.Drawing.Point(609, 25);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(88, 43);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton1.BorderColor = System.Drawing.Color.DarkBlue;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(607, 21);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(93, 50);
            this.customButton1.TabIndex = 2;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Add";
            // 
            // additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.customPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 478);
            this.Name = "additems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "additems";
            this.Load += new System.EventHandler(this.additems_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.additems_MouseDown);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private JTextBox.JText_Box qtytb;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox saucecb;
        private System.Windows.Forms.CheckBox ricecb;
        private System.Windows.Forms.CheckBox jayraldcb;
        private System.Windows.Forms.CheckBox neilcb;
        private System.Windows.Forms.Panel panel2;
        private CustomButton confirmbutton;
        private CustomControls.CustomRadioButton largerb;
        private CustomControls.CustomRadioButton mediumrb;
        private CustomControls.CustomRadioButton smallrb;
        private FontAwesome.Sharp.IconButton decrementbutton;
        private FontAwesome.Sharp.IconButton incrementbutton;
        private CustomButton customButton3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton exitbutton;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label1;
        private CustomButton customButton2;
    }
}