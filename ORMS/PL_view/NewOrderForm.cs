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
    public partial class NewOrderForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        int orderID = 0;
        public NewOrderForm()
        {
            InitializeComponent();
        }
        public NewOrderForm(int id)
        {
            InitializeComponent();
            orderID = id;
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            bindingDateGridView();
            orderDateGridView(orderID);
            textBoxMenuID.Clear();
            textBoxDish.Clear();
            textBoxQuantity.Clear();
            tableIDTextBox.Clear();
            TableStatusTextBox.Clear();
        }

        private void bindingDateGridView()
        {
            var menuList = ctr.getMenuList();
            MenuListGridView.DataSource = menuList;
        }

        private void bindingDateGridView(string name)
        {
            var menuList = ctr.getMenuListByName(name);
            MenuListGridView.DataSource = menuList;
        }

        private void orderDateGridView(int id)
        {
            var orderList = ctr.getOrderItemListById(id);
            OderListGridView.DataSource = orderList;
        }

        private void bindingDateGridView(int uid)
        {
            var menuList = ctr.getMenuListById(uid);
            MenuListGridView.DataSource = menuList;
        }
        // observer design pattern
        // point event
        private void ButtonSetTable_Click(object sender, EventArgs e)
        {
            TableManagement tm = new TableManagement();
            tm.tableCheck += new TableHandler(TMForm_ButtonClicked);
            tm.Show();
        }
        // invoke event
        private void TMForm_ButtonClicked(object sender, TableEventArgs e)
        {
            tableIDTextBox.Text = e.TableID;
            TableStatusTextBox.Text = e.TableStatus;
        }
        // can search by id or name
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int bid = 0;
            try
            {
                bid = int.Parse(textBoxMenuID.Text);
            }
            catch
            {
                MessageBox.Show("Select one order first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (bid>0)
            {
                bindingDateGridView(bid);
            }
            else
            {
                if (textBoxDish.Text.Length>1)
                {
                    bindingDateGridView(textBoxDish.Text);
                }
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        //save table :add table or change table status
        private void ButtonSaveTable_Click(object sender, EventArgs e)
        {
            TableNumber tn = new TableNumber();
            int bid = 0;
            try
            {
                bid = int.Parse(tableIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Select one order first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string status = TableStatusTextBox.Text;
            tn.TableID = bid;
            tn.Status = status;
            ctr.updateTable(tn);
            MessageBox.Show("Changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // click this button before order
        private void ButtonStartOrder_Click(object sender, EventArgs e)
        {
            int tableId = 0;
            int employeeID = 0;
            try
            {
                tableId = int.Parse(tableIDTextBox.Text);
                employeeID = int.Parse(Program.loginID.ToString());
            }
            catch
            {
                MessageBox.Show("Select one order first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string status = TableStatusTextBox.Text;
            if ((tableId != 0) && (employeeID != 0) && (status.Length > 0))
            {
                Order order = new Order();
                order.TableID = tableId;
                order.OrderStatus = "Open";
                order.EmployeeID = employeeID;
                orderID = ctr.addOrder(order);
            }
        }
        //CRUD order item
        private void ButtonADD_Click(object sender, EventArgs e)
        {
            int bid = 0;
            int num = 0;
            try
            {
                bid = int.Parse(textBoxMenuID.Text);
                num = int.Parse(textBoxQuantity.Text);
            }
            catch
            {
                MessageBox.Show("Select one menu and table first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if ((bid != 0) && (num != 0) && (orderID != 0))
            {
                OrderItem orderItem = new OrderItem();
                orderItem.MenuID = bid;
                orderItem.Quantity = num;
                orderItem.OrderID = orderID;
                bool addResult = ctr.addOrderItem(orderItem);
                if (addResult)
                {
                    orderDateGridView(orderID);
                }
                else
                {
                    MessageBox.Show("Stock not enough, order failed.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select one menu and table first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //if ((bid == 0) || (num == 0) || (orderID == 0))
        //{
        //    throw new ArgumentException("Please input MenuID, quantity and orderID first");
        //}

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int menuId = 0;
            int quantity = 0;
            int orderItemId = 0;
            try
            {
                menuId = int.Parse(textBoxMenuID.Text);
                quantity = int.Parse(textBoxQuantity.Text);
                orderItemId = int.Parse(textBoxOrderItemID.Text);
            }
            catch
            {
                MessageBox.Show("Select one order item first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            if ((menuId != 0) && (quantity != 0) &&(orderItemId!=0) && (orderID!=0))
            {
                OrderItem oi = new OrderItem();
                oi.ID = orderItemId;
                oi.MenuID = menuId;
                oi.Quantity = quantity;
                oi.OrderID = orderID;
                bool updateResult= ctr.updateOrderItem(oi);
                if (updateResult)
                {
                    orderDateGridView(orderID);
                    reset();
                }
                else
                {
                    MessageBox.Show("Stock not enough, order failed.", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select one order item first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Order item will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(textBoxOrderItemID.Text);
                ctr.deleteOrderItem(bid);
                MessageBox.Show("Menu Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one menu first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
            orderDateGridView(orderID);
        }

        private void OderListGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedID = int.Parse(this.OderListGridView.CurrentRow.Cells[0].Value.ToString());
            textBoxOrderItemID.Text = this.OderListGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxMenuID.Text = this.OderListGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxDish.Text = this.OderListGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxQuantity.Text = this.OderListGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void MenuListGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxMenuID.Text = this.MenuListGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxDish.Text = this.MenuListGridView.CurrentRow.Cells[1].Value.ToString();

        }

    }
}
