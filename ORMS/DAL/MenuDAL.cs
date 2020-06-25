using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class MenuDAL : IServices<Menu>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Menu item)
        {
            db.Menus.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.MenuID;
        }

        public void deleteItem(int id)
        {
            db.Menus.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public Menu getItem(int id)
        {
            return db.Menus.First(b => b.MenuID == id);
        }

        public Menu getItem(string str)
        {
            return db.Menus.First(b => b.Name.ToLower() == str.ToLower());
        }

        public void updateItem(Menu item)
        {
            Menu menu = getItem(item.MenuID);
            menu.Name = item.Name;
            menu.Type = item.Type;
            menu.Price = item.Price;
            menu.OrderStatus = item.OrderStatus;
            db.SubmitChanges();
        }
    }
}
