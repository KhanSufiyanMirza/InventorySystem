using demo.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace demo.UI
{
    public partial class Purchse_Selling_Orders : Form
    {
        Patel_motorsEntities db = new Patel_motorsEntities();
        DataTable dtLocalC;
        public Purchse_Selling_Orders()
        {
            InitializeComponent();
        }



        private void Purchse_Selling_Orders_Load(object sender, EventArgs e)
        {
            dtLocalC = new DataTable();
            dtLocalC.Columns.Add("Product Name");

            dtLocalC.Columns.Add("GST");
            dtLocalC.Columns.Add("Quantity", typeof(decimal));
            dtLocalC.Columns.Add("Rate", typeof(decimal));
            dtLocalC.Columns.Add("Per");
            dtLocalC.Columns.Add("Discount");
            dtLocalC.Columns.Add("Brand");
            dtLocalC.Columns.Add("BasePrice", typeof(decimal));

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (PurchaseradioButton.Checked)
                {
                    if (PartyradioButton.Checked)
                    {
                        if (SearchtextBox.Text.Trim() != "" && SearchtextBox.Text != string.Empty && (!string.IsNullOrWhiteSpace(SearchtextBox.Text)))
                        {
                            Order_Grid.DataSource = db.Purchase_orders.SqlQuery("select * from Purchase_orders where PartyName like '%'+@party+'%' order by order_id desc", new SqlParameter("@party", SearchtextBox.Text.Trim())).ToList<Purchase_orders>();
                            Order_Grid.Columns[0].Visible = false;

                        }

                    }
                    else
                    {
                        if (SearchtextBox.Text.Trim() != "" && SearchtextBox.Text != string.Empty && (!string.IsNullOrWhiteSpace(SearchtextBox.Text)))
                        {
                            Order_Grid.DataSource = db.Purchase_orders.SqlQuery("select * from Purchase_orders where Invoice like '%'+@invo+'%' order by order_id desc", new SqlParameter("@invo", SearchtextBox.Text.Trim())).ToList<Purchase_orders>();
                            Order_Grid.Columns[0].Visible = false;

                        }

                    }


                }
                else
                {
                    if (PartyradioButton.Checked)
                    {
                        if (SearchtextBox.Text.Trim() != "" && SearchtextBox.Text != string.Empty && (!string.IsNullOrWhiteSpace(SearchtextBox.Text)))
                        {
                            Order_Grid.DataSource = db.Selling_orders.SqlQuery("select * from Selling_orders where PartyName like '%'+@party+'%' order by order_id desc", new SqlParameter("@party", SearchtextBox.Text.Trim())).ToList<Selling_orders>();
                            Order_Grid.Columns[0].Visible = true;
                            Order_Grid.Columns[0].HeaderText = "Invoice NO";
                            Order_Grid.Columns[2].Visible = false;


                        }

                    }
                    else
                    {
                        if (SearchtextBox.Text.Trim() != "" && SearchtextBox.Text != string.Empty && (!string.IsNullOrWhiteSpace(SearchtextBox.Text)))
                        {
                            Order_Grid.DataSource = db.Selling_orders.SqlQuery("select * from Selling_orders where order_id like '%'+@invo+'%' order by order_id desc", new SqlParameter("@invo", SearchtextBox.Text.Trim())).ToList<Selling_orders>();
                            Order_Grid.Columns[0].Visible = true;
                            Order_Grid.Columns[0].HeaderText = "Invoice NO";
                            Order_Grid.Columns[2].Visible = false;

                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void SearchtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (SearchtextBox.Text != "" && SearchtextBox.Text != string.Empty && e.KeyCode == Keys.Enter && (!string.IsNullOrWhiteSpace(SearchtextBox.Text)))
            {
                Search.PerformClick();
            }
            if (Order_Grid.Rows.Count > 0 && e.KeyCode == Keys.Down)
            {
                Order_Grid.Focus();
            }
        }

        private void Order_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Order_Grid.Rows.Count > 0)
                {
                    int i = Convert.ToInt32(this.Order_Grid.SelectedRows[0].Cells[0].Value.ToString());
                    Partylabel1.Text = this.Order_Grid.SelectedRows[0].Cells[1].Value.ToString();

                    if (PurchaseradioButton.Checked)
                    {
                        Invoicelabel2.Text = this.Order_Grid.SelectedRows[0].Cells[2].Value.ToString();

                        if (i > 0)
                        {
                            Order_details_Grid.DataSource = null;
                            Order_details_Grid.DataSource = db.Purchse_OrderDetails.SqlQuery("select * from Purchse_OrderDetails where order_id=@oid ", new SqlParameter("@oid", i.ToString())).ToList<Purchse_OrderDetails>();
                            Order_details_Grid.Columns[0].Visible = false;
                            Order_details_Grid.Columns[1].Visible = false;
                            renamedatagridview();
                        }


                    }
                    else
                    {
                        Invoicelabel2.Text = this.Order_Grid.SelectedRows[0].Cells[0].Value.ToString();
                        if (i > 0)
                        {
                            Order_details_Grid.DataSource = null;
                            Order_details_Grid.DataSource = db.Selling_OrderDetails.SqlQuery("select * from Selling_OrderDetails where order_id=@oid ", new SqlParameter("@oid", i.ToString())).ToList<Selling_OrderDetails>();
                            Order_details_Grid.Columns[0].Visible = false;
                            Order_details_Grid.Columns[1].Visible = false;
                            renamedatagridview();
                        }
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Please check your connection");
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (Order_details_Grid.Rows.Count > 0)
            {
                dtLocalC.Clear();

                report_Grid();
                reportForm report = new reportForm(dtLocalC, 4, Partylabel1.Text, Invoicelabel2.Text);

                report.Show();
            }
        }
        void report_Grid()
        {
            try
            {
                DataRow drLocal = null;
                foreach (DataGridViewRow row in Order_details_Grid.Rows)
                {
                    drLocal = dtLocalC.NewRow();

                    drLocal["Product Name"] = row.Cells["pro_name"].Value.ToString();
                    drLocal["Quantity"] = row.Cells["pro_qty"].Value == null ? 0 : Convert.ToDecimal(row.Cells["pro_qty"].Value);
                    drLocal["GST"] = row.Cells["gst"].Value.ToString();

                    drLocal["Rate"] = Convert.ToDecimal(row.Cells["purchase_p"].Value);


                    drLocal["Per"] = row.Cells["qty_type"].Value.ToString();
                    drLocal["Discount"] = row.Cells["discount"].Value.ToString() == "0" ? " " : row.Cells["discount"].Value;
                    drLocal["Brand"] = row.Cells["brand"].Value.ToString();
                    drLocal["BasePrice"] = Convert.ToDecimal(row.Cells["BasePrice"].Value == null ? 0 : row.Cells["BasePrice"].Value);

                    dtLocalC.Rows.Add(drLocal);




                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void Refresh_Click(object sender, EventArgs e)
        {


            Order_Grid.DataSource = null;
            Order_details_Grid.DataSource = null;

        }
        void renamedatagridview()
        {
            Order_details_Grid.Columns[0].Name = "id";
            Order_details_Grid.Columns["id"].DisplayIndex = 0;
            Order_details_Grid.Columns[1].Name = "Order_id";
            Order_details_Grid.Columns["Order_id"].DisplayIndex = 1;
            Order_details_Grid.Columns[2].Name = "pro_name";
            Order_details_Grid.Columns["pro_name"].DisplayIndex = 2;
            Order_details_Grid.Columns["pro_name"].HeaderText = "Product Name";
            Order_details_Grid.Columns[3].Name = "brand";
            Order_details_Grid.Columns["brand"].DisplayIndex = 9;
            Order_details_Grid.Columns["brand"].HeaderText = "Brand";
            Order_details_Grid.Columns[4].Name = "pro_qty";
            Order_details_Grid.Columns["pro_qty"].DisplayIndex = 7;
            Order_details_Grid.Columns["pro_qty"].HeaderText = "Quantity";
            Order_details_Grid.Columns[5].Name = "qty_type";
            Order_details_Grid.Columns["qty_type"].DisplayIndex = 8;
            Order_details_Grid.Columns["qty_type"].HeaderText = "Per";
            Order_details_Grid.Columns[6].Name = "purchase_p";
            Order_details_Grid.Columns["purchase_p"].DisplayIndex = 6;
            Order_details_Grid.Columns["purchase_p"].HeaderText = "Price";
            Order_details_Grid.Columns[7].Name = "gst";
            Order_details_Grid.Columns["gst"].DisplayIndex = 5;
            Order_details_Grid.Columns["gst"].HeaderText = "GST";
            Order_details_Grid.Columns[8].Name = "discount";
            Order_details_Grid.Columns["discount"].DisplayIndex = 4;
            Order_details_Grid.Columns["discount"].HeaderText = "Discount";
            Order_details_Grid.Columns[9].Name = "BasePrice";
            Order_details_Grid.Columns["BasePrice"].DisplayIndex = 3;
            Order_details_Grid.Columns["BasePrice"].HeaderText = "Base Price";
        }
        private void PurchaseradioButton_CheckedChanged(object sender, EventArgs e)
        {

            Order_Grid.DataSource = null;
            Order_details_Grid.DataSource = null;





        }

        private void DateSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (PurchaseradioButton.Checked)
                {
                    if (PartyradioButton.Checked)
                    {

                        Order_Grid.DataSource = db.Purchase_orders.SqlQuery("select * from Purchase_orders where Date>='" + StartdateTimePicker.Value.ToString("dd/ MM / yyyy") + "' and Date<='" + EnddateTimePicker.Value.ToString("dd/ MM / yyyy") + "' ", new SqlParameter("@party", SearchtextBox.Text.Trim())).ToList<Purchase_orders>();
                        Order_Grid.Columns[0].Visible = false;



                    }
                    else
                    {

                        Order_Grid.DataSource = db.Purchase_orders.SqlQuery("select * from Purchase_orders where  Date>='" + StartdateTimePicker.Value.ToString("dd/ MM / yyyy") + "' and Date<='" + EnddateTimePicker.Value.ToString("dd/ MM / yyyy") + "' ", new SqlParameter("@invo", SearchtextBox.Text.Trim())).ToList<Purchase_orders>();
                        Order_Grid.Columns[0].Visible = false;



                    }


                }
                else
                {
                    if (PartyradioButton.Checked)
                    {

                        Order_Grid.DataSource = db.Selling_orders.SqlQuery("select * from Selling_orders where  Date>='" + StartdateTimePicker.Value.ToString("dd/ MM / yyyy") + "' and Date<='" + EnddateTimePicker.Value.ToString("dd/ MM / yyyy") + "' ", new SqlParameter("@party", SearchtextBox.Text.Trim())).ToList<Selling_orders>();
                        Order_Grid.Columns[0].Visible = true;
                        Order_Grid.Columns[0].HeaderText = "Invoice NO";
                        Order_Grid.Columns[2].Visible = false;



                    }
                    else
                    {

                        Order_Grid.DataSource = db.Selling_orders.SqlQuery("select * from Selling_orders where  Date>='" + StartdateTimePicker.Value.ToString("dd/ MM / yyyy") + "' and Date<='" + EnddateTimePicker.Value.ToString("dd/ MM / yyyy") + "' ", new SqlParameter("@invo", SearchtextBox.Text.Trim())).ToList<Selling_orders>();
                        Order_Grid.Columns[0].Visible = true;
                        Order_Grid.Columns[0].HeaderText = "Invoice NO";
                        Order_Grid.Columns[2].Visible = false;



                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
