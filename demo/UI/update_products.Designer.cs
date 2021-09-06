namespace demo.UI
{
    partial class update_products
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Product_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancle = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label9_qty = new System.Windows.Forms.Label();
            this.browse_img = new System.Windows.Forms.Button();
            this.selling_price_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mrp_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Purchase_price_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Party_name_comboBox = new System.Windows.Forms.ComboBox();
            this.Brand_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.Product_name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Base_pricetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Invoice_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Gst_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quantity_type_combox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Product_dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1156, 313);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // Product_dataGridView1
            // 
            this.Product_dataGridView1.AllowUserToAddRows = false;
            this.Product_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_id,
            this.pro_name,
            this.basic_price,
            this.gst,
            this.purchase_p,
            this.sell_p,
            this.mrp,
            this.pro_qty,
            this.quantity_type,
            this.Brand_grid1,
            this.pro_cat,
            this.pro_img,
            this.invoice});
            this.Product_dataGridView1.Location = new System.Drawing.Point(6, 15);
            this.Product_dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product_dataGridView1.Name = "Product_dataGridView1";
            this.Product_dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Product_dataGridView1.RowTemplate.Height = 35;
            this.Product_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product_dataGridView1.Size = new System.Drawing.Size(1142, 292);
            this.Product_dataGridView1.TabIndex = 45;
            this.Product_dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Product_dataGridView1_MouseDoubleClick);
            // 
            // pro_id
            // 
            this.pro_id.DataPropertyName = "id";
            this.pro_id.HeaderText = "product id";
            this.pro_id.Name = "pro_id";
            this.pro_id.ReadOnly = true;
            this.pro_id.Visible = false;
            // 
            // pro_name
            // 
            this.pro_name.DataPropertyName = "product_name";
            this.pro_name.HeaderText = "Product Name";
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            // 
            // basic_price
            // 
            this.basic_price.DataPropertyName = "base_price";
            this.basic_price.HeaderText = "Base Price";
            this.basic_price.Name = "basic_price";
            this.basic_price.ReadOnly = true;
            // 
            // gst
            // 
            this.gst.DataPropertyName = "Gst";
            this.gst.HeaderText = "Gst";
            this.gst.Name = "gst";
            this.gst.ReadOnly = true;
            // 
            // purchase_p
            // 
            this.purchase_p.DataPropertyName = "purchase_price";
            this.purchase_p.HeaderText = "Purchase Price";
            this.purchase_p.Name = "purchase_p";
            this.purchase_p.ReadOnly = true;
            // 
            // sell_p
            // 
            this.sell_p.DataPropertyName = "sell_price";
            this.sell_p.HeaderText = "Selling Price";
            this.sell_p.Name = "sell_p";
            this.sell_p.ReadOnly = true;
            // 
            // mrp
            // 
            this.mrp.DataPropertyName = "MRP";
            this.mrp.HeaderText = "MRP";
            this.mrp.Name = "mrp";
            this.mrp.ReadOnly = true;
            // 
            // pro_qty
            // 
            this.pro_qty.DataPropertyName = "product_quantity";
            this.pro_qty.HeaderText = "Quantity";
            this.pro_qty.Name = "pro_qty";
            this.pro_qty.ReadOnly = true;
            // 
            // quantity_type
            // 
            this.quantity_type.DataPropertyName = "Quantity_type";
            this.quantity_type.HeaderText = "Quantity Type";
            this.quantity_type.Name = "quantity_type";
            this.quantity_type.ReadOnly = true;
            // 
            // Brand_grid1
            // 
            this.Brand_grid1.DataPropertyName = "brand";
            this.Brand_grid1.HeaderText = "Brand";
            this.Brand_grid1.Name = "Brand_grid1";
            this.Brand_grid1.ReadOnly = true;
            // 
            // pro_cat
            // 
            this.pro_cat.DataPropertyName = "product_category";
            this.pro_cat.HeaderText = "Party Name";
            this.pro_cat.Name = "pro_cat";
            this.pro_cat.ReadOnly = true;
            // 
            // pro_img
            // 
            this.pro_img.DataPropertyName = "product_img";
            this.pro_img.HeaderText = "Product Image";
            this.pro_img.Name = "pro_img";
            this.pro_img.ReadOnly = true;
            this.pro_img.Visible = false;
            // 
            // invoice
            // 
            this.invoice.DataPropertyName = "invoice";
            this.invoice.HeaderText = "Invoice Number";
            this.invoice.Name = "invoice";
            this.invoice.ReadOnly = true;
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancle.ForeColor = System.Drawing.Color.White;
            this.cancle.Location = new System.Drawing.Point(1447, 188);
            this.cancle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(124, 50);
            this.cancle.TabIndex = 78;
            this.cancle.Text = "Reset";
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Visible = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(983, 199);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 50);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Highlight;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(882, 198);
            this.update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(89, 50);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(607, 166);
            this.textBox_quantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(247, 22);
            this.textBox_quantity.TabIndex = 10;
            this.textBox_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.textBox_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label9_qty
            // 
            this.label9_qty.AutoSize = true;
            this.label9_qty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_qty.Location = new System.Drawing.Point(501, 157);
            this.label9_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9_qty.Name = "label9_qty";
            this.label9_qty.Size = new System.Drawing.Size(81, 22);
            this.label9_qty.TabIndex = 101;
            this.label9_qty.Text = "Quantity:";
            // 
            // browse_img
            // 
            this.browse_img.BackColor = System.Drawing.SystemColors.Highlight;
            this.browse_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_img.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_img.ForeColor = System.Drawing.Color.White;
            this.browse_img.Location = new System.Drawing.Point(692, 3);
            this.browse_img.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browse_img.Name = "browse_img";
            this.browse_img.Size = new System.Drawing.Size(159, 50);
            this.browse_img.TabIndex = 6;
            this.browse_img.Text = "Browse";
            this.browse_img.UseVisualStyleBackColor = false;
            this.browse_img.Click += new System.EventHandler(this.browse_img_Click);
            // 
            // selling_price_textBox
            // 
            this.selling_price_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selling_price_textBox.Location = new System.Drawing.Point(608, 132);
            this.selling_price_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selling_price_textBox.Name = "selling_price_textBox";
            this.selling_price_textBox.Size = new System.Drawing.Size(247, 22);
            this.selling_price_textBox.TabIndex = 9;
            this.selling_price_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.selling_price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 97;
            this.label8.Text = "Selling Price:";
            // 
            // Mrp_textBox
            // 
            this.Mrp_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mrp_textBox.Location = new System.Drawing.Point(607, 62);
            this.Mrp_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Mrp_textBox.Name = "Mrp_textBox";
            this.Mrp_textBox.Size = new System.Drawing.Size(247, 22);
            this.Mrp_textBox.TabIndex = 7;
            this.Mrp_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.Mrp_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 95;
            this.label7.Text = "Upload:";
            // 
            // Purchase_price_textBox
            // 
            this.Purchase_price_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_price_textBox.Location = new System.Drawing.Point(608, 96);
            this.Purchase_price_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Purchase_price_textBox.Name = "Purchase_price_textBox";
            this.Purchase_price_textBox.Size = new System.Drawing.Size(247, 22);
            this.Purchase_price_textBox.TabIndex = 8;
            this.Purchase_price_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.Purchase_price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 93;
            this.label6.Text = "Purchase Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "MRP:";
            // 
            // Party_name_comboBox
            // 
            this.Party_name_comboBox.FormattingEnabled = true;
            this.Party_name_comboBox.Location = new System.Drawing.Point(163, 216);
            this.Party_name_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Party_name_comboBox.Name = "Party_name_comboBox";
            this.Party_name_comboBox.Size = new System.Drawing.Size(245, 22);
            this.Party_name_comboBox.TabIndex = 5;
            this.Party_name_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            // 
            // Brand_comboBox
            // 
            this.Brand_comboBox.FormattingEnabled = true;
            this.Brand_comboBox.Location = new System.Drawing.Point(163, 174);
            this.Brand_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Brand_comboBox.Name = "Brand_comboBox";
            this.Brand_comboBox.Size = new System.Drawing.Size(245, 22);
            this.Brand_comboBox.TabIndex = 4;
            this.Brand_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "Brand:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 104;
            this.label5.Text = "Party Name:";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(163, 12);
            this.search_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(245, 22);
            this.search_txt.TabIndex = 0;
            this.search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_txt_KeyDown);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.Highlight;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(425, 2);
            this.check.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(124, 37);
            this.check.TabIndex = 110;
            this.check.Text = "Search";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Product_name_textBox
            // 
            this.Product_name_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_name_textBox.Location = new System.Drawing.Point(164, 47);
            this.Product_name_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product_name_textBox.Name = "Product_name_textBox";
            this.Product_name_textBox.Size = new System.Drawing.Size(244, 22);
            this.Product_name_textBox.TabIndex = 1;
            this.Product_name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 107;
            this.label2.Text = "Product Name:";
            // 
            // Base_pricetextBox
            // 
            this.Base_pricetextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_pricetextBox.Location = new System.Drawing.Point(163, 87);
            this.Base_pricetextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Base_pricetextBox.Name = "Base_pricetextBox";
            this.Base_pricetextBox.Size = new System.Drawing.Size(244, 22);
            this.Base_pricetextBox.TabIndex = 2;
            this.Base_pricetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.Base_pricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 112;
            this.label1.Text = "Base Price:";
            // 
            // Invoice_textBox
            // 
            this.Invoice_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_textBox.Location = new System.Drawing.Point(608, 225);
            this.Invoice_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Invoice_textBox.Name = "Invoice_textBox";
            this.Invoice_textBox.Size = new System.Drawing.Size(247, 22);
            this.Invoice_textBox.TabIndex = 12;
            this.Invoice_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 118;
            this.label9.Text = "Invoice No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 22);
            this.label10.TabIndex = 116;
            this.label10.Text = "Quantity_type:";
            // 
            // Gst_textBox
            // 
            this.Gst_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gst_textBox.Location = new System.Drawing.Point(161, 129);
            this.Gst_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gst_textBox.Name = "Gst_textBox";
            this.Gst_textBox.Size = new System.Drawing.Size(247, 22);
            this.Gst_textBox.TabIndex = 3;
            this.Gst_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            this.Gst_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Base_pricetextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(92, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 114;
            this.label11.Text = "GST:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(879, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1087, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantity_type_combox
            // 
            this.quantity_type_combox.FormattingEnabled = true;
            this.quantity_type_combox.Location = new System.Drawing.Point(608, 196);
            this.quantity_type_combox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quantity_type_combox.Name = "quantity_type_combox";
            this.quantity_type_combox.Size = new System.Drawing.Size(245, 22);
            this.quantity_type_combox.TabIndex = 11;
            this.quantity_type_combox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gst_textBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // update_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 579);
            this.Controls.Add(this.quantity_type_combox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Invoice_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Gst_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Base_pricetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Product_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Party_name_comboBox);
            this.Controls.Add(this.Brand_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label9_qty);
            this.Controls.Add(this.browse_img);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selling_price_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Mrp_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Purchase_price_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "update_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_products";
            this.Load += new System.EventHandler(this.update_products_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.update_products_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Product_dataGridView1;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label9_qty;
        private System.Windows.Forms.Button browse_img;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox selling_price_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Mrp_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Purchase_price_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Party_name_comboBox;
        private System.Windows.Forms.ComboBox Brand_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox Product_name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Base_pricetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Invoice_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Gst_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox quantity_type_combox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn basic_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}