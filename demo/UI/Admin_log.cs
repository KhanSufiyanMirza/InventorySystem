using demo.classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class Admin_log : Form
    {
        public static bool staticlog = false;
        public static string Id = null;
        DBAccess db = new DBAccess();
        DataTable logintbl = new DataTable();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["patel_motors"].ConnectionString);


        public Admin_log()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            lock (this)
            {


                if (user.Equals("") || user.Text == null)
                {
                    DialogResult dia = MessageBox.Show("please enter your username:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dia == DialogResult.OK)
                    {
                        user.Focus();
                    }
                }

                else if (pass.Equals("") || pass.Text == null)
                {
                    DialogResult dia = MessageBox.Show("please enter your password:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dia == DialogResult.OK)
                    {
                        pass.Focus();
                    }
                }

                db.Read_Data(user.Text, pass.Text, logintbl);
                // string query = "select* from admin_login where username='" + user.Text + "' and pass ='" + pass.Text + "'";
                // db.Admin_login(user.Text, pass.Text, logintbl);
                // db.readDatathroughAdapter(query, logintbl);
                //SqlDataAdapter da = new SqlDataAdapter("select * from admin_login where username=@Name and pass=@password", conn);
                //da.SelectCommand.Parameters.AddWithValue("@Name", user.Text);
                //da.SelectCommand.Parameters.AddWithValue("@password", pass.Text);
                //da.Fill(logintbl);


                if (logintbl.Rows.Count == 1)
                {
                    Admin_log.Id = logintbl.Rows[0]["admin_id"].ToString();
                    Admin_log.staticlog = true;
                    DialogResult dr = MessageBox.Show("Congratulation,login successful", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        pass.Clear();
                        user.Clear();
                        this.Close();


                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid info", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void user_Enter(object sender, EventArgs e)
        {
            user.Text = "";
            toolTip1.Show("Enter your username", user);

        }

        private void user_Leave(object sender, EventArgs e)
        {
            pass.Text = "";
            toolTip1.Hide(user);
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            toolTip1.Hide(pass);
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter your password", pass);
        }

      

        private void pass_Click(object sender, EventArgs e)
        {
            pass.Text = "";
            pass.UseSystemPasswordChar = true;

        }

        private void user_Click(object sender, EventArgs e)
        {
            user.Text = "";
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            if (user.Equals("") || user.Text == null)
            {
                DialogResult dia = MessageBox.Show("please enter your username:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dia == DialogResult.OK)
                {
                    user.Focus();
                }
            }

            else if (pass.Equals("") || pass.Text == null)
            {
                DialogResult dia = MessageBox.Show("please enter your password:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dia == DialogResult.OK)
                {
                    pass.Focus();
                }
            }

            db.Read_Data(user.Text, pass.Text, logintbl);
            // string query = "select* from admin_login where username='" + user.Text + "' and pass ='" + pass.Text + "'";
            // db.Admin_login(user.Text, pass.Text, logintbl);
            // db.readDatathroughAdapter(query, logintbl);
            //SqlDataAdapter da = new SqlDataAdapter("select * from admin_login where username=@Name and pass=@password", conn);
            //da.SelectCommand.Parameters.AddWithValue("@Name", user.Text);
            //da.SelectCommand.Parameters.AddWithValue("@password", pass.Text);
            //da.Fill(logintbl);


            if (logintbl.Rows.Count == 1)
            {
                Admin_log.staticlog = true;
                DialogResult dr = MessageBox.Show("Congratulation,login successful", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Please enter valid info", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            pass.Focus();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            user.Focus();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (user.Text=="Username")
            {
                user.Text = "";
            }
        }

       

        private void user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.PerformClick();
            }
        }

        private void Admin_log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
