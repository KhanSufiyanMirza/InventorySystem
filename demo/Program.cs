using System;
using System.Windows.Forms;

namespace demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HOMEPAGE());

            try
            {
               

            }
            catch (Exception)
            {


                MessageBox.Show("Invalid entry Please Try Again");
                try
                {
                    Application.Run(new HOMEPAGE());
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid entry Please Try Again");

                }

            }

        }
    }

    internal class Admin : Form
    {
    }
}
