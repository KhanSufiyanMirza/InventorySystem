using demo.classes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace demo.UI
{
    public partial class User_products : Form
    {
        DBAccess db = new DBAccess();
        DataSet ds = new DataSet();
        DataTable dummy = new DataTable();
        private DataTable listtable = new DataTable();
        DataTable dtcat;
        MemoryStream ms;
        byte[] photo_aray;
        public User_products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells["SelectForCopy"].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells["pro_id_grid2"].Value = item.Cells["pro_id"].Value.ToString();
                    dataGridView2.Rows[n].Cells["pro_name_grid2"].Value = item.Cells["pro_name"].Value.ToString();
                    dataGridView2.Rows[n].Cells["basic_price_grid2"].Value = item.Cells["basic_price"].Value.ToString();
                    dataGridView2.Rows[n].Cells["gst_grid2"].Value = item.Cells["gst"].Value.ToString();
                    dataGridView2.Rows[n].Cells["purchase_p_grid2"].Value = item.Cells["purchase_p"].Value.ToString();
                    dataGridView2.Rows[n].Cells["sell_p_grid2"].Value = item.Cells["sell_p"].Value.ToString();
                    dataGridView2.Rows[n].Cells["mrp_grid2"].Value = item.Cells["mrp"].Value.ToString();
                    // dataGridView2.Rows[n].Cells["pro_qty_grid2"].Value = item.Cells["pro_qty"].Value.ToString();
                    dataGridView2.Rows[n].Cells["quantity_type_grid2"].Value = item.Cells["quantity_type"].Value.ToString();
                    // dataGridView2.Rows[n].Cells["pro_cat"].Value = item.Cells["pro_cat_grid2"].Value.ToString();

                }
            }
            //if (comboBox2.Text != null && comboBox2.SelectedIndex > -1)
            // {
            //     try
            //     {
            //         dummy = listtable.Select("id='" + dtcat.Rows[comboBox2.SelectedIndex]["id"] + "'").CopyToDataTable();
            //         if (dummy.Rows.Count > 0)
            //         {

            //         }
            //         else
            //         {
            //             listtable.ImportRow(dtcat.Rows[comboBox2.SelectedIndex]);
            //         }
            //     }
            //     catch (Exception)
            //     {
            //         listtable.ImportRow(dtcat.Rows[comboBox2.SelectedIndex]);

            //     }






            //     //listtable= dtcat.Rows[comboBox2.SelectedIndex].Table.Copy();


            // }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {

                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                Quation_txt.Clear();
                terms_and_conditon.Clear();


            }

        }


        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.Text != null && comboBox2.SelectedIndex != -1)
            {
                pictureBox1.Image = null;
                label6.Visible = true;
                label7.Visible = true;
                label6.Text = dtcat.Rows[comboBox2.SelectedIndex]["sell_price"].ToString() + " Rs";
                label7.Text = "purchase price :'" + dtcat.Rows[comboBox2.SelectedIndex]["purchase_price"].ToString() + "' Rs";
                product_name.Text = "Product Name :'" + dtcat.Rows[comboBox2.SelectedIndex]["product_name"].ToString() + "'";
                if (dtcat.Rows[comboBox2.SelectedIndex]["product_img"] != DBNull.Value /*&& dtcat.Rows[comboBox2.SelectedIndex]["product_img"].ToString()==null*/)
                {
                    photo_aray = (byte[])dtcat.Rows[comboBox2.SelectedIndex]["product_img"];

                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            dtcat = ds.Tables["product"].Select("brand='" + ds.Tables["brand"].Rows[comboBox1.SelectedIndex]["brand"] + "'").CopyToDataTable();
            comboBox2.DataSource = dtcat;
            comboBox2.DisplayMember = "product_category";


        }



        private void button4_Click(object sender, EventArgs e)
        {
            string cmd;
            if (party_check.Checked)
            {
                invo_check.Checked = false;
                cmd = "select * from products where product_category like '%'+@pro+'%' order by purchase_price ASC; select distinct brand from products where product_category like '%'+@pro+'%' ";
            }
            else if (invo_check.Checked)
            {
                cmd = "select * from products where invoice like '%'+@pro+'%' order by purchase_price ASC; select distinct brand from products where invoice like '%'+@pro+'%' ";
            }
            else
            {
                cmd = "select * from products where product_name like '%'+@pro+'%' order by purchase_price ASC; select distinct brand from products where product_name like '%'+@pro+'%' ";
            }

            // dt = db.DatathroughDataAdapter(cmd, new DataTable(), textBox1.Text);
            ds = db.Dataset_data(cmd, textBox1.Text);
            ds.Tables[0].TableName = "product";
            ds.Tables[1].TableName = "brand";
            comboBox1.DataSource = ds.Tables["brand"];
            comboBox1.DisplayMember = "brand";
            dataGridView1.DataSource = ds.Tables["product"];
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["SelectForCopy"].Value = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void User_products_Load(object sender, EventArgs e)
        {

            //listBox1.DataSource = listtable;
            //listBox1.DisplayMember = "product_name";
            // dataGridView2.DataSource = listtable;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(my_KeyPress);
            if (dataGridView2.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(my_KeyPress);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {



            if (dataGridView2.Rows != null && dataGridView2.Rows.Count > 0 && Quation_txt.Text.Trim() != "" && String.IsNullOrWhiteSpace(Quation_txt.Text) != true && Quation_txt.Text.Trim().Length > 0)
            {
                reportForm report = new reportForm(GetDataTable(), 3, Quation_txt.Text == null ? "" : Quation_txt.Text, terms_and_conditon.Text == null ? "" : terms_and_conditon.Text);
                report.Show();

            }


        }
        public DataTable GetDataTable()
        {
            DataTable dtLocalC = new DataTable();
            dtLocalC.Columns.Add("Product Name");
            dtLocalC.Columns.Add("Quantity", typeof(decimal));
            dtLocalC.Columns.Add("GST");
            dtLocalC.Columns.Add("HSNCODE");
            dtLocalC.Columns.Add("Rate", typeof(decimal));
            dtLocalC.Columns.Add("Per");





            DataRow drLocal = null;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                drLocal = dtLocalC.NewRow();
                if (row.Cells["pro_name_grid2"].Value != null && dataGridView2.Rows.Count > 0)
                {
                    drLocal["Product Name"] = row.Cells["pro_name_grid2"].Value.ToString();
                    drLocal["Quantity"] = row.Cells["pro_qty_grid2"].Value == null ? 0 : Convert.ToDecimal(row.Cells["pro_qty_grid2"].Value);
                    drLocal["GST"] = row.Cells["gst_grid2"].Value.ToString();
                    drLocal["HSNCODE"] = row.Cells["Hsn_code"].Value == null ? "" : row.Cells["Hsn_code"].Value.ToString();
                    drLocal["Rate"] = Convert.ToDecimal(row.Cells["purchase_p_grid2"].Value);


                    drLocal["Per"] = row.Cells["quantity_type_grid2"].Value.ToString();


                    dtLocalC.Rows.Add(drLocal);

                }


            }

            return dtLocalC;
        }
        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // e.Row.Cells["user_qgrid2"].Value = 1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dataGridView2.CurrentCell.ColumnIndex.ToString());
        }

        /*  private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
           {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow dgc = dataGridView1.CurrentRow;
                    if (dgc.Cells["pro_qty"].Value != null)
                    {
                        if (Convert.ToInt32(dgc.Cells["User_qty"].Value) > Convert.ToInt32(dgc.Cells["pro_qty"].Value))
                        {
                            if (MessageBox.Show("User Quantity is more than available quantity \n" +
                            "you want available quantity ", "available quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                dgc.Cells["User_qty"].Value = dgc.Cells["pro_qty"].Value;
                                int amount = Convert.ToInt32(dgc.Cells["User_qty"].Value) * Convert.ToInt32(dgc.Cells["sell_p"].Value);
                                dgc.Cells["Total"].Value = amount.ToString();
                            }

                        }
                        else
                        {
                            int amount = Convert.ToInt32(dgc.Cells["User_qty"].Value) * Convert.ToInt32(dgc.Cells["sell_p"].Value);
                            dgc.Cells["Total"].Value = amount.ToString();
                        }

                    }


                }
           }*/


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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 /*&& dataGridView1.Rows!=null*/)
            {
                if ((bool)dataGridView1.SelectedRows[0].Cells["SelectForCopy"].Value == false)
                {
                    dataGridView1.SelectedRows[0].Cells["SelectForCopy"].Value = true;
                }
                else
                {
                    dataGridView1.SelectedRows[0].Cells["SelectForCopy"].Value = false;
                }
            }

        }

        /*  private void PatelprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
          {
              Bitmap bmp = Properties.Resources.address;
              Image newimg = bmp;
              string dash = "************************************************************************************************************************";
              e.Graphics.DrawImage(newimg, 25, 25, newimg.Width, newimg.Height);
              e.Graphics.DrawString("TO", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 180));
              e.Graphics.DrawString(Quation_Party.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 205));
              e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 225));
              e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 265));
              e.Graphics.DrawString("SNO ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 295));
              e.Graphics.DrawString("Product Discription", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(80, 295));
              e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(270, 295));
              e.Graphics.DrawString("Gst", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, 295));
              e.Graphics.DrawString("HSN CODE ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 295));
              e.Graphics.DrawString("Rate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 295));

              e.Graphics.DrawString("Per ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(650, 295));
              e.Graphics.DrawString("Amount ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(720, 295));

              e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 325));
              if (dataGridView2.Rows != null && dataGridView2.Rows.Count > 0)
              {
                  int no = 1;
                  int yindex = 12;
                  foreach (DataGridViewRow item in this.dataGridView2.Rows)
                  {
                      if (item.Cells["pro_name_grid2"].Value == null && item.Cells["gst_grid2"].Value == null && item.Cells["basic_price_grid2"].Value == null)
                      {

                      }
                      else
                      {

                          e.Graphics.DrawString(no.ToString(), new Font("Arial", 12), Brushes.Black, new Point(35, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["pro_name_grid2"].Value == null ? "Not mentioned" : item.Cells["pro_name_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(90, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["desc"].Value == null ? "0" : item.Cells["desc"].Value.ToString() + "%", new Font("Arial", 12), Brushes.Black, new Point(90, 365 + yindex));
                          e.Graphics.DrawString(item.Cells["pro_qty_grid2"].Value == null ? "0" : item.Cells["pro_qty_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(250, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["gst_grid2"].Value == null ? "0" : item.Cells["gst_grid2"].Value.ToString() + "%", new Font("Arial", 12), Brushes.Black, new Point(360, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["Hsn_code"].Value == null ? "0" : item.Cells["Hsn_code"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(460, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["sell_p_grid2"].Value == null ? "0" : item.Cells["sell_p_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(560, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["quantity_type_grid2"].Value == null ? "0" : item.Cells["quantity_type_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(660, 345 + yindex));
                          // e.Graphics.DrawString((Convert.ToDecimal(item.Cells["pro_qty_grid2"].Value) * Convert.ToDecimal(item.Cells["sell_p_grid2"].Value)).ToString(), new Font("Arial", 12), Brushes.Black, new Point(730, 345 + yindex));
                          e.Graphics.DrawString(item.Cells["total_grid2"].Value == null ? "0" : item.Cells["total_grid2"].Value.ToString(), new Font("Arial", 12), Brushes.Black, new Point(730, 345 + yindex));


                          no++;
                          yindex = yindex + 45;

                      }


                  }

                  decimal sum = 0;
                  for (int i = 0; i < dataGridView2.Rows.Count; i++)
                  {
                      sum += Convert.ToDecimal(dataGridView2.Rows[i].Cells["total_grid2"].Value == null ? "0" : dataGridView2.Rows[i].Cells["total_grid2"].Value.ToString());
                  }
                  e.Graphics.DrawString(dash, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 980));
                  e.Graphics.DrawString("Total Amount : " + sum.ToString(), new Font("Arial", 12), Brushes.Black, new Point(600, 1000));


                  e.Graphics.DrawString("Terms & Condition ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 900));
                  e.Graphics.DrawString(terms_and_conditon.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Red, new Point(25, 920));
                  e.Graphics.DrawString("Thanks & Regards,", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 990));
                  e.Graphics.DrawString("Ideal Auto Distributor", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 1010));
                  e.Graphics.DrawString("Bima Complex,Kalamoboli", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 1030));
                  e.Graphics.DrawString("Mo.9890949578", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 1050));
              }

          }
  */
        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(dataGridView2.CurrentCell.ColumnIndex.ToString());
        }

        private void User_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
