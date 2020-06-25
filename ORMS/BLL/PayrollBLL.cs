using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMS.DAL;

namespace ORMS.BLL
{
    // polymorphism
    abstract class PayrollBLL
    {
        internal abstract double CalcSalary(Payroll p);

        internal double CalcTax(double salary)
        {
            double tax = 0;
            if (salary<=540)
            {
                tax = salary * 0.105;
                return tax;
            }
            else if (540<salary && salary<=1850)
            {
                tax = (salary - 540) * 0.175+540*0.105;
                return tax;
            }
            else if (1850 < salary && salary <= 2700)
            {
                tax = (salary - 1850 ) * 0.3 + (1850 - 540) * 0.175 + 540 * 0.105;
                return tax;
            }
            else 
            {
                tax = 0.33 * (salary - 2700) + 0.3 * (2700 - 1850) +
                    +(1850 - 540) * 0.175 + 540 * 0.105;
                return tax;
            }
        }

        // check if the input matches the work type
        internal bool CheckWorkType(Payroll pay)
        {
            EmployeeDAL empDAL = new EmployeeDAL();
            Employee emp = empDAL.getItem(pay.EmployeeID);
            //bool checkSalaryRate = pay.HourlySalary == 28.5;
            bool match = false;
            switch (emp.WorkType)
            {
                case "Full time":
                    match= (pay.HourlySalary == 45.23)&&(pay.OverTimeHourlyRate==16.25);
                    break;

                case "Part time":
                    match = (pay.HourlySalary == 28.5) && (pay.OverTimeHourlyRate == 0);
                    break;
                default:
                    break;
            }
            //var result = new { MatchResult = match, EmpType = emp.WorkType };
            return match;
        }
    }

    class ParttimePayrollBLL : PayrollBLL
    {
        internal override double CalcSalary(Payroll p)
        {
            double salary = p.WorkHours * p.HourlySalary + p.OverHours * p.OverTimeHourlyRate;
            return salary;
        }
    }
    class FulltimePayrollBLL : PayrollBLL
    {
        internal override double CalcSalary(Payroll p)
        {
            double bonusrate = 0.015;
            double salary=(p.WorkHours*p.HourlySalary+p.OverHours*p.OverTimeHourlyRate)*(1+ bonusrate);
            return salary;
        }
    }
    //class ParttimePayrollBLL : AbstractPayrollBLL
    //{
    //    internal override double CalcSalary(Payroll p)
    //    {
    //        double salary = p.WorkHours * p.HourlySalary + p.OverHours * p.OverTimeHourlyRate;
    //        return salary;
    //    }
    //}
}
