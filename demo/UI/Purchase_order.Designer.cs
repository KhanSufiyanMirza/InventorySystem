namespace demo.UI
{
    partial class Purchase_order
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.Product_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_records = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Purchase_namaeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_intolist = new System.Windows.Forms.Button();
            this.Purchase_orderComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Product_dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.add_records, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Purchase Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(744, 336);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(145, 43);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Product_dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Product_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Product_dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Product_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_id,
            this.pro_name,
            this.Brand_grid1,
            this.basic_price,
            this.gst,
            this.purchase_p,
            this.mrp,
            this.quantity_type,
            this.pro_cat});
            this.tableLayoutPanel1.SetColumnSpan(this.Product_dataGridView1, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product_dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product_dataGridView1.Location = new System.Drawing.Point(4, 124);
            this.Product_dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product_dataGridView1.Name = "Product_dataGridView1";
            this.Product_dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Product_dataGridView1.RowTemplate.Height = 35;
            this.Product_dataGridView1.Size = new System.Drawing.Size(1033, 206);
            this.Product_dataGridView1.TabIndex = 5;
            this.Product_dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Product_dataGridView1_DataError);
            this.Product_dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Product_dataGridView1_EditingControlShowing);
            this.Product_dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Product_dataGridView1_KeyDown);
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
            // 
            // Brand_grid1
            // 
            this.Brand_grid1.DataPropertyName = "brand";
            this.Brand_grid1.HeaderText = "Brand";
            this.Brand_grid1.Name = "Brand_grid1";
            this.Brand_grid1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // mrp
            // 
            this.mrp.DataPropertyName = "MRP";
            this.mrp.HeaderText = "MRP";
            this.mrp.Name = "mrp";
            this.mrp.ReadOnly = true;
            // 
            // quantity_type
            // 
            this.quantity_type.DataPropertyName = "Quantity_type";
            this.quantity_type.HeaderText = "Quantity Type";
            this.quantity_type.Name = "quantity_type";
            this.quantity_type.ReadOnly = true;
            // 
            // pro_cat
            // 
            this.pro_cat.DataPropertyName = "product_category";
            this.pro_cat.HeaderText = "Party Name";
            this.pro_cat.Name = "pro_cat";
            this.pro_cat.ReadOnly = true;
            // 
            // add_records
            // 
            this.add_records.BackColor = System.Drawing.Color.White;
            this.add_records.BackgroundImage = global::demo.Properties.Resources.printer__1_;
            this.add_records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_records.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.add_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_records.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_records.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_records.Location = new System.Drawing.Point(895, 336);
            this.add_records.Name = "add_records";
            this.add_records.Size = new System.Drawing.Size(143, 43);
            this.add_records.TabIndex = 3;
            this.add_records.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_records.UseVisualStyleBackColor = false;
            this.add_records.Click += new System.EventHandler(this.add_records_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.Controls.Add(this.Purchase_namaeComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_intolist, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Purchase_orderComboBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(595, 77);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Purchase_namaeComboBox
            // 
            this.Purchase_namaeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Purchase_namaeComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_namaeComboBox.FormattingEnabled = true;
            this.Purchase_namaeComboBox.Location = new System.Drawing.Point(3, 31);
            this.Purchase_namaeComboBox.Name = "Purchase_namaeComboBox";
            this.Purchase_namaeComboBox.Size = new System.Drawing.Size(221, 31);
            this.Purchase_namaeComboBox.TabIndex = 1;
            this.Purchase_namaeComboBox.TextUpdate += new System.EventHandler(this.Purchase_namaeComboBox_TextUpdate);
            this.Purchase_namaeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Purchase_namaeComboBox_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Brand";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Submit";
            // 
            // add_intolist
            // 
            this.add_intolist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_intolist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.add_intolist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.add_intolist.FlatAppearance.BorderSize = 0;
            this.add_intolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_intolist.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_intolist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_intolist.Location = new System.Drawing.Point(457, 31);
            this.add_intolist.Name = "add_intolist";
            this.add_intolist.Size = new System.Drawing.Size(135, 43);
            this.add_intolist.TabIndex = 3;
            this.add_intolist.Text = "Add";
            this.add_intolist.UseVisualStyleBackColor = false;
            this.add_intolist.Click += new System.EventHandler(this.add_intolist_Click);
            // 
            // Purchase_orderComboBox
            // 
            this.Purchase_orderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purchase_orderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Purchase_orderComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_orderComboBox.FormattingEnabled = true;
            this.Purchase_orderComboBox.Location = new System.Drawing.Point(230, 31);
            this.Purchase_orderComboBox.Name = "Purchase_orderComboBox";
            this.Purchase_orderComboBox.Size = new System.Drawing.Size(166, 31);
            this.Purchase_orderComboBox.TabIndex = 2;
            this.Purchase_orderComboBox.Enter += new System.EventHandler(this.Purchase_orderComboBox_Enter);
            this.Purchase_orderComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Purchase_orderComboBox_KeyDown);
            // 
            // Purchase_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Purchase_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_order";
            this.Load += new System.EventHandler(this.Purchase_order_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Purchase_order_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Product_dataGridView1;
        private System.Windows.Forms.Button add_records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Purchase_namaeComboBox;
        private System.Windows.Forms.Button add_intolist;
        private System.Windows.Forms.ComboBox Purchase_orderComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn basic_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cat;
    }
}