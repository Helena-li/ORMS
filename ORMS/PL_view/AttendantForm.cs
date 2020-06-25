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

namespace ORMS.PL_view
{
    public partial class AttendantForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        public AttendantForm()
        {
            InitializeComponent();
        }

        private void AttendantForm_Load(object sender, EventArgs e)
        {
            idLabel.Text = Program.loginID.ToString();
            Employee s = ctr.getStaff(Program.loginID);
            string employeeName = s.Name;
            nameLabel.Text = employeeName;
            reset();
        }

        private void reset()
        {
            bindingDateGridView();
            tableIDTextBox.Clear();
            //// CusromerNameTextBox.Clear();
        }

        private void bindingDateGridView()
        {
            var orderList = ctr.getOrderList();
            OderListGridView.DataSource = orderList;
        }
        private void bindingDateGridView(int uid)
        {
            var orderList = ctr.getOrderListById(uid);
            OderListGridView.DataSource = orderList;
        }
        // search by id
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int uid = 0;
            try
            {
                uid = int.Parse(tableIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            bindingDateGridView(uid);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
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
        // open new order form
        private void ButtonNewOder_Click(object sender, EventArgs e)
        {
            NewOrderForm nof = new NewOrderForm();
            nof.Show();
        }
        // close order and display invoice form
        private void ButtonCloseOrder_Click(object sender, EventArgs e)
        {
            int tableId = 0;
            int orderID = 0;
            try
            {
                tableId = int.Parse(tableIDTextBox.Text);
                orderID = int.Parse(textBoxOrderID.Text);
            }
            catch
            {
                MessageBox.Show("Select one order first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string status = "Closed";
            if ((tableId != 0) && (orderID != 0))
            {
                Order o = new Order();
                o.OrderID = orderID;
                o.OrderStatus = status;
                o.TableID = tableId;
                ctr.closeOrder(o);
                reset();
                InvoiceForm inf = new InvoiceForm(o.OrderID);
                inf.Show();
            }
            else
            {
                MessageBox.Show("Order id or table Id should not be zero", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
        //display new order form once click
        private void OderListGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bid = int.Parse(this.OderListGridView.CurrentRow.Cells[0].Value.ToString());
            NewOrderForm bkf = new NewOrderForm(bid);
            bkf.ShowDialog();
        }

    }
}
