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
    public partial class PayrollReportForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        ORMSDBDataContext db = new ORMSDBDataContext();
        public PayrollReportForm()
        {
            InitializeComponent();
        }

        private void PayrollReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oRMSDataSet3.Payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.oRMSDataSet3.Payroll);

            this.reportViewerPayroll.RefreshReport();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DateTime payrollTime = dateTimePicker1.Value;
            Microsoft.Reporting.WinForms.ReportDataSource r = new Microsoft.Reporting.WinForms.ReportDataSource();
            r.Name = "DataSet1";
            r.Value = ctr.getPayrollsByTime(payrollTime);
            this.reportViewerPayroll.LocalReport.DataSources.Clear();

            reportViewerPayroll.LocalReport.DataSources.Add(r);
            this.reportViewerPayroll.LocalReport.ReportPath = "C:/Users/cyanolive/source/repos/ORMS/ORMS/Reports/PayrollReport.rdlc";
            this.reportViewerPayroll.RefreshReport();
        }
    }
}
