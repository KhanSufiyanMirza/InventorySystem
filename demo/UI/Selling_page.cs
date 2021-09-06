using demo.classes;
using demo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class Selling_page : Form
    {
        selling_product_table sellTable = new selling_product_table();
        product model = new product();
        Patel_motorsEntities pateldb = new Patel_motorsEntities();
        string invoice;
        private int product_checking_id = 0;
        Dictionary<int, decimal> dict = new Dictionary<int, decimal>();





        DBAccess objdb = new DBAccess();
        DataTable brand, product_details;
        SqlCommand sqlCmd;

        AutoCompleteStringCollection product_suggest, autotext;
        DataTable dtLocalC;
        List<string> listOnit = new List<string>();

        List<string> listNew = new List<string>();


        public Selling_page()
        {
            InitializeComponent();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }
        void populate_product_party1()
        {
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
        }
        void Populate_product_party_()
        {





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




            dr = objdb.readDatathroughReader("select distinct product_name from products");
            product_suggest = new AutoCompleteStringCollection();
            product_suggest.Clear();

            while (dr.Read())
            {
                product_suggest.Add(dr.GetString(0));
                if (!(listOnit.Contains(dr.GetString(0))))
                {
                    listOnit.Add(dr.GetString(0));
                }


            }
            objdb.closeConn();

            this.Purchase_namaeComboBox.Items.Clear();
            this.Purchase_namaeComboBox.Items.AddRange(listOnit.ToArray());

        }
        private void Selling_page_Load(object sender, EventArgs e)
        {

            //Thread populate = new Thread(Populate_product_party_);
            //populate.Start();
            Populate_product_party_();
            //reportin datatable
            dtLocalC = new DataTable();
            dtLocalC.Columns.Add("Product Name");

            dtLocalC.Columns.Add("GST");
            dtLocalC.Columns.Add("Quantity", typeof(decimal));
            dtLocalC.Columns.Add("Rate", typeof(decimal));
            dtLocalC.Columns.Add("Per");
            dtLocalC.Columns.Add("Discount");
            //grid design
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2_RutimeSelling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2_RutimeSelling.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2_RutimeSelling.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(my_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 12 || dataGridView1.CurrentCell.ColumnIndex == 8) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(my_KeyPress);
                }
            }




        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["Sno"].Value = (e.RowIndex + 1).ToString();
        }
        private void read_productPurchaseprice()
        {

            if (Selling_BrandcomboBox.SelectedItem != null && Purchase_namaeComboBox.SelectedItem != null)
            {
                brand = objdb.read_adapter_sell_purchase("select distinct purchase_price from products where product_name=@gen and brand=@brand ", Purchase_namaeComboBox.SelectedItem.ToString(), Selling_BrandcomboBox.SelectedItem.ToString(), new DataTable());


                Selling_PurchasePricecomboBox.Items.Clear();



                foreach (DataRow row in brand.Rows)
                {
                    if (!(Selling_PurchasePricecomboBox.Items.Contains(row["purchase_price"].ToString())))
                    {
                        Selling_PurchasePricecomboBox.Items.Add(row["purchase_price"].ToString());
                    }




                }




            }
        }
        private void read_productpro()
        {
            DataGridViewRow dgc = dataGridView1.CurrentRow;
            if (Purchase_namaeComboBox.SelectedItem != null)
            {
                brand = objdb.read_adapter_sell("select distinct brand from products where product_name=@gen", Purchase_namaeComboBox.SelectedItem.ToString(), new DataTable());


                Selling_BrandcomboBox.Items.Clear();



                foreach (DataRow row in brand.Rows)
                {
                    if (!(Selling_BrandcomboBox.Items.Contains(row["brand"].ToString())))
                    {
                        Selling_BrandcomboBox.Items.Add(row["brand"].ToString());
                    }




                }




            }
        }

        private void read_pro()
        {
            DataGridViewRow dgc = dataGridView1.CurrentRow;
            if (dgc.Cells["Product_name"].Value != null)
            {
                brand = objdb.read_adapter_sell("select distinct brand,purchase_price from products where product_name=@gen", dgc.Cells["Product_name"].Value.ToString(), new DataTable());


                //DataGridViewComboBoxCell cp = new DataGridViewComboBoxCell();
                // DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[dgc.Index].Cells[2];

                DataGridViewComboBoxCell cpp = (DataGridViewComboBoxCell)dataGridView1.Rows[dgc.Index].Cells[3];
                if (cpp.Items.Count > 0)
                {
                    for (int i = 1; i < cpp.Items.Count; i++)
                    {
                        cpp.Items.RemoveAt(i);
                    }
                }
                if (cb.Items.Count > 0)
                {
                    for (int i = 1; i < cb.Items.Count; i++)
                    {
                        cb.Items.RemoveAt(i);
                    }
                }

                foreach (DataRow row in brand.Rows)
                {
                    if (cb.Items.Contains(row["brand"].ToString()) && cpp.Items.Contains(row["purchase_price"].ToString()))
                    {

                    }
                    else
                    {
                        cb.Items.Add(row["brand"].ToString());

                        cpp.Items.Add(row["purchase_price"].ToString());
                    }



                }


                //dgc.Cells["Brand_name"].Value = cb;
                //dgc.Cells["party_g1"].Value = cp;
                //Brand_name.DisplayMember = "brand";
                //Brand_name.ValueMember = "brand";

            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentCell.ColumnIndex.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        /*
                private void print_priview_Click(object sender, EventArgs e)
                {
                    PatelprintPreviewDialog1.Document = PatelprintDocument1;
                    PatelprintPreviewDialog1.ShowDialog();

                }

                private void PatelprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
                {
                    Bitmap bmp = Properties.Resources.address;
                    Image newimg = bmp;
                    string dash = "************************************************************************************************************************";
                    e.Graphics.DrawImage(newimg, 25, 25, newimg.Width, newimg.Height);
                    e.Graphics.DrawString("Buyer Name:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 180));
                    e.Graphics.DrawString(Party_name.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 205));
                    e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 225));
                    e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 265));
                    e.Graphics.DrawString("SNO ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 295));
                    e.Graphics.DrawString("Product Discription", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(80, 295));
                    e.Graphics.DrawString("Gst", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, 295));
                    e.Graphics.DrawString("Quantity ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 295));
                    e.Graphics.DrawString("Rate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 295));

                    e.Graphics.DrawString("Per ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(650, 295));
                    e.Graphics.DrawString("Amount ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(720, 295));

                    e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 325));
                    int no = 1;
                    int yindex = 12;
                    int position = 0;
                    decimal sum = 0;
                    if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
                    {

                        foreach (DataGridViewRow item in this.dataGridView1.Rows)
                        {
                            if (item.Cells[1].Value == null && item.Cells[2].Value == null && item.Cells[3].Value == null)
                            {

                            }
                            else
                            {

                                e.Graphics.DrawString(no.ToString(), new Font("Arial", 12), Brushes.Black, new Point(35, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["Product_name"].Value == null ? "Not mentioned" : item.Cells["Product_name"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(90, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["gst"].Value == null ? "0" : item.Cells["gst"].Value.ToString() + "%", new Font("Arial", 12), Brushes.Black, new Point(360, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["user_qgrid1"].Value == null ? "0" : item.Cells["user_qgrid1"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(460, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["Selling_price"].Value == null ? "0" : item.Cells["Selling_price"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(560, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["Quantity_type"].Value == null ? "-" : item.Cells["Quantity_type"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(660, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["Total_grid2"].Value == null ? "0" : item.Cells["Total_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(730, 345 + yindex));
                                position = 345 + yindex;

                                no++;
                                yindex = yindex + 18;

                            }


                        }
                        yindex = 18;

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Total_grid2"].Value == null ? "0" : dataGridView1.Rows[i].Cells["Total_grid2"].Value.ToString());
                        }




                    }
                    if (dataGridView1.Rows.Count != 0)
                    {
                        position = 345;
                    }
                    //this is used for runtime billing of the product which we dont have in stock 
                    if (dataGridView2_RutimeSelling.Rows != null && dataGridView2_RutimeSelling.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow item in this.dataGridView2_RutimeSelling.Rows)
                        {
                            if (item.Cells[1].Value == null && item.Cells[2].Value == null && item.Cells[3].Value == null)
                            {

                            }
                            else
                            {

                                e.Graphics.DrawString(no.ToString(), new Font("Arial", 12), Brushes.Black, new Point(35, position + yindex));
                                e.Graphics.DrawString(item.Cells["Runtime_Product_name"].Value == null ? "Not mentioned" : item.Cells["Runtime_Product_name"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(90, position + yindex));
                                // e.Graphics.DrawString(item.Cells["Runtime_gst"].Value == null ? "0" : item.Cells["gst"].Value.ToString() + "%", new Font("Arial", 12), Brushes.Black, new Point(360, 345 + yindex));
                                e.Graphics.DrawString(item.Cells["Runtime_Quantity"].Value == null ? "0" : item.Cells["Runtime_Quantity"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(460, position + yindex));
                                e.Graphics.DrawString(item.Cells["Runtime_Selling_price"].Value == null ? "0" : item.Cells["Runtime_Selling_price"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(560, position + yindex));
                                e.Graphics.DrawString(item.Cells["Runtime_Quantity_type"].Value == null ? "-" : item.Cells["Runtime_Quantity_type"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(660, position + yindex));
                                e.Graphics.DrawString(item.Cells["Runtime_Total_amount"].Value == null ? "0" : item.Cells["Runtime_Total_amount"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(730, position + yindex));
                                //position = position + yindex;

                                no++;
                                yindex = yindex + 18;

                            }
                        }

                        for (int i = 0; i < dataGridView2_RutimeSelling.Rows.Count; i++)
                        {
                            sum += Convert.ToDecimal(dataGridView2_RutimeSelling.Rows[i].Cells["Runtime_Total_amount"].Value == null ? "0" : dataGridView2_RutimeSelling.Rows[i].Cells["Runtime_Total_amount"].Value.ToString());


                        }
                    }
                    e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 980));
                    e.Graphics.DrawString("Total Amount : " + sum.ToString(), new Font("Arial", 12), Brushes.Black, new Point(600, 1000));

                }*/

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            //if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            //{
            //    object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.RowIndex]).Items.Contains(value))
            //    {
            //        ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.RowIndex]).Items.Add(value);
            //        e.ThrowException = false;
            //    }
            //}
        }

        void repo_Grid2()
        {
            DataRow drLocal = null;
            foreach (DataGridViewRow row in dataGridView2_RutimeSelling.Rows)
            {
                drLocal = dtLocalC.NewRow();
                if (row.Cells["Runtime_Product_name"].Value != null && row.Cells["Runtime_Selling_price"].Value != null && dataGridView1.Rows.Count > 0)
                {
                    drLocal["Product Name"] = row.Cells["Runtime_Product_name"].Value.ToString();
                    drLocal["Quantity"] = row.Cells["Runtime_Quantity"].Value == null ? 0 : Convert.ToDecimal(row.Cells["Runtime_Quantity"].Value);
                    drLocal["GST"] = row.Cells["Runtime_Gst"].Value == null ? "" : row.Cells["Runtime_Gst"].Value.ToString();

                    drLocal["Rate"] = Convert.ToDecimal(row.Cells["Runtime_Selling_price"].Value);


                    drLocal["Per"] = row.Cells["Runtime_Quantity_type"].Value.ToString();
                    drLocal["Discount"] = "";

                    dtLocalC.Rows.Add(drLocal);

                }


            }
        }
        void repo_Grid1()
        {
            DataRow drLocal = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                drLocal = dtLocalC.NewRow();
                if (row.Cells["Product_name"].Value != null && row.Cells["Selling_price"].Value != null && dataGridView1.Rows.Count > 0)
                {
                    drLocal["Product Name"] = row.Cells["Product_name"].Value.ToString();
                    drLocal["Quantity"] = row.Cells["user_qgrid1"].Value == null ? 0 : Convert.ToDecimal(row.Cells["user_qgrid1"].Value);
                    drLocal["GST"] = row.Cells["gst"].Value.ToString();

                    drLocal["Rate"] = Convert.ToDecimal(row.Cells["Selling_price"].Value);


                    drLocal["Per"] = row.Cells["Quantity_type"].Value.ToString();
                    drLocal["Discount"] = row.Cells["discount_grid1"].Value.ToString() == "0" ? " " : row.Cells["discount_grid1"].Value;

                    dtLocalC.Rows.Add(drLocal);

                }


            }
        }
        void OrderDetails()
        {//selling order details
            Selling_orders Selling_Orders_model = new Selling_orders();


            Selling_Orders_model.PartyName = Party_name.Text;
            Selling_Orders_model.Invoice = "";
            Selling_Orders_model.Date = DateTime.Now.ToString("dd/ MM / yyyy");
            pateldb.Selling_orders.Add(Selling_Orders_model);//order id is created for party
            //db.Purchase_orders.SqlQuery("insert into purchase_orders(PartyName,Invoice,Date) values(@party,@invoice,@date)", new SqlParameter("@party", Party_name.Text), new SqlParameter("@invoice", invoice.Text), new SqlParameter("@date", DateTime.Now.ToString("dd/ MM / yyyy")));

            pateldb.SaveChanges();
            var order_id = pateldb.Selling_orders.OrderByDescending(x => x.order_id).First();
            invoice = order_id.order_id.ToString();
            //var order_id = db.Purchase_orders.SqlQuery("select order_id from purchase_orders order by order_id desc ");
            //order details saving with corresponding order id 
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {




                if (item.Cells[1].Value != null && item.Cells[2].Value != null && item.Cells[3].Value != null)
                {
                    Selling_OrderDetails Selling_OrderDetails_model = new Selling_OrderDetails();
                    Selling_OrderDetails_model.order_id = Convert.ToInt32(order_id.order_id);
                    Selling_OrderDetails_model.ProductName = item.Cells["Product_name"].Value.ToString();
                    Selling_OrderDetails_model.Gst = Convert.ToDouble(item.Cells["gst"].Value);
                    Selling_OrderDetails_model.Qty_type = item.Cells["Quantity_type"].Value.ToString();
                    Selling_OrderDetails_model.Qty = Convert.ToDecimal(item.Cells["user_qgrid1"].Value);
                    Selling_OrderDetails_model.ProductBrand = item.Cells["Brand_name"].Value.ToString();
                    Selling_OrderDetails_model.Purchase_Price = Convert.ToDecimal(item.Cells["Purchase_price"].Value);
                    Selling_OrderDetails_model.discount = Convert.ToDouble(item.Cells["discount_grid1"].Value == null ? "0" : item.Cells["discount_grid1"].Value);
                    Selling_OrderDetails_model.BasePrice = Convert.ToDecimal(item.Cells["BasePrice"].Value);
                    pateldb.Selling_OrderDetails.Add(Selling_OrderDetails_model);


                }



            }
            foreach (DataGridViewRow item in this.dataGridView2_RutimeSelling.Rows)
            {




                if (item.Cells[1].Value != null && item.Cells[6].Value != null && item.Cells[7].Value != null)
                {
                    Selling_OrderDetails Selling_OrderDetails_model = new Selling_OrderDetails();
                    Selling_OrderDetails_model.order_id = Convert.ToInt32(order_id.order_id);
                    Selling_OrderDetails_model.ProductName = item.Cells[1].Value.ToString();
                    Selling_OrderDetails_model.Gst = 0;
                    Selling_OrderDetails_model.Qty_type = item.Cells[8].Value == null ? "Not Mention" : item.Cells[8].Value.ToString();
                    Selling_OrderDetails_model.Qty = Convert.ToDecimal(item.Cells[6].Value);
                    Selling_OrderDetails_model.ProductBrand = "Not Mentioned";
                    Selling_OrderDetails_model.Purchase_Price = Convert.ToDecimal(item.Cells[7].Value);
                    Selling_OrderDetails_model.discount = 0;
                    pateldb.Selling_OrderDetails.Add(Selling_OrderDetails_model);


                }



            }
            pateldb.SaveChanges();

        }
        private void add_records_Click(object sender, EventArgs e)
        {
            dtLocalC.Rows.Clear();
            dict.Clear();

            if (Party_name.Text != null && Party_name.Text != "" || (!string.IsNullOrWhiteSpace(Party_name.Text)))
            {


                Thread repo_grid1 = new Thread(repo_Grid1);
                repo_grid1.Start();
                Thread repo_grid2 = new Thread(repo_Grid2);
                repo_grid2.Start();

                Thread order = new Thread(OrderDetails);

                order.Start();

                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                    if (item.Cells[1].Value != null && item.Cells[2].Value != null && item.Cells[3].Value != null)
                    {
                        if (!dict.ContainsKey(Convert.ToInt32(item.Cells["product_id"].Value)))
                        {
                            dict.Add(Convert.ToInt32(item.Cells["product_id"].Value), Convert.ToDecimal(item.Cells["Product_quantity"].Value));

                        }



                        if (objdb.selling_product_exist_changing_latest_selling_p(item.Cells["product_id"].Value.ToString(), Party_name.Text, item.Cells["Selling_price"].Value.ToString()))
                        {

                            if (Convert.ToDecimal(item.Cells["user_qgrid1"].Value) > dict[Convert.ToInt32(item.Cells["product_id"].Value)])
                            {
                                SqlCommand cmd = new SqlCommand("update products set product_quantity=0 where id=@id");
                                dict[Convert.ToInt32(item.Cells["product_id"].Value)] = 0;
                                cmd.Parameters.AddWithValue("@id", item.Cells["product_id"].Value.ToString());
                                objdb.executeQuery(cmd);

                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand("update products set product_quantity=product_quantity-@qty where id=@id");
                                dict[Convert.ToInt32(item.Cells["product_id"].Value)] = dict[Convert.ToInt32(item.Cells["product_id"].Value)] - Convert.ToDecimal(item.Cells["user_qgrid1"].Value);
                                cmd.Parameters.AddWithValue("@qty", item.Cells["user_qgrid1"].Value == null ? "0" : item.Cells["user_qgrid1"].Value.ToString());
                                cmd.Parameters.AddWithValue("@id", item.Cells["product_id"].Value.ToString());
                                objdb.executeQuery(cmd);
                            }
                            continue;
                        }
                        model = null;

                        sqlCmd = new SqlCommand("insert into selling_product_table(product_name,purchase_price,sell_price,product_quantity,Party_name,brand,MRP,invoice,Gst,Quantity_type,total,product_id) values(@PN,@PP,@SP,@Qty,@Party,@Brand,@Mrp,@invoice,@Gst,@Quantity_type,@tot,@product_id)");
                        sqlCmd.Parameters.AddWithValue("@PN", item.Cells["Product_name"].Value == null ? "Not mentioned" : item.Cells["Product_name"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PP", item.Cells["Purchase_price"].Value == null ? "0" : item.Cells["Purchase_price"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Gst", item.Cells["gst"].Value == null ? "0" : item.Cells["gst"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Qty", item.Cells["user_qgrid1"].Value == null ? "0" : item.Cells["user_qgrid1"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@SP", item.Cells["Selling_price"].Value == null ? "0" : item.Cells["Selling_price"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Quantity_type", item.Cells["Quantity_type"].Value == null ? "0" : item.Cells["Quantity_type"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@tot", item.Cells["Total_grid2"].Value == null ? "0" : item.Cells["Total_grid2"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Mrp", item.Cells["mrp"].Value == null ? "0" : item.Cells["mrp"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Brand", item.Cells["Brand_name"].Value == null ? "0" : item.Cells["Brand_name"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Party", Party_name.Text == null || Party_name.Text == "" ? "not mentioned" : Party_name.Text);
                        sqlCmd.Parameters.AddWithValue("@invoice", "0");
                        sqlCmd.Parameters.AddWithValue("@product_id", item.Cells["product_id"].Value == null ? "0000" : item.Cells["product_id"].Value.ToString());
                        objdb.executeQuery(sqlCmd);
                        if (item.Cells["product_id"].Value != null)
                        {
                            if (Convert.ToDecimal(item.Cells["user_qgrid1"].Value) > dict[Convert.ToInt32(item.Cells["product_id"].Value)])
                            {
                                SqlCommand cmd = new SqlCommand("update products set product_quantity=0 where id=@id");
                                //pateldb.products.SqlQuery("update products set product_quantity=0 where id=@id", new SqlParameter("@id", item.Cells["product_id"].Value.ToString()));
                                //pateldb.SaveChanges();
                                dict[Convert.ToInt32(item.Cells["product_id"].Value)] = 0;
                                cmd.Parameters.AddWithValue("@id", item.Cells["product_id"].Value.ToString());
                                objdb.executeQuery(cmd);
                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand("update products set product_quantity=product_quantity-@qty where id=@id");
                                dict[Convert.ToInt32(item.Cells["product_id"].Value)] = dict[Convert.ToInt32(item.Cells["product_id"].Value)] - Convert.ToDecimal(item.Cells["user_qgrid1"].Value);
                                cmd.Parameters.AddWithValue("@qty", item.Cells["user_qgrid1"].Value == null ? "0" : item.Cells["user_qgrid1"].Value.ToString());
                                cmd.Parameters.AddWithValue("@id", item.Cells["product_id"].Value.ToString());
                                objdb.executeQuery(cmd);

                                //pateldb.products.SqlQuery("update products set product_quantity=product_quantity-@qty where id=@id", new SqlParameter("@id", item.Cells["product_id"].Value.ToString()),new SqlParameter("@qty", item.Cells["user_qgrid1"].Value == null ? "0" : item.Cells["user_qgrid1"].Value.ToString()));
                                //pateldb.SaveChanges();
                            }
                        }


                    }




                }

                if (!autotext.Contains(Party_name.Text) && (Party_name.Text != null && Party_name.Text != ""))
                {
                    sqlCmd = new SqlCommand("insert into category(category) values(@cat)");

                    sqlCmd.Parameters.AddWithValue("@cat", Party_name.Text);
                    objdb.executeQuery(sqlCmd);


                    Thread populate = new Thread(() =>
                    {
                        this.BeginInvoke((Action)delegate ()
                        {
                            populate_product_party1();
                        });
                    });
                    populate.Start();
                }

                repo_grid1.Join();
                repo_grid2.Join();
                order.Join();
                reportForm report = new reportForm(dtLocalC, 2, Party_name.Text,invoice==""||invoice==null?"0":invoice   );

                report.Show();


                Party_name.Focus();

               
                button2.PerformClick();
                report.BringToFront();
                //PatelprintDocument1.Print();
            }
            else
            {
                MessageBox.Show("please enter party name");
            }


        }

        private void Party_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }


        private void dataGridView2_RutimeSelling_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView2_RutimeSelling.Rows[e.RowIndex].Cells["Runtime_Sno"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView2_RutimeSelling_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2_RutimeSelling.CurrentRow != null)
            {
                DataGridViewRow dgc = dataGridView2_RutimeSelling.CurrentRow;
                if (dgc.Cells["Runtime_Quantity"].Value != null && dgc.Cells["Runtime_Selling_price"].Value != null)
                {


                    decimal amount = Convert.ToDecimal(dgc.Cells["Runtime_Quantity"].Value.ToString()) * Convert.ToDecimal(dgc.Cells["Runtime_Selling_price"].Value.ToString());
                    dgc.Cells["Runtime_Total_amount"].Value = amount.ToString();


                }
            }


        }

        private void dataGridView2_RutimeSelling_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //allow number only to quantity and selling price
            e.Control.KeyPress -= new KeyPressEventHandler(my_KeyPress);
            if (dataGridView2_RutimeSelling.CurrentCell.ColumnIndex == 6 || dataGridView2_RutimeSelling.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(my_KeyPress);
                }
            }
            if (dataGridView2_RutimeSelling.CurrentCell.ColumnIndex == 1)
            {


                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    prodCode.AutoCompleteCustomSource = product_suggest;
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

        private void dataGridView2_RutimeSelling_CurrentCellChanged(object sender, EventArgs e)
        {

            // MessageBox.Show(dataGridView2_RutimeSelling.CurrentCell.ColumnIndex.ToString());

        }

        private void dataGridView2_RutimeSelling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)

            {

                /*  if (dataGridView2_RutimeSelling.CurrentCell.ColumnIndex == 5)

                  {

                      dataGridView2_RutimeSelling[12, dataGridView2_RutimeSelling.CurrentRow.Index].Selected = true;

                      dataGridView2_RutimeSelling.CurrentCell = dataGridView2_RutimeSelling[12, dataGridView2_RutimeSelling.CurrentRow.Index];

                      e.Handled = true;

                  }*/
                if (dataGridView2_RutimeSelling.CurrentCell.ColumnIndex == 13)

                {

                    dataGridView2_RutimeSelling[1, dataGridView2_RutimeSelling.CurrentRow.Index + 1].Selected = true;

                    dataGridView2_RutimeSelling.CurrentCell = dataGridView2_RutimeSelling[1, dataGridView2_RutimeSelling.CurrentRow.Index + 1];

                    e.Handled = true;

                }


            }
        }

        private void Selling_page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Purchase_namaeComboBox_TextUpdate(object sender, EventArgs e)
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



        private void combo_dropdown(object sender, EventArgs e)
        {
            try
            {
                Purchase_namaeComboBox.DroppedDown = false;
                (sender as ComboBox).DroppedDown = true;

                if ((sender as ComboBox).Items.Count > 0)
                {

                    (sender as ComboBox).SelectedIndex = 0;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid info");
            }


        }
        //selling product name keydown event
        private void Purchase_namaeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Purchase_namaeComboBox.SelectedItem != null)
            {
                SellingResetContro();
                read_productpro();
                Selling_BrandcomboBox.Focus();
            }
            else if (e.KeyCode == Keys.Enter && Purchase_namaeComboBox.Text != "")
            {
                SellingResetControl();
            }
        }
        //selling product brand keydown event
        private void Selling_BrandcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Selling_BrandcomboBox.SelectedItem != null && Purchase_namaeComboBox.SelectedItem != null && e.KeyCode == Keys.Enter)
            {
                read_productPurchaseprice();
                Selling_PurchasePricecomboBox.Focus();
            }

        }

        private void Selling_PurchasePricecomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Selling_BrandcomboBox.SelectedItem != null && Purchase_namaeComboBox.SelectedItem != null && Selling_PurchasePricecomboBox.SelectedItem != null && e.KeyCode == Keys.Enter)
            {
                model = null;
                model = objdb.read_sellingpage_keydown_forRecord("select * from products where product_name=@pro and brand=@brand and purchase_price=@price", Purchase_namaeComboBox.SelectedItem.ToString(), Selling_BrandcomboBox.SelectedItem.ToString(), Selling_PurchasePricecomboBox.SelectedItem.ToString());
                //model = pateldb.products.SqlQuery("select * from products where product_name=@pro and brand=@brand and purchase_price=@price", new SqlParameter("@pro", Purchase_namaeComboBox.SelectedItem.ToString()), new SqlParameter("@brand", Selling_BrandcomboBox.SelectedItem.ToString()), new SqlParameter("@price", Selling_PurchasePricecomboBox.SelectedItem.ToString())).FirstOrDefault();

                if (model != null)
                {
                    if (model.id > 0)
                    {
                        GSTlbl.Text = model.Gst.ToString();
                        QTYlbl.Text = model.product_quantity.ToString();
                        PERLBL.Text = model.Quantity_type.ToString();
                        Selling_Mrplbl.Text = model.MRP.ToString();
                        product_checking_id = model.id;
                        Base_price_lbl.Text = model.base_price.ToString();
                        if (Party_name.Text != "" && Purchase_namaeComboBox.SelectedItem != null && Selling_BrandcomboBox.SelectedItem != null && Selling_PurchasePricecomboBox.SelectedItem != null && Party_name.Text != string.Empty)
                        {
                            DataTable dt = new DataTable();
                            dt.Clear();
                            dt = objdb.product_exist_sell(Purchase_namaeComboBox.SelectedItem.ToString(), Selling_BrandcomboBox.SelectedItem.ToString(), Selling_PurchasePricecomboBox.SelectedItem.ToString(), Party_name.Text);
                            Selling_SellingPricetextBox.Text = "";
                            DiscounttextBox.Text = "";
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow item in dt.Rows)
                                {
                                    Selling_SellingPricetextBox.Text = item["sell_price"].ToString();
                                }
                                decimal a = Convert.ToDecimal(Selling_PurchasePricecomboBox.SelectedItem.ToString()) - Convert.ToDecimal(Selling_SellingPricetextBox.Text);

                                DiscounttextBox.Text = ((a * 100) / Convert.ToDecimal(Selling_PurchasePricecomboBox.SelectedItem.ToString())).ToString("0.0");
                            }
                        }
                        if (Selling_SellingPricetextBox.Text == string.Empty)
                        {
                            DiscounttextBox.Focus();

                        }
                        else
                            Selling_UserQtyTextBox.Focus();



                    }


                }
            }


        }

        private void Selling_SellingPricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            my_KeyPress(sender, e);
        }

        private void Selling_UserQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            my_KeyPress(sender, e);
        }

        private void addlist_button_Click(object sender, EventArgs e)
        {
            if (Purchase_namaeComboBox.SelectedItem == null)
            {
                Purchase_namaeComboBox.Focus();

                MessageBox.Show("Please Select Product \n Product Name is requierd");
            }
            else if (Purchase_namaeComboBox.SelectedItem.ToString() == "Product does not exist")
            {
                Purchase_namaeComboBox.Focus();

                MessageBox.Show("Please Select Product \n Product Name is requierd");
            }
            else if (Selling_BrandcomboBox.SelectedItem == null)
            {
                Selling_BrandcomboBox.Focus();

                MessageBox.Show("Please choose Brand");
            }
            //For combobox validation we should follow the below code.
            else if (Selling_PurchasePricecomboBox.SelectedItem == null)
            {
                Selling_PurchasePricecomboBox.Focus();
                MessageBox.Show("Select Select Purchase Price");
            }
            else if (Selling_UserQtyTextBox.Text == "" || Selling_UserQtyTextBox.Text == string.Empty)
            {

                MessageBox.Show("Please enter Quantity");
                Selling_UserQtyTextBox.Focus();
            }
            else if (Selling_SellingPricetextBox.Text == "" || Selling_SellingPricetextBox.Text == string.Empty)
            {

                MessageBox.Show("Please enter Selling Price");
                Selling_SellingPricetextBox.Focus();
            }
            else if (Convert.ToDecimal(DiscounttextBox.Text)>100)
            {
                MessageBox.Show("Please enter valid info of discount");

            }
            else
            {

                decimal total = Convert.ToDecimal(Selling_UserQtyTextBox.Text == "" ? "1" : Selling_UserQtyTextBox.Text) * Convert.ToDecimal(Selling_SellingPricetextBox.Text);
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["Product_name", row].Value = Purchase_namaeComboBox.SelectedItem.ToString();
                dataGridView1["Brand_name", row].Value = Selling_BrandcomboBox.SelectedItem.ToString();
                dataGridView1["Purchase_price", row].Value = Selling_PurchasePricecomboBox.SelectedItem.ToString();


                dataGridView1["gst", row].Value = GSTlbl.Text == "GST" ? "0" : GSTlbl.Text;
                dataGridView1["Product_quantity", row].Value = QTYlbl.Text == "QTY" ? "0" : QTYlbl.Text;
                dataGridView1["Quantity_type", row].Value = PERLBL.Text == "PER" ? "" : PERLBL.Text;
                dataGridView1["Selling_price", row].Value = Selling_SellingPricetextBox.Text == "" ? Selling_PurchasePricecomboBox.SelectedItem.ToString() : Selling_SellingPricetextBox.Text;
                dataGridView1["mrp", row].Value = Selling_Mrplbl.Text == "" ? Selling_PurchasePricecomboBox.SelectedItem.ToString() : Selling_Mrplbl.Text;
                dataGridView1["user_qgrid1", row].Value = Selling_UserQtyTextBox.Text == "" ? "1" : Selling_UserQtyTextBox.Text;
                dataGridView1["Total_grid2", row].Value = total.ToString();
                dataGridView1["discount_grid1", row].Value = DiscounttextBox.Text == "" ? "0" : DiscounttextBox.Text;
                dataGridView1["BasePrice", row].Value = Base_price_lbl.Text == "" ? "0" : Base_price_lbl.Text;
                if (model != null)
                {
                    if (model.id > 0 && model.id == product_checking_id)
                    {
                        dataGridView1["product_id", row].Value = product_checking_id == 0 ? null : product_checking_id.ToString();
                        dataGridView1["party_g1", row].Value = model.product_category;


                    }

                }
                SellingResetControl();


            }
        }
        void SellingResetContro()
        {
            model = null;
            product_checking_id = 0;

            Selling_BrandcomboBox.SelectedItem = null;
            Selling_PurchasePricecomboBox.SelectedItem = null;
            Selling_UserQtyTextBox.Clear();
            DiscounttextBox.Text = "";
            GSTlbl.Text = "";
            PERLBL.Text = "";
            Selling_Mrplbl.Text = "";
            Selling_SellingPricetextBox.Clear();
            QTYlbl.Text = "";
            Base_price_lbl.Text = "";

        }
        void SellingResetControl()
        {
            model = null;
            product_checking_id = 0;
            Base_price_lbl.Text = "";
            Purchase_namaeComboBox.SelectedItem = null;
            Selling_BrandcomboBox.SelectedItem = null;
            Selling_PurchasePricecomboBox.SelectedItem = null;
            Selling_UserQtyTextBox.Clear();
            GSTlbl.Text = "";
            PERLBL.Text = "";
            Selling_Mrplbl.Text = "";
            Selling_SellingPricetextBox.Clear();
            QTYlbl.Text = "";
            DiscounttextBox.Text = "";

        }

        private void addlist_button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Purchase_namaeComboBox.Focus();
            }
        }

        private void Purchase_namaeComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            Purchase_namaeComboBox.DroppedDown = false;
        }

        private void DiscounttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Selling_PurchasePricecomboBox.SelectedItem != null)
            {
                decimal a = Convert.ToDecimal(Selling_PurchasePricecomboBox.SelectedItem) * Convert.ToDecimal(DiscounttextBox.Text == "" ? "0" : DiscounttextBox.Text) / 100;
                Selling_SellingPricetextBox.Text = (Convert.ToDecimal(Selling_PurchasePricecomboBox.SelectedItem) - a).ToString();
                Selling_SellingPricetextBox.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellingResetControl();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2_RutimeSelling.Rows.Clear();
            dataGridView2_RutimeSelling.Refresh();
            Party_name.Text = "";
            invoice = "";
            Party_name.Focus();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                DataGridViewRow dgc = dataGridView1.CurrentRow;

                //product quantity check

                if (dgc.Cells["Product_quantity"].Value != null && dgc.Cells["user_qgrid1"].Value != null && dgc.Cells["Selling_price"].Value != null)
                {


                    decimal amount = Convert.ToDecimal(dgc.Cells["user_qgrid1"].Value.ToString()) * Convert.ToDecimal(dgc.Cells["Selling_price"].Value.ToString());
                    dgc.Cells["Total_grid2"].Value = amount.ToString();


                }
                //if (dgc.Cells["Purchase_price"].Value != null && dgc.Cells["Selling_price"].Value != null && dgc.Cells["Purchase_price"].Value.ToString() != "--Select purchase--")
                //{
                //    if (Convert.ToDecimal(dgc.Cells["Selling_price"].Value) < Convert.ToDecimal(dgc.Cells["Purchase_price"].Value))
                //    {
                //        if (MessageBox.Show("selling price is less than purchase price \n" +
                //        "if you want to sell on purchase price then click yes", "available quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //        {
                //            dgc.Cells["Selling_price"].Value = dgc.Cells["Purchase_price"].Value;

                //        }

                //    }

                //}
            }
        }

    }
}
