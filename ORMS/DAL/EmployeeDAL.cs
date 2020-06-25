using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class EmployeeDAL : IServices<Employee>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Employee item)
        {
            db.Employees.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.EmployeeID;
        }

        public void deleteItem(int id)
        {
            db.Employees.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public Employee getItem(int id)
        {
            return db.Employees.First(b => b.EmployeeID == id);
        }
        
        public Employee getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(Employee item)
        {
            Employee employee = getItem(item.EmployeeID);
            employee.Name = item.Name;
            employee.Address = item.Address;
            employee.DoB = item.DoB;
            employee.Email = item.Email;
            employee.Phone = item.Phone;
            employee.WorkType = item.WorkType;
            employee.RoleType = item.RoleType;
            employee.Password = item.Password;
            db.SubmitChanges();
        }
    }
}
