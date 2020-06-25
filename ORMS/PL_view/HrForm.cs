using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORMS.BLL;
/// <summary>
/// two function: employee management and payroll
/// </summary>
namespace ORMS.PL_view
{
    public partial class HrForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        LoginBLL valid = new LoginBLL();
        
        public HrForm()
        {
            InitializeComponent();
        }
        #region emp
        private void HrForm_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            bindingDateGridView();
            IDTextBox.Clear();
            textBoxName.Clear();
            addressTextBox.Clear();
            dateTimePickerDob.Value=DateTime.Today;
            emailTextBox.Clear();
            phoneTextBox.Clear();
            textBoxPassword.Clear();
            textBoxConfirm.Clear();
        }

        private void bindingDateGridView()
        {
            var orderList = ctr.getEmployeeList();
            EmployeeListGridView.DataSource = orderList;
        }
        private void bindingDateGridView(string name)
        {
            var orderList = ctr.getEmployeeListByName(name);
            EmployeeListGridView.DataSource = orderList;
        }
        //search by name
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bindingDateGridView(textBoxName.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("You can only search by name.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        // CRUD employee
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Employee emp = GetEmployeeMembers();
                int id = ctr.addStaff(emp);
                MessageBox.Show("Register success!\n Your user ID is " + id.ToString(),
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Register failed!\n  " ,
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Employee GetEmployeeMembers()
        {
            string name = textBoxName.Text;
            string phone = phoneTextBox.Text;
            string password = textBoxPassword.Text;
            string role = comboBoxRoleType.Text.Trim();
            string addr = addressTextBox.Text;
            string email = emailTextBox.Text;
            string wt = comboBoxWorkType.Text.Trim();
            DateTime tempDate = dateTimePickerDob.Value;
            Employee s = new Employee();
            s.Name = name;
            s.Address = addr;
            s.DoB = tempDate;
            s.Email = email;
            s.Phone = phone;
            s.WorkType = wt;
            s.Password = password;
            s.RoleType = role;
            return s;
        }
        // validate input
        private bool ValidateInput()
        {
            bool validate = (textBoxName.Text.Length > 0) && valid.phoneValidator(phoneTextBox.Text)
                && valid.addressValidator(addressTextBox.Text) 
                && valid.emailValidator(emailTextBox.Text) && valid.passwordValidator(textBoxPassword.Text)
                && valid.confirmPasswordValidator(textBoxPassword.Text, textBoxConfirm.Text) &&
                valid.confirmUserTypeValidator(comboBoxRoleType.Text) &&
                valid.confirmWorkTypeValidator(comboBoxWorkType.Text);
            return validate;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Employee emp = GetEmployeeMembers();
                emp.EmployeeID = int.Parse(IDTextBox.Text);
                ctr.updateEmployee(emp);
                reset();
                MessageBox.Show("Update success!\n  " ,
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed!\n ",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Employee will be deleted , continue?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(IDTextBox.Text);
                ctr.deleteEmployee(bid);
                MessageBox.Show("Employee Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one employee first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            reset();
        }

        private void EmployeeListGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDTextBox.Text = this.EmployeeListGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = this.EmployeeListGridView.CurrentRow.Cells[1].Value.ToString();
            addressTextBox.Text = this.EmployeeListGridView.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerDob.Value = DateTime.Parse(this.EmployeeListGridView.CurrentRow.Cells[3].Value.ToString());
            emailTextBox.Text = this.EmployeeListGridView.CurrentRow.Cells[4].Value.ToString();
            phoneTextBox.Text = this.EmployeeListGridView.CurrentRow.Cells[5].Value.ToString();
            comboBoxWorkType.Text = this.EmployeeListGridView.CurrentRow.Cells[6].Value.ToString();
            comboBoxRoleType.Text = this.EmployeeListGridView.CurrentRow.Cells[7].Value.ToString();
            
        }
        #endregion

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
                this.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #region
        private void Payroll_Click(object sender, EventArgs e)
        {
            resetPayroll();
        }

        private void resetPayroll()
        {
            bindingPayrollDateGridView();
            textBoxPayID.Clear();
            textBoxEmpID.Clear();
            dateTimePickerStartDate.Value=DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            WorkHoursTextBox.Text="75";
            OverHoursTextBox.Clear();
            HourlySalaryTextBox.Text = "45.23";
            textBoxOverHourlySalary.Text = "16.25";
            textBoxTotalSalary.Clear();
            textBoxTax.Clear();
        }

        private void bindingPayrollDateGridView()
        {
            var payrollList = ctr.getPayrollList();
            payrollDataGridView.DataSource = payrollList;
        }
        private void bindingPayrollDateGridView(int id)
        {
            var payrollList = ctr.getPayrollListByID(id);
            payrollDataGridView.DataSource = payrollList;
        }
        // CRUD payroll
        private void buttonSearchPay_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxEmpID.Text);
                bindingPayrollDateGridView(id);
            }
            catch (Exception)
            {
                MessageBox.Show("You can only search by employee ID.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ButtonResetPay_Click(object sender, EventArgs e)
        {
            resetPayroll();
        }

        private Payroll GetPaymentMembers()
        {
            int empID = 0;
            double workHours = 0;
            double overHours = 0;
            double hourlySalary = 0;
            double overTimeSalary = 0;
            try
            {
                empID = int.Parse(textBoxEmpID.Text);
                workHours = double.Parse(WorkHoursTextBox.Text);
                overHours = double.Parse(OverHoursTextBox.Text);
                hourlySalary = double.Parse(HourlySalaryTextBox.Text);
                overTimeSalary = double.Parse(textBoxOverHourlySalary.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Payment input error!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            Payroll p = new Payroll();
            p.EmployeeID = empID;
            p.OverHours = overHours;
            p.WorkHours = workHours;
            p.PaymentStart = startDate;
            p.PaymentEnd = endDate;
            p.HourlySalary = hourlySalary;
            p.OverTimeHourlyRate = overTimeSalary;
            return p;
        }

        private void ButtonAddPay_Click(object sender, EventArgs e)
        {
            Payroll pay = GetPaymentMembers();
            PayrollBLL payBLL = new FulltimePayrollBLL();
            // check salary match with the work type
            bool checkResult = payBLL.CheckWorkType(pay);
            if (checkResult)
            {
                int id = ctr.addPayment(pay);
                MessageBox.Show("Add success!\n ",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetPayroll();
            }
            else
            {
                MessageBox.Show("Salary is not match with the work type!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonUpdatePay_Click(object sender, EventArgs e)
        {
            Payroll pay = GetPaymentMembers();
            pay.SalaryID = int.Parse(textBoxPayID.Text);
            PayrollBLL payBLL = new FulltimePayrollBLL();
            bool checkResult = payBLL.CheckWorkType(pay);
            if (checkResult)
            {
                ctr.updatePayment(pay);
                MessageBox.Show("Update success!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetPayroll();
            }
            else
            {
                MessageBox.Show("Salary is not match with the work type!\n ",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDeletePay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Payment will be deleted , continue?",
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int bid = 0;
            try
            {
                bid = int.Parse(textBoxPayID.Text);
                ctr.deletePayroll(bid);
                MessageBox.Show("Payment Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Select one payment first.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            resetPayroll();
        }

        private void PayrollDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxPayID.Text = this.payrollDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxEmpID.Text = this.payrollDataGridView.CurrentRow.Cells[1].Value.ToString();
            OverHoursTextBox.Text = this.payrollDataGridView.CurrentRow.Cells[2].Value.ToString();
            WorkHoursTextBox.Text = this.payrollDataGridView.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerStartDate.Value = DateTime.Parse(this.payrollDataGridView.CurrentRow.Cells[4].Value.ToString());
            dateTimePickerEndDate.Value = DateTime.Parse(this.payrollDataGridView.CurrentRow.Cells[5].Value.ToString());
            HourlySalaryTextBox.Text = this.payrollDataGridView.CurrentRow.Cells[6].Value.ToString();
            textBoxOverHourlySalary.Text = this.payrollDataGridView.CurrentRow.Cells[7].Value.ToString();
            textBoxTotalSalary.Text = this.payrollDataGridView.CurrentRow.Cells[8].Value.ToString();
            textBoxTax.Text = this.payrollDataGridView.CurrentRow.Cells[9].Value.ToString();
        }
        #endregion
    }
}
