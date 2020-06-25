using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class SupplierDAL : IServices<Supplier>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Supplier item)
        {
            db.Suppliers.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.SupplierID;
        }

        public void deleteItem(int id)
        {
            db.Suppliers.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public Supplier getItem(int id)
        {
            return db.Suppliers.First(b => b.SupplierID == id);
        }

        public Supplier getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(Supplier item)
        {
            Supplier suppliers = getItem(item.SupplierID);
            suppliers.SupplierName = item.SupplierName;
            suppliers.Address = item.Address;
            suppliers.Phone = item.Phone;
            db.SubmitChanges();
        }
    }
}
