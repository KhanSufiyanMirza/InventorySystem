using demo.classes;
using demo.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class update_products : Form
    {
        int id = 0;
        product model = new product();
        Patel_motorsEntities db = new Patel_motorsEntities();
        DataTable brand, category;
        SqlCommand cmd;
        DBAccess Db = new DBAccess();
        DataSet ds = new DataSet();
        private DataTable listtable = new DataTable();
        DataTable dtcat;
        MemoryStream ms;
        byte[] photo_aray;
       // bool edit_yes;
        public update_products()
        {
            InitializeComponent();
        }
        void cat()
        {
            foreach (category item in db.categories)
            {
                Party_name_comboBox.Items.Add(item.category1);
            }
        }
        void brad()
        {
            foreach (brand item in db.brands)
            {
                Brand_comboBox.Items.Add(item.company_brand);
            }
        }
        void qty_type()
        {
            foreach (Quantity_Table item in db.Quantity_Table)
            {
                quantity_type_combox.Items.Add(item.Quantity_type);
            }
        }
        private void update_products_Load(object sender, EventArgs e)
        {
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
            // Party_name_comboBox.DataSource =db.categories.ToList<category>();

            Thread c = new Thread(() =>
              {
                  this.BeginInvoke((Action)delegate ()
                {
                    cat();
                });
              });
            c.Start();
            Thread b = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    brad();

                });
            });
            b.Start();
            Thread q = new Thread(() =>
            {
                this.BeginInvoke((Action)delegate ()
                {
                    qty_type();

                });
            });
            q.Start();

            //    Party_name_comboBox.DisplayMember = "category1";
            //    Brand_comboBox.DataSource = db.brands.ToList<brand>();
            //    Brand_comboBox.DisplayMember = "company_brand";
            //    quantity_type_combox.DataSource = db.Quantity_Table;
            //    quantity_type_combox.DisplayMember = "Quantity_type";
        }
        void ResetControls()
        {
            Product_name_textBox.Clear();
            Brand_comboBox.SelectedItem = null;
            Party_name_comboBox.SelectedItem = null;
            Mrp_textBox.Clear();
            Purchase_price_textBox.Clear();
            selling_price_textBox.Clear();
            Gst_textBox.Clear();
            Base_pricetextBox.Clear();
            textBox_quantity.Clear();
            quantity_type_combox.SelectedItem = null;
            Invoice_textBox.Clear();
            pictureBox1.Image = null;
        }

        private void Product_dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Product_dataGridView1.Rows.Count > 0)
            {
                id = Convert.ToInt32(Product_dataGridView1.SelectedRows[0].Cells[0].Value);
                model = db.products.Where(x => x.id == id).FirstOrDefault();
                Product_name_textBox.Text = model.product_name;
                Brand_comboBox.SelectedItem = model.brand;
                Party_name_comboBox.SelectedItem = model.product_category;
                Mrp_textBox.Text = model.MRP.ToString();
                Purchase_price_textBox.Text = model.purchase_price.ToString();
                selling_price_textBox.Text = model.sell_price.ToString();
                Gst_textBox.Text = model.Gst.ToString();
                Base_pricetextBox.Text = model.base_price.ToString();
                textBox_quantity.Text = model.product_quantity.ToString();
                quantity_type_combox.SelectedItem = model.Quantity_type;
                Invoice_textBox.Text = model.invoice.ToString();
                if (model.product_img != null)
                {
                    photo_aray = (byte[])model.product_img;

                    MemoryStream ms = new MemoryStream(photo_aray);
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }


        }
        void conv_photo()
        {
            //converting photo to binary data  
            if (pictureBox1.Image != null)
            {
                //using FileStream:(will not work while updating, if image is not changed)  
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);  
                //byte[] photo_aray = new byte[fs.Length];  
                //fs.Read(photo_aray, 0, photo_aray.Length);    

                //using MemoryStream:  
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }
        private void browse_img_Click(object sender, EventArgs e)
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
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);

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

        private void update_Click(object sender, EventArgs e)
        {
            if (id>0)
            {
                model.id = id;
                // model = db.products.Where(x => x.id == id).FirstOrDefault();
                model.product_name = Product_name_textBox.Text;
                model.brand = Brand_comboBox.SelectedItem.ToString();

                model.product_category = Party_name_comboBox.SelectedItem.ToString();
                model.MRP = Convert.ToDecimal(Mrp_textBox.Text);
                model.purchase_price = Convert.ToDecimal(Purchase_price_textBox.Text);
                model.sell_price = Convert.ToDecimal(selling_price_textBox.Text);
                model.Gst = Convert.ToDouble(Gst_textBox.Text);
                model.base_price = Convert.ToDecimal(Base_pricetextBox.Text);
                model.product_quantity = Convert.ToDouble(textBox_quantity.Text);
                model.Quantity_type = quantity_type_combox.SelectedItem.ToString();
                model.invoice = Invoice_textBox.Text;
                if (pictureBox1.Image != null)
                {

                    //using FileStream:(will not work while updating, if image is not changed)  
                    //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);  
                    //byte[] photo_aray = new byte[fs.Length];  
                    //fs.Read(photo_aray, 0, photo_aray.Length);    

                    //using MemoryStream:  
                    ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    model.product_img = photo_aray;


                }
                db.Entry(model).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Product details updated", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check.PerformClick();
                }
                else
                {
                    MessageBox.Show("Product details not updated", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ResetControls();


            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id>0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    model = db.products.Where(x => x.id == id).FirstOrDefault();
                    db.Entry(model).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Product Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Product Deletion failed", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControls();
            //Product_dataGridView1.Rows.Clear();
            //Product_dataGridView1.Refresh();

        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check.PerformClick();
            }
        }

        private void Base_pricetextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Gst_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void update_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            // string cmd = "select * from products where product_name like '%'+@pro+'%'; select distinct brand from products where product_name like '%'+@pro+'%' ";
            // // dt = db.DatathroughDataAdapter(cmd, new DataTable(), textBox1.Text);
            // ds = Db.Dataset_data(cmd, search_txt.Text);
            // ds.Tables[0].TableName = "product";
            // Product_dataGridView1.DataSource = ds.Tables["product"];
            if (search_txt.Text.Trim() != "" && search_txt.Text != null)
            {
                Product_dataGridView1.DataSource = db.products.SqlQuery("select * from products where product_name like '%'+@pro+'%'", new SqlParameter("@pro", search_txt.Text.Trim())).ToList<product>();
                ResetControls();
            }

            //ds.Tables[1].TableName = "brand";
            //comboBox1.DataSource = ds.Tables["brand"];
            //comboBox1.DisplayMember = "brand";
        }
    }
}
