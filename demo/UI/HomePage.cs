using demo.UI;
using System;
using System.Windows.Forms;

namespace demo
{
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void UersForm_Load(object sender, EventArgs e)
        {
            //DateTime d1 = new DateTime(2019, 12, 16);
            //if (DateTime.Now >=d1)
            //{
            //    MessageBox.Show("License is  Expired ............ ","License ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    button1.Enabled = false;
            //    purchase_sell_add.Enabled = false;
            //    Selling_page.Enabled = false;
            //    login.Enabled = false;
            //    purchase_order.Enabled = false;
            //}


        }

        private void login_Click(object sender, EventArgs e)
        {
            move(login);
            bool IsOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Admin_log")
                {
                    IsOpen = true;
                    item.Focus();
                    item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    
                    item.Show();
                    break;
                }

            }
            if (IsOpen == false)
            {
                Admin_log log = new Admin_log();
                // tblayout log = new tblayout();
                //  Purchase_order log = new Purchase_order();
                log.Show();


            }


        }
        protected void move(Control btn)
        {
            panel2.Width = btn.Width;
            panel2.Left = btn.Left;
        }



        private void addbrand_Click(object sender, EventArgs e)
        {
            move(addbrand);
            Add_brand Brand = new Add_brand();
            Brand.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            move(button1);
            User_products userproduct = new User_products();
            userproduct.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            move(edit);
            // Edit_product ed = new Edit_product();



            bool IsOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "update_products")
                {
                    IsOpen = true;
                    item.Focus();
                    item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    break;
                }

            }
            if (IsOpen == false)
            {
                update_products ed = new update_products();
                ed.Show();

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            move(logout);


            bool IsOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "logout")
                {
                    IsOpen = true;
                    item.Focus();
                    item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    break;
                }

            }
            if (IsOpen == false)
            {
                logout lout = new logout();
                lout.Show();

            }

        }


        private void HOMEPAGE_Activated(object sender, EventArgs e)
        {


            if (Admin_log.staticlog)
            {
                edit.Visible = true;

                addbrand.Visible = true;
                logout.Visible = true;
                login.Visible = false;
                change.Visible = true;
            }
            else
            {
                change.Visible = false;
                edit.Visible = false;

                addbrand.Visible = false;
                logout.Visible = false;
                login.Visible = true;
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            move(change);
            bool IsOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "update_login")
                {
                    IsOpen = true;
                    item.Focus();
                    item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    break;
                }

            }
            if (IsOpen == false)
            {
                update_login ul = new update_login();
                ul.Show();
            }


        }

        private void purchase_sell_add_Click(object sender, EventArgs e)
        {
            try
            {
                move(purchase_sell_add);
                bool IsOpen = false;
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Text == "Purchase Selling Page")
                    {
                        IsOpen = true;
                        item.Focus();
                        item.WindowState = FormWindowState.Normal;
                        item.BringToFront();
                        break;
                    }

                }
                if (IsOpen == false)
                {
                    Update_insert ps = new Update_insert();
                    ps.Show();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please Check your connection");
            }
        }

        private void Selling_page_Click(object sender, EventArgs e)
        {
            move(Selling_page);
            bool IsOpen = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Selling_page")
                {
                    IsOpen = true;
                    item.Focus();
                    item.WindowState = FormWindowState.Normal;
                    item.BringToFront();
                    break;
                }

            }
            if (IsOpen == false)
            {
                Selling_page sell = new Selling_page();
                sell.Show();

            }

        }

        private void purchase_order_Click(object sender, EventArgs e)
        {
            move(purchase_order);
            Purchase_order log = new Purchase_order();
            //Form1 log = new Form1();
            log.Show();
        }

        private void HOMEPAGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Are you sure you want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { this.Close(); }
            }
        }

        private void Order_history_Click(object sender, EventArgs e)
        {
            Purchse_Selling_Orders orders = new Purchse_Selling_Orders();
            orders.Show();
        }
    }
}
