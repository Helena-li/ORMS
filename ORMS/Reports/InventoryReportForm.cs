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
    public partial class InventoryReportForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        ORMSDBDataContext db = new ORMSDBDataContext();
        public InventoryReportForm()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            Microsoft.Reporting.WinForms.ReportDataSource r = new Microsoft.Reporting.WinForms.ReportDataSource();
            r.Name = "DataSet1";
            r.Value = ctr.getStockByName(name);
            this.reportViewerInventory.LocalReport.DataSources.Clear();

            reportViewerInventory.LocalReport.DataSources.Add(r);
            this.reportViewerInventory.LocalReport.ReportPath = "C:/Users/cyanolive/source/repos/ORMS/ORMS/Reports/InventoryReport.rdlc";
            this.reportViewerInventory.RefreshReport();

        }

        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oRMSDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.oRMSDataSet1.Inventory);

            this.reportViewerInventory.RefreshReport();
        }
    }
}
