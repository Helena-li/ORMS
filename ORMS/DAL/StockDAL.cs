using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class StockDAL : IServices<Inventory>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Inventory item)
        {
            db.Inventories.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.StockID;
        }

        public void deleteItem(int id)
        {
            db.Inventories.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public Inventory getItem(int id)
        {
            return db.Inventories.First(b => b.StockID == id);
        }

        public Inventory getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(Inventory item)
        {
            Inventory inventory = getItem(item.StockID);
            inventory.StockName = item.StockName;
            inventory.RestockQuantity = item.RestockQuantity;
            inventory.ConductTime = item.ConductTime;
            inventory.EmployeeID = item.EmployeeID;
            inventory.MaxQuantity = item.MaxQuantity;
            db.SubmitChanges();
        }
    }
}
