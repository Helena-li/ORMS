using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    class PayrollDAL : IServices<Payroll>
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        public int addItem(Payroll item)
        {
            db.Payrolls.InsertOnSubmit(item);
            db.SubmitChanges();
            return item.SalaryID;
        }

        public void deleteItem(int id)
        {
            db.Payrolls.DeleteOnSubmit(getItem(id));
            db.SubmitChanges();
        }

        public Payroll getItem(int id)
        {
            return db.Payrolls.First(b => b.SalaryID == id);
        }

        public Payroll getItem(string str)
        {
            throw new NotImplementedException();
        }

        public void updateItem(Payroll item)
        {
            Payroll payroll = getItem(item.SalaryID);
            payroll.EmployeeID = item.EmployeeID;
            payroll.OverHours = item.OverHours;
            payroll.WorkHours = item.WorkHours;
            payroll.PaymentStart = item.PaymentStart;
            payroll.PaymentEnd = item.PaymentEnd;
            payroll.HourlySalary = item.HourlySalary;
            payroll.OverTimeHourlyRate = item.OverTimeHourlyRate;
            payroll.Tax = item.Tax;
            payroll.TotalSalary = item.TotalSalary;
            db.SubmitChanges();
        }
    }
}
