using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class OrderDAL : IServices<Order>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Order item)
        {
            db.Orders.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.OrderID;
        }

        public void deleteItem(int id)
        {
            throw new Exception("Unsupport action");
        }

        public Order getItem(int id)
        {
            return db.Orders.First(b => b.OrderID == id);
        }

        public Order getItem(string str)
        {
            throw new Exception("Unsupport action");
        }

        public void updateItem(Order item)
        {
            Order order = getItem(item.OrderID);
            order.OrderStatus = item.OrderStatus;
            order.TableID = item.TableID;
            db.SubmitChanges();
        }
    }
}
