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
    public partial class ManageMenuItemsForm : Form
    {
        int menuID = 0;
        RecordBLL ctr = new RecordBLL();
        public ManageMenuItemsForm(int id)
        {
            InitializeComponent();
            menuID = id;
        }

        private void ManageMenuItemsForm_Load(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            bindingDateGridView();
            idTextBox.Clear();
            ItemsTextBox.Clear();
            textBoxMenuID.Text = menuID.ToString();
        }
        // CRUD item
        private void bindingDateGridView()
        {
            var orderList = ctr.getMenuItemsListByID(menuID);
            MenuDataGridView.DataSource = orderList;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int itemID = 0;
            try
            {
                itemID = int.Parse(ItemsTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Item ID is incomplete.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            MenuItem item = new MenuItem();
            item.ItemID = itemID;
            item.MenuID = menuID;
            ctr.addMenuItems(item);
            MessageBox.Show("Menu item Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int itemID = 0;
            int id = 0;
            try
            {
                id = int.Parse(idTextBox.Text);
                itemID = int.Parse(ItemsTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Item ID or id is incomplete.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            MenuItem item = new MenuItem();
            item.ID = id;
            item.ItemID = itemID;
            item.MenuID = menuID;
            ctr.updateMenuItems(item);
            MessageBox.Show("Menu item Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Menu item will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(idTextBox.Text);
                ctr.deleteMenuItems(bid);
                MessageBox.Show("Menu item Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one id first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
        }
    }
}
