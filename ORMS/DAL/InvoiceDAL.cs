using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class InvoiceDAL : IServices<Invoice>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Invoice item)
        {
            db.Invoices.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.InvoiceID;
        }

        public void deleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Invoice getItem(int id)
        {
            throw new NotImplementedException();
        }

        public Invoice getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(Invoice item)
        {
            throw new NotImplementedException();
        }
    }
}
