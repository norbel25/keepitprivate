namespace restotestng
{
    partial class HomeForm
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
            this.productflowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.restoDBDataSet = new restotestng.RestoDBDataSet();
            this.restoDBDataSet1 = new restotestng.RestoDBDataSet1();
            this.restoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter = new restotestng.RestoDBDataSet1TableAdapters.OrderItemTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new restotestng.RestoDBDataSetTableAdapters.ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalamouts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentordergrid = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.restoDBDataSet4 = new restotestng.RestoDBDataSet4();
            this.orderItemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restoDBDataSet21 = new restotestng.RestoDBDataSet2();
            this.orderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.restoDBDataSet3 = new restotestng.RestoDBDataSet3();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Drinksrb = new CustomControls.CustomRadioButton();
            this.Fastfoodrb = new CustomControls.CustomRadioButton();
            this.Allrb = new CustomControls.CustomRadioButton();
            this.Mealrb = new CustomControls.CustomRadioButton();
            this.orderItemTableAdapter1 = new restotestng.RestoDBDataSet3TableAdapters.OrderItemTableAdapter();
            this.orderItemTableAdapter2 = new restotestng.RestoDBDataSet2TableAdapters.OrderItemTableAdapter();
            this.orderItemTableAdapter3 = new restotestng.RestoDBDataSet4TableAdapters.OrderItemTableAdapter();
            this.clearbutton = new restotestng.CustomButton();
            this.paylaterbutton = new restotestng.CustomButton();
            this.paynowbutton = new restotestng.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentordergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productflowpanel
            // 
            this.productflowpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productflowpanel.AutoScroll = true;
            this.productflowpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productflowpanel.Location = new System.Drawing.Point(12, 189);
            this.productflowpanel.Name = "productflowpanel";
            this.productflowpanel.Size = new System.Drawing.Size(1357, 802);
            this.productflowpanel.TabIndex = 2;
            this.productflowpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // restoDBDataSet
            // 
            this.restoDBDataSet.DataSetName = "RestoDBDataSet";
            this.restoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restoDBDataSet1
            // 
            this.restoDBDataSet1.DataSetName = "RestoDBDataSet1";
            this.restoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restoDBDataSetBindingSource
            // 
            this.restoDBDataSetBindingSource.DataSource = this.restoDBDataSet;
            this.restoDBDataSetBindingSource.Position = 0;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "OrderItem";
            this.orderItemBindingSource.DataSource = this.restoDBDataSet1;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.restoDBDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paylaterbutton);
            this.panel2.Controls.Add(this.paynowbutton);
            this.panel2.Controls.Add(this.totalamouts);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 170);
            this.panel2.TabIndex = 2;
            // 
            // totalamouts
            // 
            this.totalamouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalamouts.AutoSize = true;
            this.totalamouts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.totalamouts.Location = new System.Drawing.Point(383, 34);
            this.totalamouts.Name = "totalamouts";
            this.totalamouts.Size = new System.Drawing.Size(39, 27);
            this.totalamouts.TabIndex = 0;
            this.totalamouts.Text = "₱0";
            this.totalamouts.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.currentordergrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1375, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 1055);
            this.panel1.TabIndex = 4;
            // 
            // currentordergrid
            // 
            this.currentordergrid.AllowUserToAddRows = false;
            this.currentordergrid.AllowUserToDeleteRows = false;
            this.currentordergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentordergrid.AutoGenerateColumns = false;
            this.currentordergrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.currentordergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentordergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.Quantity,
            this.Addons,
            this.Amount});
            this.currentordergrid.DataSource = this.orderItemBindingSource3;
            this.currentordergrid.Location = new System.Drawing.Point(14, 150);
            this.currentordergrid.Name = "currentordergrid";
            this.currentordergrid.ReadOnly = true;
            this.currentordergrid.RowHeadersWidth = 51;
            this.currentordergrid.RowTemplate.Height = 24;
            this.currentordergrid.Size = new System.Drawing.Size(523, 676);
            this.currentordergrid.TabIndex = 3;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 122;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 67;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 84;
            // 
            // Addons
            // 
            this.Addons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Addons.DataPropertyName = "Addons";
            this.Addons.HeaderText = "Add-ons";
            this.Addons.MinimumWidth = 6;
            this.Addons.Name = "Addons";
            this.Addons.ReadOnly = true;
            this.Addons.Width = 87;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 81;
            // 
            // orderItemBindingSource3
            // 
            this.orderItemBindingSource3.DataMember = "OrderItem";
            this.orderItemBindingSource3.DataSource = this.restoDBDataSet4;
            // 
            // restoDBDataSet4
            // 
            this.restoDBDataSet4.DataSetName = "RestoDBDataSet4";
            this.restoDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource2
            // 
            this.orderItemBindingSource2.DataMember = "OrderItem";
            this.orderItemBindingSource2.DataSource = this.restoDBDataSet21;
            // 
            // restoDBDataSet21
            // 
            this.restoDBDataSet21.DataSetName = "RestoDBDataSet2";
            this.restoDBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource1
            // 
            this.orderItemBindingSource1.DataMember = "OrderItem";
            this.orderItemBindingSource1.DataSource = this.restoDBDataSet3;
            // 
            // restoDBDataSet3
            // 
            this.restoDBDataSet3.DataSetName = "RestoDBDataSet3";
            this.restoDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.Drinksrb);
            this.panel3.Controls.Add(this.Fastfoodrb);
            this.panel3.Controls.Add(this.Allrb);
            this.panel3.Controls.Add(this.Mealrb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1375, 117);
            this.panel3.TabIndex = 6;
            // 
            // Drinksrb
            // 
            this.Drinksrb.AutoSize = true;
            this.Drinksrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Drinksrb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinksrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Drinksrb.Location = new System.Drawing.Point(568, 74);
            this.Drinksrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.Drinksrb.Name = "Drinksrb";
            this.Drinksrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Drinksrb.Size = new System.Drawing.Size(87, 21);
            this.Drinksrb.TabIndex = 6;
            this.Drinksrb.Text = "Drinks";
            this.Drinksrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.Drinksrb.UseVisualStyleBackColor = true;
            this.Drinksrb.CheckedChanged += new System.EventHandler(this.Drinksrb_CheckedChanged);
            // 
            // Fastfoodrb
            // 
            this.Fastfoodrb.AutoSize = true;
            this.Fastfoodrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Fastfoodrb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fastfoodrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Fastfoodrb.Location = new System.Drawing.Point(390, 73);
            this.Fastfoodrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.Fastfoodrb.Name = "Fastfoodrb";
            this.Fastfoodrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Fastfoodrb.Size = new System.Drawing.Size(102, 21);
            this.Fastfoodrb.TabIndex = 6;
            this.Fastfoodrb.Text = "Fastfood";
            this.Fastfoodrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.Fastfoodrb.UseVisualStyleBackColor = true;
            this.Fastfoodrb.CheckedChanged += new System.EventHandler(this.Fastfoodrb_CheckedChanged);
            // 
            // Allrb
            // 
            this.Allrb.AutoSize = true;
            this.Allrb.Checked = true;
            this.Allrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Allrb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Allrb.Location = new System.Drawing.Point(95, 73);
            this.Allrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.Allrb.Name = "Allrb";
            this.Allrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Allrb.Size = new System.Drawing.Size(58, 21);
            this.Allrb.TabIndex = 6;
            this.Allrb.TabStop = true;
            this.Allrb.Text = "All";
            this.Allrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.Allrb.UseVisualStyleBackColor = true;
            this.Allrb.CheckedChanged += new System.EventHandler(this.Allrb_CheckedChanged);
            // 
            // Mealrb
            // 
            this.Mealrb.AutoSize = true;
            this.Mealrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Mealrb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mealrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.Mealrb.Location = new System.Drawing.Point(235, 73);
            this.Mealrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.Mealrb.Name = "Mealrb";
            this.Mealrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Mealrb.Size = new System.Drawing.Size(73, 21);
            this.Mealrb.TabIndex = 6;
            this.Mealrb.Text = "Meal";
            this.Mealrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.Mealrb.UseVisualStyleBackColor = true;
            this.Mealrb.CheckedChanged += new System.EventHandler(this.Mealrb_CheckedChanged_1);
            // 
            // orderItemTableAdapter1
            // 
            this.orderItemTableAdapter1.ClearBeforeFill = true;
            // 
            // orderItemTableAdapter2
            // 
            this.orderItemTableAdapter2.ClearBeforeFill = true;
            // 
            // orderItemTableAdapter3
            // 
            this.orderItemTableAdapter3.ClearBeforeFill = true;
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.clearbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.clearbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clearbutton.BorderRadius = 20;
            this.clearbutton.BorderSize = 0;
            this.clearbutton.FlatAppearance.BorderSize = 0;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(375, 42);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(149, 63);
            this.clearbutton.TabIndex = 4;
            this.clearbutton.Text = "Clear";
            this.clearbutton.TextColor = System.Drawing.Color.White;
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbuttonClick);
            // 
            // paylaterbutton
            // 
            this.paylaterbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paylaterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.paylaterbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.paylaterbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.paylaterbutton.BorderRadius = 0;
            this.paylaterbutton.BorderSize = 0;
            this.paylaterbutton.FlatAppearance.BorderSize = 0;
            this.paylaterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paylaterbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paylaterbutton.ForeColor = System.Drawing.Color.White;
            this.paylaterbutton.Location = new System.Drawing.Point(14, 91);
            this.paylaterbutton.Name = "paylaterbutton";
            this.paylaterbutton.Size = new System.Drawing.Size(183, 63);
            this.paylaterbutton.TabIndex = 1;
            this.paylaterbutton.Text = "Pay Later";
            this.paylaterbutton.TextColor = System.Drawing.Color.White;
            this.paylaterbutton.UseVisualStyleBackColor = false;
            this.paylaterbutton.Click += new System.EventHandler(this.paylaterbutton_Click);
            // 
            // paynowbutton
            // 
            this.paynowbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paynowbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.paynowbutton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.paynowbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.paynowbutton.BorderRadius = 0;
            this.paynowbutton.BorderSize = 0;
            this.paynowbutton.FlatAppearance.BorderSize = 0;
            this.paynowbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paynowbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paynowbutton.ForeColor = System.Drawing.Color.White;
            this.paynowbutton.Location = new System.Drawing.Point(315, 91);
            this.paynowbutton.Name = "paynowbutton";
            this.paynowbutton.Size = new System.Drawing.Size(183, 63);
            this.paynowbutton.TabIndex = 1;
            this.paynowbutton.Text = "Pay Now";
            this.paynowbutton.TextColor = System.Drawing.Color.White;
            this.paynowbutton.UseVisualStyleBackColor = false;
            this.paynowbutton.Click += new System.EventHandler(this.paynowbutton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.productflowpanel);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentordergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoDBDataSet3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel productflowpanel;
        private RestoDBDataSet restoDBDataSet;
        private RestoDBDataSet1 restoDBDataSet1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource restoDBDataSetBindingSource;
        private RestoDBDataSet1TableAdapters.OrderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RestoDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CustomButton paylaterbutton;
        private CustomButton paynowbutton;
        private System.Windows.Forms.Label totalamouts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView currentordergrid;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.CustomRadioButton Drinksrb;
        private CustomControls.CustomRadioButton Fastfoodrb;
        private CustomControls.CustomRadioButton Mealrb;
        private CustomControls.CustomRadioButton Allrb;
        private RestoDBDataSet3 restoDBDataSet3;
        private RestoDBDataSet2 restoDBDataSet2;
        private System.Windows.Forms.BindingSource orderItemBindingSource1;
        private RestoDBDataSet3TableAdapters.OrderItemTableAdapter orderItemTableAdapter1;
        private RestoDBDataSet2 restoDBDataSet21;
        private System.Windows.Forms.BindingSource orderItemBindingSource2;
        private RestoDBDataSet2TableAdapters.OrderItemTableAdapter orderItemTableAdapter2;
        private RestoDBDataSet4 restoDBDataSet4;
        private System.Windows.Forms.BindingSource orderItemBindingSource3;
        private RestoDBDataSet4TableAdapters.OrderItemTableAdapter orderItemTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private CustomButton clearbutton;
    }
}