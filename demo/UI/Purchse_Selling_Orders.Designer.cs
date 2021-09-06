namespace demo.UI
{
    partial class Purchse_Selling_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Order_details_Grid = new System.Windows.Forms.DataGridView();
            this.Order_Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyradioButton = new System.Windows.Forms.RadioButton();
            this.invoiceradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PurchaseradioButton = new System.Windows.Forms.RadioButton();
            this.SellingradioButton = new System.Windows.Forms.RadioButton();
            this.Print = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Invoicelabel2 = new System.Windows.Forms.Label();
            this.Partylabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.DateSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Order_details_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.White;
            this.SearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchtextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(181, 31);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.Tag = "Enter product name";
            this.SearchtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchtextBox_KeyDown);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Highlight;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(190, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 32);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Order_details_Grid
            // 
            this.Order_details_Grid.AllowUserToAddRows = false;
            this.Order_details_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_details_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_details_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Order_details_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_details_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Order_id,
            this.pro_name,
            this.discount,
            this.BasePrice,
            this.gst,
            this.purchase_p,
            this.pro_qty,
            this.qty_type,
            this.brand});
            this.tableLayoutPanel1.SetColumnSpan(this.Order_details_Grid, 2);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_details_Grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.Order_details_Grid.Location = new System.Drawing.Point(18, 304);
            this.Order_details_Grid.Name = "Order_details_Grid";
            this.Order_details_Grid.ReadOnly = true;
            this.Order_details_Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_details_Grid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Order_details_Grid.RowTemplate.Height = 35;
            this.Order_details_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_details_Grid.Size = new System.Drawing.Size(1107, 217);
            this.Order_details_Grid.TabIndex = 53;
            // 
            // Order_Grid
            // 
            this.Order_Grid.AllowUserToAddRows = false;
            this.Order_Grid.AllowUserToDeleteRows = false;
            this.Order_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Order_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.PartyName,
            this.Invoice,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Order_Grid.Location = new System.Drawing.Point(18, 141);
            this.Order_Grid.Name = "Order_Grid";
            this.Order_Grid.ReadOnly = true;
            this.Order_Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Grid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Order_Grid.RowTemplate.Height = 35;
            this.Order_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Order_Grid.Size = new System.Drawing.Size(670, 157);
            this.Order_Grid.TabIndex = 54;
            this.Order_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_Grid_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "order id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // PartyName
            // 
            this.PartyName.DataPropertyName = "PartyName";
            this.PartyName.HeaderText = "Party Name";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            // 
            // Invoice
            // 
            this.Invoice.DataPropertyName = "Invoice";
            this.Invoice.HeaderText = "Invoice NO";
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PartyradioButton
            // 
            this.PartyradioButton.AutoSize = true;
            this.PartyradioButton.Checked = true;
            this.PartyradioButton.Location = new System.Drawing.Point(23, 13);
            this.PartyradioButton.Name = "PartyradioButton";
            this.PartyradioButton.Size = new System.Drawing.Size(49, 17);
            this.PartyradioButton.TabIndex = 1;
            this.PartyradioButton.TabStop = true;
            this.PartyradioButton.Text = "Party";
            this.PartyradioButton.UseVisualStyleBackColor = true;
            // 
            // invoiceradioButton
            // 
            this.invoiceradioButton.AutoSize = true;
            this.invoiceradioButton.Location = new System.Drawing.Point(78, 13);
            this.invoiceradioButton.Name = "invoiceradioButton";
            this.invoiceradioButton.Size = new System.Drawing.Size(60, 17);
            this.invoiceradioButton.TabIndex = 2;
            this.invoiceradioButton.TabStop = true;
            this.invoiceradioButton.Text = "Invoice";
            this.invoiceradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PartyradioButton);
            this.groupBox1.Controls.Add(this.invoiceradioButton);
            this.groupBox1.Location = new System.Drawing.Point(190, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 34);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PurchaseradioButton);
            this.groupBox2.Controls.Add(this.SellingradioButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 37);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // PurchaseradioButton
            // 
            this.PurchaseradioButton.AutoSize = true;
            this.PurchaseradioButton.Checked = true;
            this.PurchaseradioButton.Location = new System.Drawing.Point(23, 13);
            this.PurchaseradioButton.Name = "PurchaseradioButton";
            this.PurchaseradioButton.Size = new System.Drawing.Size(70, 17);
            this.PurchaseradioButton.TabIndex = 1;
            this.PurchaseradioButton.TabStop = true;
            this.PurchaseradioButton.Text = "Purchase";
            this.PurchaseradioButton.UseVisualStyleBackColor = true;
            this.PurchaseradioButton.CheckedChanged += new System.EventHandler(this.PurchaseradioButton_CheckedChanged);
            // 
            // SellingradioButton
            // 
            this.SellingradioButton.AutoSize = true;
            this.SellingradioButton.Location = new System.Drawing.Point(98, 13);
            this.SellingradioButton.Name = "SellingradioButton";
            this.SellingradioButton.Size = new System.Drawing.Size(56, 17);
            this.SellingradioButton.TabIndex = 2;
            this.SellingradioButton.Text = "Selling";
            this.SellingradioButton.UseVisualStyleBackColor = true;
            this.SellingradioButton.CheckedChanged += new System.EventHandler(this.PurchaseradioButton_CheckedChanged);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.Highlight;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(3, 3);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(84, 37);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.2F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Order_Grid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Order_details_Grid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.37113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.16495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.22004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.61493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 539);
            this.tableLayoutPanel1.TabIndex = 60;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Invoicelabel2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Partylabel1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(694, 80);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel5.TabIndex = 65;
            // 
            // Invoicelabel2
            // 
            this.Invoicelabel2.AutoSize = true;
            this.Invoicelabel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoicelabel2.Location = new System.Drawing.Point(103, 0);
            this.Invoicelabel2.Name = "Invoicelabel2";
            this.Invoicelabel2.Size = new System.Drawing.Size(68, 18);
            this.Invoicelabel2.TabIndex = 65;
            this.Invoicelabel2.Text = "Invoice";
            // 
            // Partylabel1
            // 
            this.Partylabel1.AutoSize = true;
            this.Partylabel1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partylabel1.Location = new System.Drawing.Point(3, 0);
            this.Partylabel1.Name = "Partylabel1";
            this.Partylabel1.Size = new System.Drawing.Size(53, 18);
            this.Partylabel1.TabIndex = 64;
            this.Partylabel1.Text = "Party";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53465F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46535F));
            this.tableLayoutPanel3.Controls.Add(this.SearchtextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Search, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 80);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(404, 51);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53465F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.46535F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Refresh, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Print, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(694, 141);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh.Location = new System.Drawing.Point(103, 3);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 37);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Clear";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38486F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.61514F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel6.Controls.Add(this.DateSearch, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.StartdateTimePicker, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.EnddateTimePicker, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(694, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(387, 56);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // DateSearch
            // 
            this.DateSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.DateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateSearch.Location = new System.Drawing.Point(307, 3);
            this.DateSearch.Name = "DateSearch";
            this.tableLayoutPanel6.SetRowSpan(this.DateSearch, 2);
            this.DateSearch.Size = new System.Drawing.Size(75, 32);
            this.DateSearch.TabIndex = 3;
            this.DateSearch.Text = "Search";
            this.DateSearch.UseVisualStyleBackColor = false;
            this.DateSearch.Click += new System.EventHandler(this.DateSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Start Date";
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(107, 3);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.StartdateTimePicker.TabIndex = 1;
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Location = new System.Drawing.Point(107, 31);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.EnddateTimePicker.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Order_id
            // 
            this.Order_id.DataPropertyName = "order_id";
            this.Order_id.HeaderText = "order id";
            this.Order_id.Name = "Order_id";
            this.Order_id.ReadOnly = true;
            this.Order_id.Visible = false;
            // 
            // pro_name
            // 
            this.pro_name.DataPropertyName = "ProductName";
            this.pro_name.HeaderText = "Product Name";
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // BasePrice
            // 
            this.BasePrice.DataPropertyName = "BasePrice";
            this.BasePrice.HeaderText = "Base Price";
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.ReadOnly = true;
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
            this.purchase_p.DataPropertyName = "Purchase_Price";
            this.purchase_p.HeaderText = "Price";
            this.purchase_p.Name = "purchase_p";
            this.purchase_p.ReadOnly = true;
            // 
            // pro_qty
            // 
            this.pro_qty.DataPropertyName = "Qty";
            this.pro_qty.HeaderText = "Quantity";
            this.pro_qty.Name = "pro_qty";
            this.pro_qty.ReadOnly = true;
            // 
            // qty_type
            // 
            this.qty_type.DataPropertyName = "Qty_type";
            this.qty_type.HeaderText = "Per";
            this.qty_type.Name = "qty_type";
            this.qty_type.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "ProductBrand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // Purchse_Selling_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Purchse_Selling_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchse_Selling_Orders";
            this.Load += new System.EventHandler(this.Purchse_Selling_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Order_details_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView Order_details_Grid;
        private System.Windows.Forms.DataGridView Order_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.RadioButton PartyradioButton;
        private System.Windows.Forms.RadioButton invoiceradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton PurchaseradioButton;
        private System.Windows.Forms.RadioButton SellingradioButton;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label Invoicelabel2;
        private System.Windows.Forms.Label Partylabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DateSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
    }
}