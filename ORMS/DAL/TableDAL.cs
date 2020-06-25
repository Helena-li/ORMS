using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class TableDAL : IServices<TableNumber>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(TableNumber item)
        {
            db.TableNumbers.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.TableID;
        }

        public void deleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public TableNumber getItem(int id)
        {
            throw new NotImplementedException();
        }

        public TableNumber getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(TableNumber item)
        {
            TableNumber tableNumber = db.TableNumbers.FirstOrDefault(b => b.TableID == item.TableID);
            if (tableNumber==null)
            {
                addItem(item);
            }
            else
            {
                tableNumber.Status = item.Status;
                db.SubmitChanges();
            }
        }
    }
}
