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

    public partial class InventoryForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        List<string> notify;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            bindingDateGridView();
            restoreDateGridView();
            IDTextBox.Clear();
            textBoxName.Clear();
            quantityTextBox.Clear();
            conductTimePicker.Value = DateTime.Today;
            empIDTextBox.Clear();
            textBoxMax.Clear();
            notify = ctr.getEmptyStock();
            var stocksName = "";
            if (notify.Count>0)
            {
                // use iterator 
                foreach (var item in notify)
                {
                    stocksName += item + " " + "+";
                }
                labelNotify.Text = stocksName + "is empty now, need to restore.\n";
            }
            else
            {
                labelNotify.Text = "All items are in stock. ";
            }
        }

        private void restoreDateGridView()
        {
            var stockList = ctr.getInventoryRestoreList();
            dataGridViewRestore.DataSource = stockList;
        }

        private void bindingDateGridView()
        {
            var stockList = ctr.getInventoryList();
            InventoryGridView.DataSource = stockList;
        }

        private void bindingDateGridView(int id)
        {
            var stockList = ctr.getInventoryListByID(id);
            InventoryGridView.DataSource = stockList;
        }
        // CRUD inventory
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDTextBox.Text);
                bindingDateGridView(id);
            }
            catch (Exception)
            {
                MessageBox.Show("You can only search by stock ID.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private Inventory getStockItem()
        {
            int empId = 0;
            int quantity = 0;
            int max = 0;
            try
            {
                empId = int.Parse(empIDTextBox.Text);
                quantity = int.Parse(quantityTextBox.Text);
                max = int.Parse(textBoxMax.Text); 
            }
            catch
            {
                MessageBox.Show("Input employee ID first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            string name = textBoxName.Text;
            DateTime conductTime = conductTimePicker.Value;
            Inventory inv = new Inventory();
            inv.StockName = name;
            inv.RestockQuantity = quantity;
            inv.ConductTime = conductTime;
            inv.EmployeeID = empId;
            inv.MaxQuantity = max;
            return inv;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = getStockItem();
            if (inventory == null)
            {
                MessageBox.Show("Add failed!\n  ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = ctr.addStock(inventory);
            MessageBox.Show("Add success!\n Your user ID is " + id.ToString(),
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = getStockItem();
            try
            {
                inventory.StockID = int.Parse(IDTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input stock ID first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (inventory == null)
            {
                MessageBox.Show("Update failed!\n  ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ctr.updateStock(inventory);
            MessageBox.Show("Update success!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Stock will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(IDTextBox.Text);
                ctr.deleteStock(bid);
                MessageBox.Show("Stock Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one stock first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
        }
        // open the supplier form for the specific stock item
        private void ButtonSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDTextBox.Text);
                SupplierInventoryForm sif = new SupplierInventoryForm(id);
                sif.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Select one stock first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void InventoryGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDTextBox.Text = this.InventoryGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = this.InventoryGridView.CurrentRow.Cells[1].Value.ToString();
            quantityTextBox.Text = this.InventoryGridView.CurrentRow.Cells[2].Value.ToString();
            conductTimePicker.Value = DateTime.Parse(this.InventoryGridView.CurrentRow.Cells[3].Value.ToString());
            empIDTextBox.Text = this.InventoryGridView.CurrentRow.Cells[4].Value.ToString();
            textBoxMax.Text = this.InventoryGridView.CurrentRow.Cells[5].Value.ToString();
        }
        //observer design pattern
        // observer
        // update status by observer
        public void ReceiveAndNotify(object obj)
        {
            StockBLL sbp = obj as StockBLL;
            if (sbp != null)
            {
                labelNotify.Text += sbp.StockID.ToString() + "is empty now, need to restore.\n";

                labelNotify.Visible = true;
            }
        }
    }
}
