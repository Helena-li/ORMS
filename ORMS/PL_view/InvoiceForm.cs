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
    public partial class InvoiceForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        int orderID = 0;
        public InvoiceForm(int uid)
        {
            InitializeComponent();
            orderID = uid;
        }
        // generate invoice
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            
            Invoice invoice= ctr.generateInvoice(orderID);
            idLabel.Text = invoice.OrderID.ToString();
            timeLabel.Text = invoice.Time.ToString();
            labelPrice.Text = invoice.TotalPrice.ToString();
            var orderlist = ctr.getOrderItemListById(orderID);
            OderListGridView.DataSource = orderlist;
        }
    }
}
