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
    // observer pattern
    // claim
    public delegate void TableHandler(object sender, TableEventArgs e);
    public partial class TableManagement : Form
    {
        RecordBLL ctr = new RecordBLL();
        // create event
        public event TableHandler tableCheck;
        public TableManagement()
        {
            InitializeComponent();
        }

        private void TableManagement_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            bindingDateGridView();
            IDTextBox.Clear();
            //// CusromerNameTextBox.Clear();
        }

        private void bindingDateGridView()
        {
            var orderList = ctr.getTableList();
            TableGridView.DataSource = orderList;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonSetTable_Click(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            string status = comboBoxStatus.Text;
            TableEventArgs args = new TableEventArgs(id, status);
            tableCheck(this, args);
            this.Dispose();
        }

        private void OderListGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedID = int.Parse(this.TableGridView.CurrentRow.Cells[0].Value.ToString());
            IDTextBox.Text = this.TableGridView.CurrentRow.Cells[0].Value.ToString();
            comboBoxStatus.Text = this.TableGridView.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
