using demo.classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace demo.UI
{
    public partial class Add_brand : Form
    {
        DBAccess objdb = new DBAccess();
        DataTable brand, category;
        public Add_brand()
        {
            InitializeComponent();
        }
        private void brand_category_tbl()
        {
            brand = objdb.read_adapter("select * from brand", new DataTable());
            category = objdb.read_adapter("select * from category", new DataTable());
            comboBox1.DataSource = brand;
            comboBox1.DisplayMember = "company_brand";
            comboBox2.DataSource = category;
            comboBox2.DisplayMember = "category";

        }
        private void Add_brand_Load(object sender, EventArgs e)
        {


            brand_category_tbl();
        }

        private void sumit_Click(object sender, EventArgs e)
        {
            int a, b;
            if (textBox1.Text != "" && textBox1.Text.Trim() != null && textBox1.Text != "Enter new brand name"&&(!String.IsNullOrWhiteSpace(textBox1.Text)))
            {
                SqlCommand cmd = new SqlCommand("insert into brand(company_brand) values(@brand)");
                cmd.Parameters.AddWithValue("@brand", textBox1.Text);
                a = objdb.executeQuery(cmd);
                if (a == 1)
                {
                    textBox1.Text = "";
                    MessageBox.Show("company added successfully", "add company", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error occured Try again....", "add company", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (textBox2.Text != "" && textBox2.Text.Trim() != null && textBox2.Text != "Enter new Party"&&(String.IsNullOrWhiteSpace(textBox2.Text)))
            {
                SqlCommand cmd1 = new SqlCommand("insert into category(category) values(@cat)");
                cmd1.Parameters.AddWithValue("@cat", textBox2.Text);
                b = objdb.executeQuery(cmd1);
                if (b == 1)
                {
                    textBox2.Text = "";
                    MessageBox.Show("category added successfully", "add category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error occured Try again....", "add category", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


            brand_category_tbl();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                objdb.delete_brand_category_tbl(comboBox2.Text, false, true);
                brand_category_tbl();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter new brand name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox1.Equals("") || textBox1.Text == null)
            {
                textBox1.Text = "Enter new brand name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter new Party")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Equals("") || textBox2.Text == null)
            {
                textBox2.Text = "Enter new Party";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void general_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Add_brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                objdb.delete_brand_category_tbl(comboBox1.Text, true, false);
                brand_category_tbl();

            }
        }
    }
}
