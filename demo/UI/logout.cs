using System;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Admin_log.staticlog = false;
            Admin_log.Id = null;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void logout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
