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
    public partial class Purchase_order : Form
    {
        DBAccess objdb = new DBAccess();
        product model = new product();
        Patel_motorsEntities db = new Patel_motorsEntities();
        AutoCompleteStringCollection product_suggest = new AutoCompleteStringCollection();
        DataTable brand = new DataTable();
        List<string> listOnit = new List<string>();

        List<string> listNew = new List<string>();
        public Purchase_order()
        {
            InitializeComponent();


        }

        private void Purchase_order_Load(object sender, EventArgs e)
        {
            Thread p = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    SqlDataReader dr = objdb.readDatathroughReader("select distinct product_name from products");
                    listOnit.Clear();
                    while (dr.Read())
                    {
                        product_suggest.Add(dr.GetString(0));

                        listOnit.Add(dr.GetString(0));

                    }
                    objdb.closeConn();
                    this.Purchase_namaeComboBox.Items.Clear();
                    this.Purchase_namaeComboBox.Items.AddRange(listOnit.ToArray());
                    //foreach (string item in db.products.Select(x => x.product_name).Distinct())
                    //{
                    //    product_suggest.Add(item);

                    //};
                });
            });
            p.Start();

            Product_dataGridView1.BorderStyle = BorderStyle.None;
            Product_dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Product_dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Product_dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Product_dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Product_dataGridView1.BackgroundColor = Color.White;

            Product_dataGridView1.EnableHeadersVisualStyles = false;
            Product_dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Product_dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Product_dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
        private void read_productpro()
        {

            if (Purchase_namaeComboBox.SelectedItem != null)
            {
                brand = objdb.read_adapter_sell("select distinct brand from products where product_name=@gen", Purchase_namaeComboBox.SelectedItem.ToString(), new DataTable());

                Purchase_orderComboBox.Items.Clear();

                foreach (DataRow row in brand.Rows)
                {
                    if (!(Purchase_orderComboBox.Items.Contains(row["brand"].ToString())))
                    {
                        Purchase_orderComboBox.Items.Add(row["brand"].ToString());

                    }



                }



            }
        }




        void ctl_Enter(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }
        private void add_records_Click(object sender, EventArgs e)
        {
            reportForm report = new reportForm(GetDataTable(), 1);

            Purchase_namaeComboBox.Focus();
            report.Show();
            // printDocument1.Print();
        }
        public DataTable GetDataTable()
        {
            DataTable dtLocalC = new DataTable();
            dtLocalC.Columns.Add("Product Name");
            dtLocalC.Columns.Add("Base Price");
            dtLocalC.Columns.Add("GST");
            dtLocalC.Columns.Add("Purchase Price");
            dtLocalC.Columns.Add("Brand");
            dtLocalC.Columns.Add("MRP");
            dtLocalC.Columns.Add("Party Name");
            dtLocalC.Columns.Add("Per");


            DataRow drLocal = null;
            foreach (DataGridViewRow row in Product_dataGridView1.Rows)
            {
                drLocal = dtLocalC.NewRow();
                if (row.Cells["pro_name"].Value != null)
                {
                    drLocal["Product Name"] = row.Cells["pro_name"].Value.ToString();
                    drLocal["GST"] = row.Cells["gst"].Value == null ? "" : row.Cells["gst"].Value.ToString();
                    drLocal["Base Price"] = row.Cells["basic_price"].Value == null ? "" : row.Cells["basic_price"].Value.ToString();
                    drLocal["Purchase Price"] = row.Cells["purchase_p"].Value == null ? "" : row.Cells["purchase_p"].Value.ToString();
                    drLocal["Brand"] = row.Cells["Brand_grid1"].Value == null ? "" : row.Cells["Brand_grid1"].Value.ToString();
                    drLocal["MRP"] = row.Cells["mrp"].Value == null ? "" : row.Cells["mrp"].Value.ToString();
                    drLocal["Party Name"] = row.Cells["pro_cat"].Value == null ? "" : row.Cells["pro_cat"].Value.ToString();
                    drLocal["Per"] = row.Cells["quantity_type"].Value == null ? "" : row.Cells["quantity_type"].Value.ToString();


                    dtLocalC.Rows.Add(drLocal);

                }


            }

            return dtLocalC;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Product_dataGridView1.Rows.Clear();
            ResetControl();

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Product_dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void Product_dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }

            if (Product_dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                ComboBox ctl = e.Control as ComboBox;
                ctl.Enter -= new EventHandler(ctl_Enter);
                ctl.Enter += new EventHandler(ctl_Enter);
                if (ctl != null)
                {
                    ctl.SelectedIndex = 0;
                }
            }

            if (Product_dataGridView1.CurrentCell.ColumnIndex == 1)
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

        private void Product_dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                DataGridViewRow row = Product_dataGridView1.CurrentRow;
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "Select Brand")
                {
                    Product_dataGridView1[1, Product_dataGridView1.CurrentRow.Index + 1].Selected = true;

                    Product_dataGridView1.CurrentCell = Product_dataGridView1[1, Product_dataGridView1.CurrentRow.Index + 1];

                    e.Handled = true;
                }
            }
        }

        private void Purchase_order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void ResetControl()
        {
            Purchase_orderComboBox.SelectedItem = null;
            Purchase_namaeComboBox.SelectedItem = null;
            Purchase_namaeComboBox.Focus();

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

        private void Purchase_orderComboBox_Enter(object sender, EventArgs e)
        {

            (sender as ComboBox).DroppedDown = true;
            if ((sender as ComboBox).Items.Count > 0)
            {

                (sender as ComboBox).SelectedIndex = 0;
            }
        }

        private void Purchase_orderComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Purchase_namaeComboBox.SelectedItem != null && Purchase_orderComboBox.SelectedItem != null && e.KeyCode == Keys.Enter)
            {
                add_intolist.PerformClick();
            }
        }

        private void Purchase_namaeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Purchase_namaeComboBox.SelectedItem != null && e.KeyCode == Keys.Enter)
            {
                read_productpro();
                Purchase_orderComboBox.Focus();
            }

        }

        private void add_intolist_Click(object sender, EventArgs e)
        {
            if (Purchase_namaeComboBox.SelectedItem.ToString() == "Product does not exist" || Purchase_namaeComboBox.SelectedItem == null)
            {
                Purchase_namaeComboBox.Focus();
                MessageBox.Show("Please Select Product \n Product Name is requierd");
            }
            else if (Purchase_orderComboBox.SelectedItem == null)
            {
                Purchase_orderComboBox.Focus();
                MessageBox.Show("Please choose Brand");
            }
            //For combobox validation we should follow the below code.
            else
            {

                int row = 0;

                Product_dataGridView1.Rows.Add();
                row = Product_dataGridView1.Rows.Count - 2;


                model = db.products.SqlQuery("select * from products where purchase_price=(select Min(purchase_price) from products where product_name=@product and brand=@Brand) ", new SqlParameter("@product", Purchase_namaeComboBox.SelectedItem.ToString()), new SqlParameter("@Brand", Purchase_orderComboBox.SelectedItem.ToString())).FirstOrDefault();
                if (model != null && model.product_name != null)
                {
                    Product_dataGridView1["pro_name", row].Value = Purchase_namaeComboBox.SelectedItem.ToString();
                    Product_dataGridView1["Brand_grid1", row].Value = Purchase_orderComboBox.SelectedItem.ToString();
                    Product_dataGridView1["gst", row].Value = model.Gst.ToString();
                    Product_dataGridView1["basic_price", row].Value = model.base_price.ToString();
                    Product_dataGridView1["purchase_p", row].Value = model.purchase_price.ToString();
                    // row.Cells["Brand_grid1"].Value = model.brand.ToString();
                    Product_dataGridView1["mrp", row].Value = model.MRP.ToString();
                    Product_dataGridView1["pro_cat", row].Value = model.product_category.ToString();
                    Product_dataGridView1["quantity_type", row].Value = model.Quantity_type.ToString();
                }
                Purchase_namaeComboBox.Focus();
                ResetControl();
            }
        }






        /*    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                Bitmap bmp = Properties.Resources.address;
                Image newimg = bmp;
                string dash = "****************************************************************************************************************************";
                e.Graphics.DrawImage(newimg, 25, 25, newimg.Width, newimg.Height);
               // e.Graphics.DrawString("Buyer Name:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 180));
                //e.Graphics.DrawString(Party_name.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 205));
                e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 225));
                e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 265));
                e.Graphics.DrawString("SNO ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 295));
                e.Graphics.DrawString("Product Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(80, 295));
                e.Graphics.DrawString("Gst", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 295));
                e.Graphics.DrawString("Base Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(310, 295));
                e.Graphics.DrawString("Rate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(420, 295));
                //e.Graphics.DrawString("MRP", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(490, 295));
                e.Graphics.DrawString("Per", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(520, 295));
                e.Graphics.DrawString("Brand", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(580, 295));
                e.Graphics.DrawString("Party Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(650, 295));

                e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 325));
                int no = 1;
                int yindex = 12;
                int position = 0;
                foreach (DataGridViewRow item in this.Product_dataGridView1.Rows)
                {
                    if (item.Cells[1].Value == null && item.Cells[2].Value == null && item.Cells[3].Value == null)
                    {

                    }
                    else
                    {

                        e.Graphics.DrawString(no.ToString(), new Font("Arial", 12), Brushes.Black, new Point(35, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["pro_name"].Value == null ? "Not mentioned" : item.Cells["pro_name"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(80, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["gst"].Value == null ? "0" : item.Cells["gst"].Value.ToString() + "%", new Font("Arial", 12), Brushes.Black, new Point(270, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["basic_price"].Value == null ? "0" : item.Cells["basic_price"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(315, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["purchase_p"].Value == null ? "0" : item.Cells["purchase_p"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(425, 345 + yindex));
                       // e.Graphics.DrawString(item.Cells["mrp"].Value == null ? "-" : item.Cells["mrp"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(495, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["quantity_type"].Value == null ? "0" : item.Cells["quantity_type"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(525, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["Brand_grid1"].Value == null ? "-" : item.Cells["Brand_grid1"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(585, 345 + yindex));
                        e.Graphics.DrawString(item.Cells["pro_cat"].Value == null ? "0" : item.Cells["pro_cat"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(655, 345 + yindex));

                        position = 345 + yindex;

                        no++;
                        yindex = yindex + 18;

                    }
                }

            }

            private void print_priview_Click(object sender, EventArgs e)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
        }    }*/
    }
}
