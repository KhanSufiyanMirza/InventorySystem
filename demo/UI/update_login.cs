using demo.classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace demo.UI
{
    public partial class update_login : Form
    {
        DBAccess db = new DBAccess();
        public update_login()
        {
            InitializeComponent();
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            login.PerformClick();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            user.Focus();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user.Equals("") || user.Text.Trim() == null)
            {
                DialogResult dia = MessageBox.Show("please enter your new  username:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dia == DialogResult.OK)
                {
                    user.Focus();
                }
            }
            else
            if (pass.Equals("") || pass.Text.Trim() == null)
            {
                DialogResult dia = MessageBox.Show("please enter new password:", "add product", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dia == DialogResult.OK)
                {
                    pass.Focus();
                }

            }
            try
            {
                SqlCommand cmd = new SqlCommand("update admin_login set username=@name,pass=@password  where admin_id=@id");

                cmd.Parameters.AddWithValue("@name", user.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                cmd.Parameters.AddWithValue("@id", Admin_log.Id);
                int i = db.executeQuery(cmd);
                if (i == 1)
                {


                    MessageBox.Show("updated successfully", "add product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error occured Try again....", "add product", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }



        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            pass.Focus();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (user.Text == "Your New Username")
            {
                user.Text = "";
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pass.Text == "Your New Password")
            {
                pass.Text = "";
            }
        }

        private void update_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
