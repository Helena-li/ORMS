using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class OrderItemDAL : IServices<OrderItem>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(OrderItem item)
        {
            db.OrderItems.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.ID;
        }

        public void deleteItem(int id)
        {
            db.OrderItems.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public OrderItem getItem(int id)
        {
            return db.OrderItems.First(b => b.ID == id);
        }

        public OrderItem getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(OrderItem item)
        {
            OrderItem oi = getItem(item.ID);
            oi.MenuID = item.MenuID;
            oi.Quantity = item.Quantity;
            //oi.OrderID = item.OrderID;
            db.SubmitChanges();
        }
    }
}
