using CrystalDecisions.CrystalReports.Engine;
using demo.report.crystalreport;
using System;
using System.Data;
using System.Windows.Forms;

namespace demo.UI
{
    public partial class reportForm : Form
    {
        private DataTable dataTable;
        private int report_No;
        private string party;
        private string terms_and_codition;

        public reportForm(DataTable dataTable, int report_no)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.report_No = report_no;



        }


        public reportForm(DataTable dataTable, int report_no, string party, string term)
        {
            InitializeComponent();
            this.dataTable = dataTable;

            this.report_No = report_no;
            this.party = party;
            this.terms_and_codition = term;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            if (report_No == 1)
            {
                Purchase_orderCrystalReport purchase = new Purchase_orderCrystalReport();
                purchase.Database.Tables["PurchaseDataTable1"].SetDataSource(dataTable);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = purchase;
            }
            else if (report_No == 2)
            {
                Selling_orderCrystalReport sell = new Selling_orderCrystalReport();
                sell.Database.Tables["SellingDataTable"].SetDataSource(dataTable);
                TextObject Party = (TextObject)sell.ReportDefinition.Sections["Section1"].ReportObjects["Buyer_Name"];
                TextObject invoice = (TextObject)sell.ReportDefinition.Sections["Section1"].ReportObjects["invoice"];
                Party.Text = this.party;
                invoice.Text = this.terms_and_codition;
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sell;
            }
            else if (report_No == 3)
            {
                QuotationCrystalReport quotation = new QuotationCrystalReport();
                quotation.Database.Tables["QuotationDataTable"].SetDataSource(dataTable);
                TextObject Party = (TextObject)quotation.ReportDefinition.Sections["Section1"].ReportObjects["Party_Name"];
                TextObject term = (TextObject)quotation.ReportDefinition.Sections["Section4"].ReportObjects["Terms"];
                term.Text = this.terms_and_codition;
                Party.Text = this.party;
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = quotation;
            }
            else if (report_No == 4)
            {
                OrderDetailsCrystalReport order_details = new OrderDetailsCrystalReport();
                order_details.Database.Tables["OrderDetails"].SetDataSource(dataTable);
                TextObject Party = (TextObject)order_details.ReportDefinition.Sections["Section1"].ReportObjects["Buyer_Name"];
                TextObject invoice = (TextObject)order_details.ReportDefinition.Sections["Section1"].ReportObjects["invoice"];
                Party.Text = this.party;
                invoice.Text = this.terms_and_codition;
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = order_details;
            }







        }

        private void reportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
