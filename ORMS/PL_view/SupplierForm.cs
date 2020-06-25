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
    public partial class SupplierForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            bindingDateGridView();
            IDTextBox.Clear();
            textBoxName.Clear();
            phoneTextBox.Clear();
            textBoxAddress.Clear();
        }

        private void bindingDateGridView()
        {
            var supplierList = ctr.getSupplierList();
            SupplierGridView.DataSource = supplierList;
        }

        //CRUD supplier
        private void bindingDateGridView(int id)
        {
            var stockList = ctr.getSupplierListtByID(id);
            SupplierGridView.DataSource = stockList;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDTextBox.Text);
                bindingDateGridView(id);
            }
            catch (Exception)
            {
                MessageBox.Show("You can only search by supplier ID.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private Supplier getSupplierItem()
        {
            string name = textBoxName.Text;
            string phone = phoneTextBox.Text;
            string addr = textBoxAddress.Text;
            Supplier sup = new Supplier();
            sup.SupplierName = name;
            sup.Phone = phone;
            sup.Address = addr;
            return sup;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = getSupplierItem();
            int id = ctr.addSupplier(supplier);
            MessageBox.Show("Add success!\n Your user ID is " + id.ToString(),
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = getSupplierItem();
            try
            {
                supplier.SupplierID = int.Parse(IDTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input supplier ID first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            ctr.updateSupplier(supplier);
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
                bid = int.Parse(IDTextBox.Text);
                ctr.deleteSupplier(bid);
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

        private void SupplierGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDTextBox.Text = this.SupplierGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = this.SupplierGridView.CurrentRow.Cells[1].Value.ToString();
            phoneTextBox.Text = this.SupplierGridView.CurrentRow.Cells[3].Value.ToString();
            textBoxAddress.Text = this.SupplierGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
