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
    public partial class SupplierInventoryForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        int stockID = 0;
        public SupplierInventoryForm(int id)
        {
            InitializeComponent();
            stockID = id;
        }

        private void SupplierInventoryForm_Load(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            textBoxID.Clear();
            SupplierTextBox.Clear();
            textBoxStock.Text = stockID.ToString();
            var stockList = ctr.getStockListByID(stockID);
            InventoryGridView.DataSource = stockList;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private SupplierInventory getSupplierInventoryItem()
        {
            int supID = 0;
            try
            {
                supID = int.Parse(SupplierTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input supplier ID first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            SupplierInventory si = new SupplierInventory();
            si.ItemID = stockID;
            si.SupplierID = supID;
            return si;
        }

        //CRUD supplier for specific stock item
        private void AddButton_Click(object sender, EventArgs e)
        {
            SupplierInventory si = getSupplierInventoryItem();
            int id = ctr.addSupplierInventory(si);
            MessageBox.Show("Add success!\n Your user ID is " + id.ToString(),
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SupplierInventory si = getSupplierInventoryItem();
            try
            {
                si.ID = int.Parse(textBoxID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input supplier ID first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            ctr.updateSupplierInventory(si);
            MessageBox.Show("Update success!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Supplier will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(textBoxID.Text);
                ctr.deleteSupplierInventory(bid);
                MessageBox.Show("Supplier Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one supplier first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
        }

        private void InventoryGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = this.InventoryGridView.CurrentRow.Cells[0].Value.ToString();
            //textBoxStock.Text = this.InventoryGridView.CurrentRow.Cells[3].Value.ToString();
            SupplierTextBox.Text = this.InventoryGridView.CurrentRow.Cells[1].Value.ToString();
            
        }
    }
}
