using demo.classes;
using demo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class Update_insert : Form
    {
        DBAccess objdb = new DBAccess();
        DataTable brand, quantity_type_table;
        MemoryStream ms;
        AutoCompleteStringCollection source, autotext;
        product model = new product();
        Patel_motorsEntities db = new Patel_motorsEntities();

        List<string> listOnit = new List<string>();

        List<string> listNew = new List<string>();

        byte[] photo_aray;
        public Update_insert()
        {
            InitializeComponent();

        }
        void brandcombobox()
        {
            
            foreach (DataRow item in brand.Rows)
            {
                if (!(purchase_BrandcomboBox.Items.Contains(item["company_brand"].ToString())))
                {
                    purchase_BrandcomboBox.Items.Add(item["company_brand"].ToString());
                }

            }
            // purchase_BrandcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // purchase_BrandcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        void qty_combobox()
        {
            foreach (DataRow item in quantity_type_table.Rows)
            {
                if (!(purchase_QtyTypecomboBox.Items.Contains(item["Quantity_type"].ToString())))
                {
                    purchase_QtyTypecomboBox.Items.Add(item["Quantity_type"].ToString());

                }

            }
            // purchase_QtyTypecomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // purchase_QtyTypecomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        void Populate_brand_party_ComboBox()
        {
            brand = objdb.read_adapter("select * from brand", new DataTable());

            quantity_type_table = objdb.read_adapter("select * from Quantity_Table", new DataTable());






            SqlDataReader dr = objdb.readDatathroughReader("select * from category");
            autotext = new AutoCompleteStringCollection();
            autotext.Clear();
            while (dr.Read())
            {
                autotext.Add(dr.GetString(1));
            }
            Party_name.AutoCompleteCustomSource = autotext;
            Party_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Party_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            objdb.closeConn();




            dr = objdb.readDatathroughReader("select distinct product_name  from products");
            source = new AutoCompleteStringCollection();
            source.Clear();
            listOnit.Clear();

            while (dr.Read())
            {
                source.Add(dr.GetString(0));

                listOnit.Add(dr.GetString(0));


            }
            objdb.closeConn();
            this.Purchase_namaeComboBox.Items.Clear();
            this.Purchase_namaeComboBox.Items.AddRange(listOnit.ToArray());

            Brand_name.ValueMember = "company_brand";
            Brand_name.DisplayMember = "company_brand";
            DataRow topItem_brand = brand.NewRow();
            topItem_brand[0] = 0;
            topItem_brand[1] = "-Select Brand Name-";
            brand.Rows.InsertAt(topItem_brand, 0);
            Brand_name.DataSource = brand;
            //this for individiual  combobox brand





            Quantity_type.ValueMember = "Quantity_type";
            Quantity_type.DisplayMember = "Quantity_type";
            DataRow quantity_type = quantity_type_table.NewRow();
            quantity_type[0] = 0;
            quantity_type[1] = "-Select Quantity type -";
            quantity_type_table.Rows.InsertAt(quantity_type, 0);
            Quantity_type.DataSource = quantity_type_table;
            //this for individiual  combobox qty type



        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dgc = dataGridView1.CurrentRow;
                if (dgc.Cells["gst"].Value != null && dgc.Cells["Basic_price"] != null)
                {
                    decimal a = (Convert.ToDecimal(dgc.Cells["Basic_price"].Value.ToString()) / 100) * Convert.ToDecimal(dgc.Cells["gst"].Value.ToString());
                    dgc.Cells["purchase_price"].Value = (a + (Convert.ToDecimal(dgc.Cells["Basic_price"].Value.ToString()))).ToString();

                    //dgc.Cells["purchase_price"].Value = (a+Convert.ToUInt32(dgc.Cells["Basic_price"].Value)).ToString();
                }


            }
            DataGridViewRow item = dataGridView1.CurrentRow;
            if (dataGridView1.CurrentRow != null && item.Cells[1].Value != null && item.Cells["Brand_name"].Value != null && item.Cells["Purchase_price"].Value != null && (dataGridView1.CurrentCell.ColumnIndex == 1
                || dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 9))
            {

                if (objdb.product_exist(item.Cells["Product_name"].Value.ToString(), item.Cells["Brand_name"].Value == DBNull.Value || item.Cells["Brand_name"].Value == null ? "local brand" : item.Cells["Brand_name"].Value.ToString(), item.Cells["Purchase_price"].Value == DBNull.Value || item.Cells["Purchase_price"].Value == null ? "0" : item.Cells["Purchase_price"].Value.ToString()))
                {
                    if (MessageBox.Show("this party is wanting more money for this " + item.Cells["Product_name"].Value.ToString() + "\n if you want to cancel this product  then click ok", "Purchase info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {


                    }
                    // model = db.products.SqlQuery("select * from products where purchase_price=(select Min(purchase_price) from products where product_name=@product) ", new SqlParameter("@product", item.Cells[1].Value.ToString())).FirstOrDefault();
                    model = db.products.SqlQuery("select * from products where purchase_price=(select Min(purchase_price) from products where product_name=@product and brand=@pro_brand)", new SqlParameter("@product", item.Cells[1].Value.ToString()), new SqlParameter("@pro_brand", item.Cells["Brand_name"].Value.ToString())).FirstOrDefault();
                    info.Text = "Party Name: '" + model.product_category.ToString() + "' is giving you this \n Same product :'" + model.product_name + "'  \n in '" + model.purchase_price.ToString() + "' \n and  Brand Name is : '" + model.brand.ToString() + "' ";
                }
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.ColumnIndex == 7)
            //{

            //    add_button();
            //}
            if (e.ColumnIndex == 10)
            {
                Get_img();
            }


        }

        private void allowNumonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;
        }
        private void my_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;


            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            e.Control.KeyPress -= new KeyPressEventHandler(allowNumonly);
            if (dataGridView1.CurrentCell.ColumnIndex == 5) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(allowNumonly);
                }
            }

            e.Control.KeyPress -= new KeyPressEventHandler(my_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 8 || dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(my_KeyPress);
                }
            }





            if (dataGridView1.CurrentCell.ColumnIndex == 6 || dataGridView1.CurrentCell.ColumnIndex == 9)
            {
                ComboBox ctl = e.Control as ComboBox;
                ctl.Enter -= new EventHandler(ctl_Enter);
                ctl.Enter += new EventHandler(ctl_Enter);
                if (ctl != null)
                {
                    ctl.SelectedIndex = 0;
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {


                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    prodCode.AutoCompleteCustomSource = source;
                    prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
                else
                    prodCode.AutoCompleteCustomSource = null;
            }
            else
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.None;
                }
            }



        }

        void ctl_Enter(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }


        //private void add_button()
        //{
        //    DataGridViewRow dgvRow = dataGridView1.CurrentRow;
        //    if (dataGridView1.CurrentRow != null)
        //    {






        //        if (dgvRow.Cells["Product_name"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter product name", "enter Product Name ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Product_name"].Selected = true;
        //            }
        //        }
        //        else if (dgvRow.Cells["Purchase_price"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter Purchase price", "enter Purchase price ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Purchase_price"].Selected = true;
        //            }
        //        }
        //        else if (dgvRow.Cells["Product_quantity"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter product Quantity", "enter Product Quantity ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Product_quantity"].Selected = true;
        //            }
        //        }
        //        else if (dgvRow.Cells["Selling_price"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter Selling price", "enter selling price ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Selling_price"].Selected = true;
        //            }
        //        }
        //        else if (dgvRow.Cells["Party_name"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter Party Name", "Enter party name  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Party_name"].Selected = true;
        //            }
        //        }
        //        else if (dgvRow.Cells["Brand_name"].Value == null)//Insert
        //        {
        //            if (MessageBox.Show("Please enter Brand name", "Enter Brand name  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //            {
        //                dgvRow.Cells["Brand_name"].Selected = true;
        //            }
        //        }



        //        else//update
        //        {
        //            if (objdb.product_exist(dgvRow.Cells["Product_name"].Value.ToString(), dgvRow.Cells["Brand_name"].Value == DBNull.Value ? "local brand" : dgvRow.Cells["Brand_name"].Value.ToString(), dgvRow.Cells["Party_name"].Value.ToString(), dgvRow.Cells["Purchase_price"].Value == DBNull.Value ? "0" : dgvRow.Cells["Purchase_price"].Value.ToString(), dgvRow.Cells["Selling_price"].Value == DBNull.Value ? "0" : dgvRow.Cells["Selling_price"].Value.ToString(), dgvRow.Cells["Product_quantity"].Value == null ? "0" : dgvRow.Cells["Product_quantity"].Value.ToString(),))
        //            {
        //                MessageBox.Show("product already exist");
        //            }
        //            else
        //            {
        //                SqlCommand sqlCmd;
        //                if (dataGridView1.CurrentRow != null && pictureBox1.Image != null)
        //                {
        //                    sqlCmd = new SqlCommand("insert into products(product_name,purchase_price,sell_price,product_quantity,product_category,product_img,brand) values(@PN,@PP,@SP,@Qty,@Party,@photo,@Brand)");
        //                    ms = new MemoryStream();
        //                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
        //                    byte[] photo_aray = new byte[ms.Length];
        //                    ms.Position = 0;
        //                    ms.Read(photo_aray, 0, photo_aray.Length);
        //                    sqlCmd.Parameters.AddWithValue("@photo", photo_aray);


        //                }
        //                else
        //                {
        //                    sqlCmd = new SqlCommand("insert into products(product_name,purchase_price,sell_price,product_quantity,product_category,brand) values(@PN,@PP,@SP,@Qty,@Party,@Brand)");
        //                }


        //                sqlCmd.Parameters.AddWithValue("@PN", dgvRow.Cells["Product_name"].Value == null ? "Not mentioned" : dgvRow.Cells["Product_name"].Value.ToString());
        //                sqlCmd.Parameters.AddWithValue("@PP", dgvRow.Cells["Purchase_price"].Value == null ? "0" : dgvRow.Cells["Purchase_price"].Value.ToString());
        //                sqlCmd.Parameters.AddWithValue("@Party", dgvRow.Cells["Party_name"].Value == null ? "local party" : dgvRow.Cells["Party_name"].Value.ToString());
        //                sqlCmd.Parameters.AddWithValue("@Brand", dgvRow.Cells["Brand_name"].Value == null ? "local brand" : dgvRow.Cells["Brand_name"].Value.ToString());
        //                sqlCmd.Parameters.AddWithValue("@Qty", dgvRow.Cells["Product_quantity"].Value == null ? "0" : dgvRow.Cells["Product_quantity"].Value.ToString());
        //                sqlCmd.Parameters.AddWithValue("@SP", dgvRow.Cells["Selling_price"].Value == null ? "0" : dgvRow.Cells["Selling_price"].Value.ToString());



        //                int i = objdb.executeQuery(sqlCmd);
        //                if (i == 1)
        //                {
        //                    dataGridView1.Rows.RemoveAt(dgvRow.Index);
        //                    pictureBox1.Image = null;

        //                }

        //            }

        //        }

        //    }
        //}
        private void Get_img()
        {

            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        DataGridViewRow dgvRow = dataGridView1.CurrentRow;

                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        dgvRow.Cells["Up_img"].Value = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message, "File Already exits");
            }

        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            var cell = this.dataGridView1.CurrentCell;

            if (e.KeyCode == Keys.A && e.Shift && cell.ColumnIndex == 10)
            {

                Get_img();

            }
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }
        void OrderDetails()
        {//purchse order id and details storing in this process
            Purchase_orders Purchase_Orders_model = new Purchase_orders();


            Purchase_Orders_model.PartyName = Party_name.Text;
            Purchase_Orders_model.Invoice = invoice.Text;
            Purchase_Orders_model.Date = DateTime.Now.ToString("dd/ MM / yyyy");
            db.Purchase_orders.Add(Purchase_Orders_model);//for latest purchase order id adding new record 
            //db.Purchase_orders.SqlQuery("insert into purchase_orders(PartyName,Invoice,Date) values(@party,@invoice,@date)", new SqlParameter("@party", Party_name.Text), new SqlParameter("@invoice", invoice.Text), new SqlParameter("@date", DateTime.Now.ToString("dd/ MM / yyyy")));

            db.SaveChanges();
            var order_id = db.Purchase_orders.OrderByDescending(x => x.order_id).First();//taking latest record 
            //var order_id = db.Purchase_orders.SqlQuery("select order_id from purchase_orders order by order_id desc ");
            //now adding order details with corresponding order id
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {




                if (item.Cells[1].Value != null && item.Cells[2].Value != null && item.Cells[3].Value != null)
                {
                    Purchse_OrderDetails Purchse_OrderDetails_model = new Purchse_OrderDetails();
                    Purchse_OrderDetails_model.order_id = Convert.ToInt32(order_id.order_id);
                    Purchse_OrderDetails_model.ProductName = item.Cells["Product_name"].Value.ToString();
                    Purchse_OrderDetails_model.Gst = Convert.ToDouble(item.Cells["gst"].Value);
                    Purchse_OrderDetails_model.Qty_type = item.Cells["Quantity_type"].Value.ToString();
                    Purchse_OrderDetails_model.Qty = Convert.ToDecimal(item.Cells["Product_quantity"].Value);
                    Purchse_OrderDetails_model.ProductBrand = item.Cells["Brand_name"].Value.ToString();
                    Purchse_OrderDetails_model.Purchase_Price = Convert.ToDecimal(item.Cells["Purchase_price"].Value);
                    Purchse_OrderDetails_model.discount = Convert.ToDouble(item.Cells["discount_grid1"].Value == null ? "0" : item.Cells["discount_grid1"].Value);
                    Purchse_OrderDetails_model.BasePrice = Convert.ToDecimal(item.Cells["Basic_price"].Value);
                    db.Purchse_OrderDetails.Add(Purchse_OrderDetails_model);

                }



            }
            db.SaveChanges();

        }
        private void add_records_Click(object sender, EventArgs e)
        {

            if (Party_name.Text.Trim() == null || Party_name.Text == "" || string.IsNullOrWhiteSpace(Party_name.Text))
            {
                if (MessageBox.Show("please select or enter  party name", "party name", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Party_name.Focus();
                }

            }

            else if (invoice.Text.Trim() == null || invoice.Text == "" || string.IsNullOrWhiteSpace(invoice.Text))
            {
                if (MessageBox.Show("please enter invoice number", "invoice Number ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    invoice.Focus();
                }

            }
            else
            {
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
                {//order details thread
                    Thread order = new Thread(OrderDetails);

                    order.Start();






                    foreach (DataGridViewRow item in this.dataGridView1.Rows)
                    {
                        int n = item.Index;

                        SqlCommand sqlCmd;
                        if (dataGridView1.Rows[n].Cells["Up_img"].Value != null)
                        {
                            sqlCmd = new SqlCommand("insert into products(product_name,purchase_price,sell_price,product_quantity,product_category,product_img,brand,MRP,invoice,Gst,base_price,Quantity_type) values(@PN,@PP,@SP,@Qty,@Party,@photo,@Brand,@Mrp,@invoice,@Gst,@Base_price,@Quantity_type)");
                            Image img = Image.FromFile(dataGridView1.Rows[n].Cells["Up_img"].Value.ToString());
                            var ms = new MemoryStream();
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            var photo_aray = ms.ToArray();

                            sqlCmd.Parameters.AddWithValue("@photo", photo_aray);


                        }
                        else
                        {
                            sqlCmd = new SqlCommand("insert into products(product_name,purchase_price,sell_price,product_quantity,product_category,brand,MRP,invoice,Gst,base_price,Quantity_type) values(@PN,@PP,@SP,@Qty,@Party,@Brand,@Mrp,@invoice,@Gst,@Base_price,@Quantity_type)");
                        }

                        if (item.Cells[1].Value != null && item.Cells[2].Value != null && item.Cells[3].Value != null)
                        {
                            // increamenting qty when records are same in list
                            if (objdb.product_exist(item.Cells["Product_name"].Value.ToString(), item.Cells["Brand_name"].Value == DBNull.Value || item.Cells["Brand_name"].Value == null ? "local brand" : item.Cells["Brand_name"].Value.ToString(), Party_name.Text == null || Party_name.Text == "" ? "local" : Party_name.Text, item.Cells["Purchase_price"].Value == DBNull.Value || item.Cells["Purchase_price"].Value == null ? "0" : item.Cells["Purchase_price"].Value.ToString(), item.Cells["Selling_price"].Value == DBNull.Value || item.Cells["Selling_price"].Value == null ? "0" : item.Cells["Selling_price"].Value.ToString(), item.Cells["Product_quantity"].Value == null ? "0" : item.Cells["Product_quantity"].Value.ToString()
                                , invoice.Text == null || invoice.Text == "" ? "0" : invoice.Text))
                            {
                                // MessageBox.Show("product already exist");
                                continue;
                            }


                            else
                            {
                                //updating info if same record exist in database(stock ) 
                                if (objdb.product_exist_changing_stock_quantity(item.Cells["Product_name"].Value.ToString(), item.Cells["Brand_name"].Value.ToString(), Party_name.Text.Trim().ToUpper(), item.Cells["Product_quantity"].Value.ToString(), item.Cells["Purchase_price"].Value.ToString(), item.Cells["Selling_price"].Value.ToString(), item.Cells["basic_price"].Value.ToString(), item.Cells["gst"].Value.ToString(), item.Cells["mrp"].Value.ToString()))
                                {
                                    continue;

                                }




                                lock (this)
                                {
                                    sqlCmd.Parameters.AddWithValue("@PN", item.Cells["Product_name"].Value == null ? "Not mentioned" : item.Cells["Product_name"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@PP", item.Cells["Purchase_price"].Value == null ? "0" : item.Cells["Purchase_price"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@Party", Party_name.Text == null || Party_name.Text == "" ? "local" : Party_name.Text.Trim().ToUpper());
                                    sqlCmd.Parameters.AddWithValue("@Brand", item.Cells["Brand_name"].Value == null ? "local brand" : item.Cells["Brand_name"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@Qty", item.Cells["Product_quantity"].Value == null ? "0" : item.Cells["Product_quantity"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@SP", item.Cells["Selling_price"].Value == null ? "0" : item.Cells["Selling_price"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@invoice", invoice.Text == null || invoice.Text == "" ? "0" : invoice.Text);
                                    sqlCmd.Parameters.AddWithValue("@Gst", item.Cells["gst"].Value == null ? "0" : item.Cells["gst"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@Base_price", item.Cells["basic_price"].Value == null ? "0" : item.Cells["basic_price"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@Quantity_type", item.Cells["Quantity_type"].Value == null ? "0" : item.Cells["Quantity_type"].Value.ToString());
                                    sqlCmd.Parameters.AddWithValue("@Mrp", item.Cells["mrp"].Value == null ? "0" : item.Cells["mrp"].Value.ToString());



                                    int i = objdb.executeQuery(sqlCmd);

                                }


                            }
                        }



                    }

                    if (Party_name.Text != "" && Party_name != null && !(autotext.Contains(Party_name.Text)))
                    {
                        SqlCommand sqlCmd = new SqlCommand("insert into category(category) values(@cat)");

                        sqlCmd.Parameters.AddWithValue("@cat", Party_name.Text);
                        objdb.executeQuery(sqlCmd);
                    }
                    order.Join();
                }

                Thread individualcobrand = new Thread(() =>
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        brandcombobox();
                    });
                });
                //Thread individualcobrand = new Thread(brandcombobox);

                individualcobrand.Start();

                Thread individualcoQty = new Thread(() =>
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        qty_combobox();
                    });
                });
                //Thread individualcoQty = new Thread(qty_combobox);
                individualcoQty.Start();

                buttonRefresh.PerformClick();
            }



        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["Sno"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentCell.ColumnIndex.ToString());
            // MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString());
        }

        private void Party_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void invoice_TextChanged(object sender, EventArgs e)
        {
            invoice.Focus();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Populate_brand_party_ComboBox();
            brandcombobox();
            dataGridView1.Rows.Clear();
            Party_name.Text = "";
            invoice.Text = "";
            purchaseResetContol();
            Party_name.Focus();
        }

        private void general_keypress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;


            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void addlist_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                double floatgst = Convert.ToDouble(purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text);
                double floatdiscount = Convert.ToDouble(purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text);
                if ((Purchase_namaeComboBox.SelectedItem == null || Purchase_namaeComboBox.SelectedItem.ToString() == "Product does not exist") && (Purchase_namaeComboBox.Text == string.Empty || Purchase_namaeComboBox.Text == "" || Purchase_namaeComboBox.Text.Trim() == "Product does not exist") || String.IsNullOrWhiteSpace(Purchase_namaeComboBox.Text))
                {
                    Purchase_namaeComboBox.Focus();
                    MessageBox.Show("Product Name is requierd");


                }
                else if (purchase_BrandcomboBox.SelectedItem == null || purchase_BrandcomboBox.SelectedItem.ToString() == "-Select Brand Name-")
                {
                    purchase_BrandcomboBox.Focus();
                    MessageBox.Show("Please choose Brand");
                }
                //For combobox validation we should follow the below code.
                else if (purchase_QtyTypecomboBox.SelectedItem == null || purchase_QtyTypecomboBox.SelectedItem.ToString() == "-Select Quantity type -")
                {
                    purchase_QtytextBox.Focus();
                    MessageBox.Show("Select Quantity Type");
                }
                else if (purchase_BasePricetextBox.Text == "" || purchase_BasePricetextBox.Text == string.Empty || string.IsNullOrWhiteSpace(purchase_BasePricetextBox.Text))
                {
                    purchase_BasePricetextBox.Focus();
                    MessageBox.Show("Please enter base Price");
                }
                else if (floatgst > 100)
                {
                    MessageBox.Show("Please enter valid info of gst");
                    purchase_GsttextBox.Focus();
                }
                else if (floatdiscount > 100)
                {
                    MessageBox.Show("Please enter valid info of discount");
                    discounttextBox.Focus();
                }
                else
                {

                    if (Purchase_namaeComboBox.SelectedItem == null)
                    {
                        if (Purchase_namaeComboBox.Text != string.Empty || Purchase_namaeComboBox.Text != "")
                        {
                            name = Purchase_namaeComboBox.Text;
                        }

                    }
                    else if (Purchase_namaeComboBox.SelectedItem != null)
                    {


                        name = Purchase_namaeComboBox.SelectedItem.ToString();
                    }
                    if (name == "Product does not exist")
                    {
                        name = Purchase_namaeComboBox.Text;
                    }
                    //decimal a = (Convert.ToDecimal(purchase_BasePricetextBox.Text) / 100) * Convert.ToDecimal(purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text);
                    //purchase_PurchasePricetextBox.Text = (a + (Convert.ToDecimal(purchase_BasePricetextBox.Text))).ToString();
                    discount();
                    decimal a = (Convert.ToDecimal(purchase_PurchasePricetextBox.Text) / 100) * Convert.ToDecimal(purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text);
                    purchase_PurchasePricetextBox.Text = (a + (Convert.ToDecimal(purchase_PurchasePricetextBox.Text))).ToString();


                    checking_partyprice(name);
                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 2;
                    dataGridView1["Product_name", row].Value = name.Trim().ToLower();
                    dataGridView1["basic_price", row].Value = purchase_BasePricetextBox.Text;
                    dataGridView1["gst", row].Value = purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text;
                    dataGridView1["Purchase_price", row].Value = purchase_PurchasePricetextBox.Text;

                    dataGridView1["Product_quantity", row].Value = purchase_QtytextBox.Text == "" ? "1" : purchase_QtytextBox.Text;
                    dataGridView1["Selling_price", row].Value = purchase_SellingPricetextBox.Text == "" ? purchase_PurchasePricetextBox.Text : purchase_SellingPricetextBox.Text;


                    dataGridView1["Quantity_type", row].Value = purchase_QtyTypecomboBox.SelectedItem.ToString();
                    dataGridView1["mrp", row].Value = purchase_MrptextBox.Text == "" ? purchase_PurchasePricetextBox.Text : purchase_MrptextBox.Text;
                    dataGridView1["Brand_name", row].Value = purchase_BrandcomboBox.SelectedItem.ToString();
                    dataGridView1["discount_grid1", row].Value = discounttextBox.Text == "" ? "0" : discounttextBox.Text;

                    if (model != null)
                    {
                        if (model.id > 0 && model.product_name != null && model != null)
                        {
                            if (model.product_name.ToString() ==name && model.product_category.ToString() == Party_name.Text.ToString())
                            {
                                dataGridView1["Up_img", row].Value = model.product_img;
                                dataGridView1["product_id", row].Value = model.id;
                            }
                            else if (model.product_name.ToString() == name)
                            {
                                dataGridView1["Up_img", row].Value = model.product_img;
                            }

                        }

                    }

                    //reset all control
                    purchaseResetContol();
                    // Purchase_namaeComboBox.Focus();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("invalid Entry");
            }



        }

        void purchaseResetContol()
        {//Reset all control after adding record
            model = null;
            Purchase_namaeComboBox.Text = "";
            Purchase_namaeComboBox.SelectedItem = null;
            purchase_BasePricetextBox.Text = "";
            purchase_PurchasePricetextBox.Text = "";
            purchase_QtytextBox.Text = "";
            discounttextBox.Text = "";
            purchase_GsttextBox.Text = "";
            purchase_QtyTypecomboBox.SelectedItem = "-Select Quantity type -";
            purchase_SellingPricetextBox.Text = "";
            purchase_BrandcomboBox.SelectedItem = "-Select Brand Name-";
            purchase_MrptextBox.Text = "";
        }
        void checking_partyprice(string name)
        {
            if (objdb.product_exist(name, purchase_BrandcomboBox.SelectedItem.ToString(), purchase_PurchasePricetextBox.Text))
            {
                if (MessageBox.Show("this party is wanting more money for this " + name + "\n if you want to view details then click ok", "Purchase info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    model = null;
                    model = objdb.product_exist_msg(name, purchase_BrandcomboBox.SelectedItem.ToString());

                    info.Text = "Party Name: '" + model.product_category.ToString() + "' is giving you this \n Same product :'" + model.product_name + "'  \n in '" + model.purchase_price.ToString() + "' \n and  Brand Name is : '" + model.brand.ToString() + "' ";

                }
                else
                    info.Text = "INFO";
                // model = db.products.SqlQuery("select * from products where purchase_price=(select Min(purchase_price) from products where product_name=@product) ", new SqlParameter("@product", item.Cells[1].Value.ToString())).FirstOrDefault();
                //model = db.products.SqlQuery("select * from products where purchase_price=(select Min(purchase_price) from products where product_name=@product and brand=@pro_brand)", new SqlParameter("@product", Purchase_namaeComboBox.SelectedItem.ToString()), new SqlParameter("@pro_brand", purchase_BrandcomboBox.SelectedItem.ToString())).FirstOrDefault();
            }
        }
        private void purchase_nametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Party_name.Text != "" && Party_name.Text != null && Purchase_namaeComboBox.SelectedItem != null)
                {
                    model = db.products.SqlQuery("select * from products where product_name=@product and product_category=@cat", new SqlParameter("@product", Purchase_namaeComboBox.SelectedItem.ToString()), new SqlParameter("@cat", Party_name.Text)).FirstOrDefault();
                    if (model == null)
                    {

                        model = db.products.SqlQuery("select * from products where product_name=@product", new SqlParameter("@product", Purchase_namaeComboBox.SelectedItem.ToString())).FirstOrDefault();

                    }
                }
                else if (Purchase_namaeComboBox.SelectedItem != null)
                {
                    model = db.products.SqlQuery("select * from products where product_name=@product", new SqlParameter("@product", Purchase_namaeComboBox.SelectedItem.ToString())).FirstOrDefault();

                }
                if (model != null && model.product_name != null)
                {
                    purchase_BasePricetextBox.Text = model.base_price.ToString();
                    purchase_PurchasePricetextBox.Text = model.purchase_price.ToString();
                    purchase_QtytextBox.Text = "1";
                    purchase_GsttextBox.Text = model.Gst.ToString();
                    purchase_QtyTypecomboBox.SelectedItem = model.Quantity_type.ToString();
                    purchase_SellingPricetextBox.Text = model.sell_price.ToString();
                    purchase_BrandcomboBox.SelectedItem = model.brand;
                    purchase_MrptextBox.Text = model.MRP.ToString();
                    addlist_button.Focus();

                }
                else { purchase_BasePricetextBox.Focus(); }


            }
            //if (e.KeyCode.Equals(Keys.Left))
            //{
            //    string abc = null;
            //    if (sender is TextBox)
            //    {
            //        abc = (sender as TextBox).Name.ToString();
            //    }
            //    else if (sender is ComboBox)
            //    {
            //        abc = (sender as ComboBox).Name.ToString();
            //    }
            //    else if (sender is Button)
            //    {
            //        abc = (sender as Button).Name.ToString();
            //    }

            //    arrows(abc);

            //}
            //if (e.KeyCode.Equals(Keys.Right))
            //{
            //    SendKeys.Send("{TAB}");
            //}

        }

        private void forpurchase_pricdkeydown(object sender, KeyEventArgs e)
        {
            if (purchase_BasePricetextBox.Text != string.Empty && purchase_BasePricetextBox.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)/*((sender as TextBox).Name == "purchase_BasePricetextBox"|| (sender as TextBox).Name == "discounttextBox")*/)
            {
                discount();

            }

            if (purchase_BasePricetextBox.Text != "" && purchase_BasePricetextBox.Text != string.Empty && purchase_PurchasePricetextBox.Text != "" && purchase_PurchasePricetextBox.Text != string.Empty && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                decimal a = (Convert.ToDecimal(purchase_PurchasePricetextBox.Text) / 100) * Convert.ToDecimal(purchase_GsttextBox.Text == "" ? "0" : purchase_GsttextBox.Text);
                purchase_PurchasePricetextBox.Text = (a + (Convert.ToDecimal(purchase_PurchasePricetextBox.Text))).ToString();
                string namecontrol = (sender as TextBox).Name.ToString();

                if (e.KeyCode == Keys.Enter)
                {

                    switch (namecontrol)
                    {
                        case "purchase_BasePricetextBox":
                            if (discounttextBox.Text == "")
                            {
                                discounttextBox.Focus();
                            }
                            else
                            {
                                purchase_GsttextBox.Focus();
                            }
                            break;
                        case "discounttextBox":
                            if (purchase_GsttextBox.Text == "")
                            {
                                purchase_GsttextBox.Focus();
                            }
                            else
                            {
                                purchase_QtytextBox.Focus();
                            }
                            break;
                        case "purchase_GsttextBox":
                            purchase_QtytextBox.Focus();
                            break;
                        default:
                            break;
                    }


                }

            }
            //if (e.KeyCode.Equals(Keys.Right))
            //{
            //    SendKeys.Send("{TAB}");
            //}
            //if (e.KeyCode.Equals(Keys.Left))
            //{
            //    string abc = null;
            //    if (sender is TextBox)
            //    {
            //        abc = (sender as TextBox).Name.ToString();
            //    }
            //    else if (sender is ComboBox)
            //    {
            //        abc = (sender as ComboBox).Name.ToString();
            //    }
            //    else if (sender is Button)
            //    {
            //        abc = (sender as Button).Name.ToString();
            //    }

            //    arrows(abc);


            //}

        }

        private void combobox_dropdown(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
            if ((sender as ComboBox).Items.Count > 0)
            {
                (sender as ComboBox).SelectedIndex = 0;
            }

        }

        private void general_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter /*|| e.KeyCode.Equals(Keys.Right)*/)
            {
                SendKeys.Send("{TAB}");
            }
            //if (e.KeyCode.Equals(Keys.Left))
            //{
            //    string abc = null;
            //    if (sender is TextBox)
            //    {
            //        abc = (sender as TextBox).Name.ToString();
            //    }
            //    else if (sender is ComboBox)
            //    {
            //        abc = (sender as ComboBox).Name.ToString();
            //    }
            //    else if (sender is Button)
            //    {
            //        abc = (sender as Button).Name.ToString();
            //    }

            //    arrows(abc);


            //}
        }
        void arrows(string abc)
        {
            switch (abc)
            {
                case "purchase_PurchasePricetextBox":
                    purchase_GsttextBox.Focus();
                    break;
                case "purchase_GsttextBox":
                    purchase_BasePricetextBox.Focus();
                    break;
                case "purchase_BasePricetextBox":
                    Purchase_namaeComboBox.Focus();
                    break;
                case "purchase_QtytextBox":
                    purchase_PurchasePricetextBox.Focus();
                    break;

                case "purchase_QtyTypecomboBox":
                    purchase_QtytextBox.Focus();
                    break;
                case "purchase_SellingPricetextBox":
                    purchase_QtyTypecomboBox.Focus();
                    break;
                case "purchase_MrptextBox":
                    purchase_SellingPricetextBox.Focus();
                    break;
                case "purchase_BrandcomboBox":
                    purchase_MrptextBox.Focus();
                    break;
                case "addlist_button":
                    purchase_BrandcomboBox.Focus();
                    break;
                default:
                    break;
            }
        }



        private void Update_insert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Purchase_namaeComboBox_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                this.Purchase_namaeComboBox.Items.Clear();
                listNew.Clear();
                foreach (var item in listOnit)
                {
                    if (item.Contains(this.Purchase_namaeComboBox.Text))
                    {
                        listNew.Add(item);

                    }


                }
                if (!(listNew.Count > 0))
                {
                    listNew.Add("Product does not exist");
                }
                this.Purchase_namaeComboBox.Items.AddRange(listNew.ToArray());
                this.Purchase_namaeComboBox.SelectionStart = this.Purchase_namaeComboBox.Text.Length;
                Cursor = Cursors.Default;
                this.Purchase_namaeComboBox.DroppedDown = true;





            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Entry");
            }

        }
        void dropclose()
        {
            if (Purchase_namaeComboBox.SelectedItem == null)
            {
                Purchase_namaeComboBox.DroppedDown = false;


            }
        }


        void discount()
        {

            decimal a = Convert.ToDecimal(purchase_BasePricetextBox.Text) * Convert.ToDecimal(discounttextBox.Text == "" ? "0" : discounttextBox.Text) / 100;
            purchase_PurchasePricetextBox.Text = (Convert.ToDecimal(purchase_BasePricetextBox.Text) - a).ToString();


        }
       void brandcombobox_active()
        {
            DataTable brand1 = new DataTable();
            brand1 = objdb.read_adapter("select * from brand", new DataTable());
            if (brand1!=null)
            {
                foreach (DataRow item in brand1.Rows)
                {
                    if (!(purchase_BrandcomboBox.Items.Contains(item["company_brand"].ToString())))
                    {
                        purchase_BrandcomboBox.Items.Add(item["company_brand"].ToString());
                    }

                }
            }
            

        }
        private void Update_insert_Activated(object sender, EventArgs e)
        {
          
            brandcombobox_active();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 6 || dataGridView1.CurrentCell.ColumnIndex == 9)
            {
                if (e.KeyCode == Keys.Enter && e.Alt)
                {
                    //don't add text if it's empty
                    //if (comboBox1.Text != "")
                    //{
                    //    for (int i = 0; i < comboBox1.Items.Count; i++)
                    //    {
                    //        //exit event if text already exists
                    //        if (comboBox1.Text == comboBox1.Items[i].ToString())
                    //        {
                    //            return;
                    //        }
                    //    }
                    //    //add item to comboBox1
                    //    comboBox1.Items.Add(comboBox1.Text);
                    //}
                }
            }
        }



        private void Update_insert_Load(object sender, EventArgs e)
        {
            Populate_brand_party_ComboBox();
            Thread individualcomboboxbrand = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    brandcombobox();
                });
            });
            individualcomboboxbrand.Start();
            Thread individualcomboboxQty = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    qty_combobox();
                });
            });
            individualcomboboxQty.Start();

            // Populate_brand_party_ComboBox();

            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
