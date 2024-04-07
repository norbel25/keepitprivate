namespace restotestng
{
    partial class AddProduct
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
            this.productimage = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addproductbutton = new restotestng.CustomButton();
            this.productname = new JTextBox.JText_Box();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new JTextBox.JText_Box();
            this.label4 = new System.Windows.Forms.Label();
            this.category = new JTextBox.JText_Box();
            this.selectimagebutton = new restotestng.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.productimage)).BeginInit();
            this.SuspendLayout();
            // 
            // productimage
            // 
            this.productimage.BackColor = System.Drawing.SystemColors.Control;
            this.productimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productimage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productimage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.productimage.IconColor = System.Drawing.SystemColors.ControlText;
            this.productimage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productimage.IconSize = 210;
            this.productimage.Location = new System.Drawing.Point(86, 80);
            this.productimage.Name = "productimage";
            this.productimage.Size = new System.Drawing.Size(264, 210);
            this.productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productimage.TabIndex = 0;
            this.productimage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // addproductbutton
            // 
            this.addproductbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addproductbutton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addproductbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addproductbutton.BorderRadius = 20;
            this.addproductbutton.BorderSize = 0;
            this.addproductbutton.FlatAppearance.BorderSize = 0;
            this.addproductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproductbutton.ForeColor = System.Drawing.Color.White;
            this.addproductbutton.Location = new System.Drawing.Point(444, 345);
            this.addproductbutton.Name = "addproductbutton";
            this.addproductbutton.Size = new System.Drawing.Size(151, 46);
            this.addproductbutton.TabIndex = 5;
            this.addproductbutton.Text = "Add";
            this.addproductbutton.TextColor = System.Drawing.Color.White;
            this.addproductbutton.UseVisualStyleBackColor = false;
            this.addproductbutton.Click += new System.EventHandler(this.addproductbutton_Click);
            // 
            // productname
            // 
            this.productname.BorderColor = System.Drawing.Color.Black;
            this.productname.BorderThickness = 1;
            this.productname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productname.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productname.Location = new System.Drawing.Point(416, 82);
            this.productname.Margin = new System.Windows.Forms.Padding(5);
            this.productname.MaxLength = 32767;
            this.productname.Name = "productname";
            this.productname.onFocusBorderColor = System.Drawing.Color.Magenta;
            this.productname.PasswordChar = '\0';
            this.productname.RoundedBorder = 0;
            this.productname.Size = new System.Drawing.Size(200, 40);
            this.productname.TabIndex = 2;
            this.productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productname.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productname.TextInput = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // price
            // 
            this.price.BorderColor = System.Drawing.Color.Black;
            this.price.BorderThickness = 1;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price.Location = new System.Drawing.Point(416, 181);
            this.price.Margin = new System.Windows.Forms.Padding(5);
            this.price.MaxLength = 32767;
            this.price.Name = "price";
            this.price.onFocusBorderColor = System.Drawing.Color.Magenta;
            this.price.PasswordChar = '\0';
            this.price.RoundedBorder = 0;
            this.price.Size = new System.Drawing.Size(200, 40);
            this.price.TabIndex = 3;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price.TextInput = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category";
            // 
            // category
            // 
            this.category.BorderColor = System.Drawing.Color.Black;
            this.category.BorderThickness = 1;
            this.category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category.Location = new System.Drawing.Point(416, 280);
            this.category.Margin = new System.Windows.Forms.Padding(5);
            this.category.MaxLength = 32767;
            this.category.Name = "category";
            this.category.onFocusBorderColor = System.Drawing.Color.Magenta;
            this.category.PasswordChar = '\0';
            this.category.RoundedBorder = 0;
            this.category.Size = new System.Drawing.Size(200, 40);
            this.category.TabIndex = 4;
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.category.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category.TextInput = "";
            // 
            // selectimagebutton
            // 
            this.selectimagebutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.selectimagebutton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.selectimagebutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.selectimagebutton.BorderRadius = 20;
            this.selectimagebutton.BorderSize = 0;
            this.selectimagebutton.FlatAppearance.BorderSize = 0;
            this.selectimagebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectimagebutton.ForeColor = System.Drawing.Color.White;
            this.selectimagebutton.Location = new System.Drawing.Point(138, 319);
            this.selectimagebutton.Name = "selectimagebutton";
            this.selectimagebutton.Size = new System.Drawing.Size(152, 46);
            this.selectimagebutton.TabIndex = 1;
            this.selectimagebutton.Text = "Select Image";
            this.selectimagebutton.TextColor = System.Drawing.Color.White;
            this.selectimagebutton.UseVisualStyleBackColor = false;
            this.selectimagebutton.Click += new System.EventHandler(this.selectimagebutton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 435);
            this.Controls.Add(this.category);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectimagebutton);
            this.Controls.Add(this.addproductbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productimage);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox productimage;
        private System.Windows.Forms.Label label1;
        private CustomButton addproductbutton;
        private JTextBox.JText_Box productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private JTextBox.JText_Box price;
        private System.Windows.Forms.Label label4;
        private JTextBox.JText_Box category;
        private CustomButton selectimagebutton;
    }
}