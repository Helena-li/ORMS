using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMS.BLL;

namespace ORMS.Reports
{
    public partial class SalesReportForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        ORMSDBDataContext db = new ORMSDBDataContext();
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oRMSDataSet2.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.oRMSDataSet2.Invoice);
            this.reportViewerSales.RefreshReport();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DateTime invoiceTime = dateTimePicker1.Value;
            Microsoft.Reporting.WinForms.ReportDataSource r = new Microsoft.Reporting.WinForms.ReportDataSource();
            r.Name = "DataSet1";
            r.Value = ctr.getSalesByTime(invoiceTime);
            this.reportViewerSales.LocalReport.DataSources.Clear();

            reportViewerSales.LocalReport.DataSources.Add(r);
            this.reportViewerSales.LocalReport.ReportPath = "C:/Users/cyanolive/source/repos/ORMS/ORMS/Reports/SalesReport.rdlc";
            this.reportViewerSales.RefreshReport();
        }
    }
}
