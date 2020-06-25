using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class SupplierInventoryDAL : IServices<SupplierInventory>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(SupplierInventory item)
        {
            db.SupplierInventories.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.ID;
        }

        public void deleteItem(int id)
        {
            db.SupplierInventories.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public SupplierInventory getItem(int id)
        {
            return db.SupplierInventories.First(b => b.ID == id);
        }

        public SupplierInventory getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(SupplierInventory item)
        {
            SupplierInventory si = getItem(item.ID);
            si.ItemID = item.ItemID;
            si.SupplierID = item.SupplierID;
            db.SubmitChanges();
        }
    }
}
