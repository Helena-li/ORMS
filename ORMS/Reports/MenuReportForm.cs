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
    public partial class MenuReportForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        ORMSDBDataContext db = new ORMSDBDataContext();

        public MenuReportForm()
        {
            InitializeComponent();
        }

        private void MenuReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oRMSDataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.oRMSDataSet.Menu);
            bindingComboBox();
            comboBoxType.SelectedIndex = 0;
            this.reportViewerMenu.RefreshReport();
        }

        private void bindingComboBox()
        {
            List<string> category = new List<string>() { "Breakfast", "Lunch", "Drink" };
            foreach (var c in category)
            {
                comboBoxType.Items.Add(c);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string category = comboBoxType.Text;
            Microsoft.Reporting.WinForms.ReportDataSource r = new Microsoft.Reporting.WinForms.ReportDataSource();
            r.Name = "DataSet1";
            r.Value = ctr.getMenuByCategory(category);
            this.reportViewerMenu.LocalReport.DataSources.Clear();

            reportViewerMenu.LocalReport.DataSources.Add(r);
            this.reportViewerMenu.LocalReport.ReportPath = "C:/Users/cyanolive/source/repos/ORMS/ORMS/Reports/MenuReport.rdlc";
            this.reportViewerMenu.RefreshReport();

        }
    }
}
