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
/// <summary>
/// all the functions and reports
/// </summary>
namespace ORMS.PL_view
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ButtonOrdermanage_Click(object sender, EventArgs e)
        {
            AttendantForm af = new AttendantForm();
            af.Show();
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm mmf = new ManageMenuForm();
            mmf.Show();
        }

        private void ButtonEandP_Click(object sender, EventArgs e)
        {
            HrForm hf = new HrForm();
            hf.Show();
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inf = new InventoryForm();
            inf.Show();
        }

        private void ButtonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm sf = new SupplierForm();
            sf.Show();
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

        private void ButtonSaleReport_Click(object sender, EventArgs e)
        {
            SalesReportForm srf = new SalesReportForm();
            srf.Show();
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

        private void ButtonPayrollReport_Click(object sender, EventArgs e)
        {
            PayrollReportForm pr = new PayrollReportForm();
            pr.Show();
        }
    }
}
