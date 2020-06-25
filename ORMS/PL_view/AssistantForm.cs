using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMS.Reports;

namespace ORMS.PL_view
{
    public partial class AssistantForm : Form
    {
        public AssistantForm()
        {
            InitializeComponent();
        }
        // open inventory, supplier management form
        //logout and exit
        //generate report
        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inf = new InventoryForm();
            inf.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
                this.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButtonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm();
            supplier.Show();
        }

        private void ButtonMenuReport_Click(object sender, EventArgs e)
        {
            MenuReportForm mrf = new MenuReportForm();
            mrf.Show();
        }

        private void ButtonInventoryReport_Click(object sender, EventArgs e)
        {
            InventoryReportForm irf = new InventoryReportForm();
            irf.Show();
        }

        private void ButtonSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm srf = new SalesReportForm();
            srf.Show();
        }

        private void ButtonPayroll_Click(object sender, EventArgs e)
        {
            PayrollReportForm prf = new PayrollReportForm();
            prf.Show();
        }
    }
}
