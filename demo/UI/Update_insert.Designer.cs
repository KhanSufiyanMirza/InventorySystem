namespace demo.UI
{
    partial class Update_insert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basic_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Add_img = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.add_records = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Party_name = new System.Windows.Forms.TextBox();
            this.invoice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.discounttextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Purchase_namaeComboBox = new System.Windows.Forms.ComboBox();
            this.purchase_BasePricetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addlist_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.purchase_BrandcomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.purchase_MrptextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.purchase_SellingPricetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.purchase_QtyTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.purchase_QtytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.purchase_PurchasePricetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.purchase_GsttextBox = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1260, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.Product_name,
            this.Basic_price,
            this.gst,
            this.Purchase_price,
            this.Product_quantity,
            this.Quantity_type,
            this.Selling_price,
            this.mrp,
            this.Brand_name,
            this.Add_img,
            this.Up_img,
            this.product_id,
            this.discount_grid1});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 236);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 188);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Sno
            // 
            this.Sno.HeaderText = "SNo";
            this.Sno.Name = "Sno";
            this.Sno.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.Name = "Product_name";
            // 
            // Basic_price
            // 
            this.Basic_price.HeaderText = "Base Price";
            this.Basic_price.Name = "Basic_price";
            // 
            // gst
            // 
            this.gst.HeaderText = "Gst";
            this.gst.Name = "gst";
            // 
            // Purchase_price
            // 
            this.Purchase_price.HeaderText = "Purchase Price";
            this.Purchase_price.Name = "Purchase_price";
            // 
            // Product_quantity
            // 
            this.Product_quantity.HeaderText = "Quantity";
            this.Product_quantity.Name = "Product_quantity";
            // 
            // Quantity_type
            // 
            this.Quantity_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quantity_type.HeaderText = "Quantity Type";
            this.Quantity_type.Name = "Quantity_type";
            // 
            // Selling_price
            // 
            this.Selling_price.HeaderText = "Selling Price";
            this.Selling_price.Name = "Selling_price";
            // 
            // mrp
            // 
            this.mrp.HeaderText = "MRP";
            this.mrp.Name = "mrp";
            // 
            // Brand_name
            // 
            this.Brand_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brand_name.HeaderText = "Brand Name";
            this.Brand_name.Name = "Brand_name";
            // 
            // Add_img
            // 
            this.Add_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_img.HeaderText = "Upload Image";
            this.Add_img.Name = "Add_img";
            this.Add_img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add_img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Add_img.Text = "Upload ";
            this.Add_img.UseColumnTextForButtonValue = true;
            // 
            // Up_img
            // 
            this.Up_img.HeaderText = "Image";
            this.Up_img.Name = "Up_img";
            this.Up_img.ReadOnly = true;
            this.Up_img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Up_img.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // discount_grid1
            // 
            this.discount_grid1.HeaderText = "Discount";
            this.discount_grid1.Name = "discount_grid1";
            this.discount_grid1.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.CornerRadius = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(8, 6);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(229, 30);
            this.rectangleShape2.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // add_records
            // 
            this.add_records.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.add_records.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.add_records.FlatAppearance.BorderSize = 0;
            this.add_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_records.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_records.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_records.Location = new System.Drawing.Point(6, 10);
            this.add_records.Name = "add_records";
            this.add_records.Size = new System.Drawing.Size(145, 44);
            this.add_records.TabIndex = 1;
            this.add_records.Text = "Add ";
            this.add_records.UseVisualStyleBackColor = false;
            this.add_records.Click += new System.EventHandler(this.add_records_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter Party Name:";
            // 
            // Party_name
            // 
            this.Party_name.BackColor = System.Drawing.Color.White;
            this.Party_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Party_name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Party_name.Location = new System.Drawing.Point(10, 9);
            this.Party_name.Name = "Party_name";
            this.Party_name.Size = new System.Drawing.Size(227, 24);
            this.Party_name.TabIndex = 0;
            this.Party_name.Tag = "Enter product name";
            this.Party_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Party_name_KeyDown);
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.White;
            this.invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.Location = new System.Drawing.Point(10, 8);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(227, 24);
            this.invoice.TabIndex = 1;
            this.invoice.Tag = "Enter product name";
            this.invoice.TextChanged += new System.EventHandler(this.invoice_TextChanged);
            this.invoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Party_name_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.add_records);
            this.groupBox1.Location = new System.Drawing.Point(922, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(162, 8);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(145, 44);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Clear";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.05462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.94538F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.info, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.48944F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.31452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.70968F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 496);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.76334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.23666F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.72897F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.27103F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 149);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.invoice);
            this.panel2.Controls.Add(this.shapeContainer4);
            this.panel2.Location = new System.Drawing.Point(240, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 42);
            this.panel2.TabIndex = 34;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer4.Size = new System.Drawing.Size(243, 42);
            this.shapeContainer4.TabIndex = 28;
            this.shapeContainer4.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(8, 6);
            this.rectangleShape1.Name = "rectangleShape2";
            this.rectangleShape1.Size = new System.Drawing.Size(229, 28);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Invoice Number:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Party_name);
            this.panel1.Controls.Add(this.shapeContainer3);
            this.panel1.Location = new System.Drawing.Point(241, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 42);
            this.panel1.TabIndex = 33;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(242, 42);
            this.shapeContainer3.TabIndex = 28;
            this.shapeContainer3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5614F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20734F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.698565F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.30622F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.12759F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.385965F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.502392F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.504584F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.851675F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.293461F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.416268F));
            this.tableLayoutPanel3.Controls.Add(this.discounttextBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Purchase_namaeComboBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.purchase_BasePricetextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.addlist_button, 10, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_BrandcomboBox, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_MrptextBox, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_SellingPricetextBox, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_QtyTypecomboBox, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_QtytextBox, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_PurchasePricetextBox, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchase_GsttextBox, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 158);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1254, 72);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // discounttextBox
            // 
            this.discounttextBox.BackColor = System.Drawing.Color.White;
            this.discounttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discounttextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discounttextBox.Location = new System.Drawing.Point(439, 28);
            this.discounttextBox.Name = "discounttextBox";
            this.discounttextBox.Size = new System.Drawing.Size(53, 31);
            this.discounttextBox.TabIndex = 4;
            this.discounttextBox.Tag = "Enter product name";
            this.discounttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.forpurchase_pricdkeydown);
            this.discounttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "Discount:";
            // 
            // Purchase_namaeComboBox
            // 
            this.Purchase_namaeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Purchase_namaeComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_namaeComboBox.FormattingEnabled = true;
            this.Purchase_namaeComboBox.Location = new System.Drawing.Point(3, 28);
            this.Purchase_namaeComboBox.Name = "Purchase_namaeComboBox";
            this.Purchase_namaeComboBox.Size = new System.Drawing.Size(302, 31);
            this.Purchase_namaeComboBox.TabIndex = 2;
            this.Purchase_namaeComboBox.TextUpdate += new System.EventHandler(this.Purchase_namaeComboBox_TextUpdate);
            this.Purchase_namaeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.purchase_nametextBox_KeyDown);
            // 
            // purchase_BasePricetextBox
            // 
            this.purchase_BasePricetextBox.BackColor = System.Drawing.Color.White;
            this.purchase_BasePricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_BasePricetextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_BasePricetextBox.Location = new System.Drawing.Point(311, 28);
            this.purchase_BasePricetextBox.Name = "purchase_BasePricetextBox";
            this.purchase_BasePricetextBox.Size = new System.Drawing.Size(88, 31);
            this.purchase_BasePricetextBox.TabIndex = 3;
            this.purchase_BasePricetextBox.Tag = "Enter product name";
            this.purchase_BasePricetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.forpurchase_pricdkeydown);
            this.purchase_BasePricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Base Price:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1162, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Submit:";
            // 
            // addlist_button
            // 
            this.addlist_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.addlist_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.addlist_button.FlatAppearance.BorderSize = 0;
            this.addlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addlist_button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlist_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addlist_button.Location = new System.Drawing.Point(1162, 28);
            this.addlist_button.Name = "addlist_button";
            this.addlist_button.Size = new System.Drawing.Size(89, 30);
            this.addlist_button.TabIndex = 12;
            this.addlist_button.Text = "Add  into list";
            this.addlist_button.UseVisualStyleBackColor = false;
            this.addlist_button.Click += new System.EventHandler(this.addlist_button_Click);
            this.addlist_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1058, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Brand Name:";
            // 
            // purchase_BrandcomboBox
            // 
            this.purchase_BrandcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_BrandcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchase_BrandcomboBox.FormattingEnabled = true;
            this.purchase_BrandcomboBox.Location = new System.Drawing.Point(1058, 28);
            this.purchase_BrandcomboBox.Name = "purchase_BrandcomboBox";
            this.purchase_BrandcomboBox.Size = new System.Drawing.Size(77, 24);
            this.purchase_BrandcomboBox.TabIndex = 11;
            this.purchase_BrandcomboBox.Enter += new System.EventHandler(this.combobox_dropdown);
            this.purchase_BrandcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(947, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "MRP:";
            // 
            // purchase_MrptextBox
            // 
            this.purchase_MrptextBox.BackColor = System.Drawing.Color.White;
            this.purchase_MrptextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_MrptextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_MrptextBox.Location = new System.Drawing.Point(947, 28);
            this.purchase_MrptextBox.Name = "purchase_MrptextBox";
            this.purchase_MrptextBox.Size = new System.Drawing.Size(105, 31);
            this.purchase_MrptextBox.TabIndex = 10;
            this.purchase_MrptextBox.Tag = "Enter product name";
            this.purchase_MrptextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            this.purchase_MrptextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(828, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Selling Price:";
            // 
            // purchase_SellingPricetextBox
            // 
            this.purchase_SellingPricetextBox.BackColor = System.Drawing.Color.White;
            this.purchase_SellingPricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_SellingPricetextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_SellingPricetextBox.Location = new System.Drawing.Point(828, 28);
            this.purchase_SellingPricetextBox.Name = "purchase_SellingPricetextBox";
            this.purchase_SellingPricetextBox.Size = new System.Drawing.Size(102, 31);
            this.purchase_SellingPricetextBox.TabIndex = 9;
            this.purchase_SellingPricetextBox.Tag = "Enter product name";
            this.purchase_SellingPricetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            this.purchase_SellingPricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(759, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Per:";
            // 
            // purchase_QtyTypecomboBox
            // 
            this.purchase_QtyTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_QtyTypecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchase_QtyTypecomboBox.FormattingEnabled = true;
            this.purchase_QtyTypecomboBox.Location = new System.Drawing.Point(759, 28);
            this.purchase_QtyTypecomboBox.Name = "purchase_QtyTypecomboBox";
            this.purchase_QtyTypecomboBox.Size = new System.Drawing.Size(63, 24);
            this.purchase_QtyTypecomboBox.TabIndex = 8;
            this.purchase_QtyTypecomboBox.Enter += new System.EventHandler(this.combobox_dropdown);
            this.purchase_QtyTypecomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(704, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Qty";
            // 
            // purchase_QtytextBox
            // 
            this.purchase_QtytextBox.BackColor = System.Drawing.Color.White;
            this.purchase_QtytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_QtytextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_QtytextBox.Location = new System.Drawing.Point(704, 28);
            this.purchase_QtytextBox.Name = "purchase_QtytextBox";
            this.purchase_QtytextBox.Size = new System.Drawing.Size(46, 31);
            this.purchase_QtytextBox.TabIndex = 7;
            this.purchase_QtytextBox.Tag = "Enter product name";
            this.purchase_QtytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            this.purchase_QtytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Purchase Price:";
            // 
            // purchase_PurchasePricetextBox
            // 
            this.purchase_PurchasePricetextBox.BackColor = System.Drawing.Color.White;
            this.purchase_PurchasePricetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_PurchasePricetextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_PurchasePricetextBox.Location = new System.Drawing.Point(577, 28);
            this.purchase_PurchasePricetextBox.Name = "purchase_PurchasePricetextBox";
            this.purchase_PurchasePricetextBox.ReadOnly = true;
            this.purchase_PurchasePricetextBox.Size = new System.Drawing.Size(110, 31);
            this.purchase_PurchasePricetextBox.TabIndex = 6;
            this.purchase_PurchasePricetextBox.Tag = "Enter product name";
            this.purchase_PurchasePricetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.general_keydown);
            this.purchase_PurchasePricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "GST:";
            // 
            // purchase_GsttextBox
            // 
            this.purchase_GsttextBox.BackColor = System.Drawing.Color.White;
            this.purchase_GsttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_GsttextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_GsttextBox.Location = new System.Drawing.Point(523, 28);
            this.purchase_GsttextBox.Name = "purchase_GsttextBox";
            this.purchase_GsttextBox.Size = new System.Drawing.Size(48, 31);
            this.purchase_GsttextBox.TabIndex = 5;
            this.purchase_GsttextBox.Tag = "Enter product name";
            this.purchase_GsttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.forpurchase_pricdkeydown);
            this.purchase_GsttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.general_keypress);
            // 
            // info
            // 
            this.info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(860, 68);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(57, 18);
            this.info.TabIndex = 34;
            this.info.Text = "INFO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Update_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Update_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Selling Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Update_insert_Activated);
            this.Load += new System.EventHandler(this.Update_insert_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Update_insert_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button add_records;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.TextBox Party_name;
        private System.Windows.Forms.TextBox invoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox purchase_MrptextBox;
        private System.Windows.Forms.TextBox purchase_SellingPricetextBox;
        private System.Windows.Forms.TextBox purchase_QtytextBox;
        private System.Windows.Forms.TextBox purchase_PurchasePricetextBox;
        private System.Windows.Forms.TextBox purchase_GsttextBox;
        private System.Windows.Forms.TextBox purchase_BasePricetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addlist_button;
        private System.Windows.Forms.ComboBox purchase_BrandcomboBox;
        private System.Windows.Forms.ComboBox purchase_QtyTypecomboBox;
        private System.Windows.Forms.ComboBox Purchase_namaeComboBox;
        private System.Windows.Forms.TextBox discounttextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basic_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Quantity_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrp;
        private System.Windows.Forms.DataGridViewComboBoxColumn Brand_name;
        private System.Windows.Forms.DataGridViewButtonColumn Add_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Up_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_grid1;
    }
}