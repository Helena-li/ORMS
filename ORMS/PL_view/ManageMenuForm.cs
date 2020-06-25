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
    public partial class ManageMenuForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        
        public ManageMenuForm()
        {
            InitializeComponent();
        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            reset();
        }
        
        private void reset()
        {
            bindingDateGridView();
            idTextBox.Clear();
            NameTextBox.Clear();
            PriceTextBox.Clear();
            comboBoxOrderStatus.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
        }

        private void bindingDateGridView()
        {
            var orderList = ctr.getAllMenuList();
            MenuDataGridView.DataSource = orderList;
        }
        private void bindingDateGridView(string title)
        {
            var orderList = ctr.getMenuListByName(title);
            MenuDataGridView.DataSource = orderList;
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            reset();
        }
        //search by name
        // CRUD menu
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingDateGridView(NameTextBox.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("You can only search by name.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool dishStatus=false;
            float price=0;
            string type = null;
            try
            {
                dishStatus = bool.Parse(comboBoxOrderStatus.Text);
                price = float.Parse(PriceTextBox.Text);
                type = comboBoxType.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("price or status is incomplete.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            string dish = NameTextBox.Text;
            if (dish.Length < 1)
            {
                MessageBox.Show("Name is incomplete.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Menu menu = new Menu();
                menu.Name = dish;
                menu.Type = type;
                menu.OrderStatus = dishStatus;
                menu.Price = price;
                ctr.addMenu(menu);
                MessageBox.Show("Menu Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            reset();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = int.Parse(idTextBox.Text);
                string dish = NameTextBox.Text;
                string type = comboBoxType.Text;
                bool dishStatus = bool.Parse(comboBoxOrderStatus.Text);
                float price = float.Parse(PriceTextBox.Text);
                if (dish.Length < 1)
                {
                    MessageBox.Show("Name is incomplete.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Menu menu = new Menu();
                    menu.MenuID = selectedID;
                    menu.Name = dish;
                    menu.Type = type;
                    menu.OrderStatus = dishStatus;
                    menu.Price = price;
                    ctr.updateMenu(menu);
                    MessageBox.Show("Menu updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("price or status is incomplete.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Menu will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(idTextBox.Text);
                ctr.deleteMenu(bid);
                MessageBox.Show("Menu Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one menu first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
        }

        private void MenuDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedID = int.Parse(this.MenuDataGridView.CurrentRow.Cells[0].Value.ToString());
            idTextBox.Text = this.MenuDataGridView.CurrentRow.Cells[0].Value.ToString();
            NameTextBox.Text = this.MenuDataGridView.CurrentRow.Cells[1].Value.ToString();
            comboBoxType.SelectedValue = this.MenuDataGridView.CurrentRow.Cells[2].Value.ToString();
            PriceTextBox.Text = this.MenuDataGridView.CurrentRow.Cells[3].Value.ToString();
            comboBoxOrderStatus.SelectedValue= this.MenuDataGridView.CurrentRow.Cells[4].Value.ToString();
            
        }
        //open menu item form for specific menu
        private void ButtonManageItems_Click(object sender, EventArgs e)
        {
            int menuID = 0;
            try
            {
                menuID = int.Parse(idTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input one menu id first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            ManageMenuItemsForm mmif = new ManageMenuItemsForm(menuID);
            mmif.Show();
        }
    }
}
