using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class MenuItemDAL : IServices<MenuItem>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(MenuItem item)
        {
            db.MenuItems.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.ID;
        }

        public void deleteItem(int id)
        {
            db.MenuItems.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public MenuItem getItem(int id)
        {
            return db.MenuItems.First(b => b.ID == id);
        }

        public MenuItem getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(MenuItem item)
        {
            MenuItem menu = getItem(item.ID);
            menu.ItemID = item.ItemID;
            menu.MenuID = item.MenuID;
            db.SubmitChanges();
        }
    }
}
