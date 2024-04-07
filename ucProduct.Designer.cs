namespace restotestng
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.Label();
            this.pimage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.productname);
            this.panel1.Controls.Add(this.pimage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 308);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.category.Location = new System.Drawing.Point(121, 229);
            this.category.Margin = new System.Windows.Forms.Padding(0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(62, 16);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Maroon;
            this.price.Location = new System.Drawing.Point(116, 252);
            this.price.Margin = new System.Windows.Forms.Padding(0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(61, 23);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.productname.Location = new System.Drawing.Point(84, 201);
            this.productname.Margin = new System.Windows.Forms.Padding(0);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(137, 21);
            this.productname.TabIndex = 1;
            this.productname.Text = "Product Name";
            this.productname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productname.Click += new System.EventHandler(this.productname_Click);
            // 
            // pimage
            // 
            this.pimage.Image = ((System.Drawing.Image)(resources.GetObject("pimage.Image")));
            this.pimage.Location = new System.Drawing.Point(34, 19);
            this.pimage.Name = "pimage";
            this.pimage.Size = new System.Drawing.Size(228, 179);
            this.pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pimage.TabIndex = 0;
            this.pimage.TabStop = false;
            this.pimage.Click += new System.EventHandler(this.pimage_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(317, 316);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.PictureBox pimage;
    }
}
