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

namespace ORMS.PL_view
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            reset();
        }

        LoginBLL ctr = new LoginBLL();

        // validate input
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            reset();
            if (!ctr.nameValidator(textBoxFirstName.Text))
            {
                firstNameErrorLabel.Visible = true;
            }
            if (!ctr.nameValidator(textBoxLastName.Text))
            {
                lastNameErrorLabel.Visible = true;
            }
            if (!ctr.phoneValidator(textBoxPhoneNum.Text))
            {
                phoneErrorLabel.Visible = true;
            }
            if (!ctr.passwordValidator(textBoxPassword.Text))
            {
                passwordErrorLabel.Visible = true;
            }
            if (!ctr.confirmPasswordValidator(textBoxPassword.Text, textBoxConfirmPassword.Text))
            {
                confirmErrorLabel.Visible = true;
            }
            if (!ctr.addressValidator(textBoxAddress.Text))
            {
                addressErrorLabel.Visible = true;
            }
            if (!ctr.dobValidator(textBoxDOB.Text))
            {
                dobErrorLabel.Visible = true;
            }
            if (!ctr.emailValidator(textBoxEmail.Text))
            {
                emailErrorLabel.Visible = true;
            }
            if (!ctr.confirmUserTypeValidator(comboBoxRoleType.Text))
            {
                userTypeErrorLabel.Visible = true;
            }
            if (!ctr.confirmWorkTypeValidator(comboBoxWorkType.Text))
            {
                workTypeErrorLabel.Visible = true;
            }
            if (!(firstNameErrorLabel.Visible || lastNameErrorLabel.Visible ||
                phoneErrorLabel.Visible || passwordErrorLabel.Visible || confirmErrorLabel.Visible ||
                userTypeErrorLabel.Visible|| addressErrorLabel.Visible|| dobErrorLabel.Visible||
                emailErrorLabel.Visible|| workTypeErrorLabel.Visible))
            {
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string phone = textBoxPhoneNum.Text;
                string password = textBoxPassword.Text;
                string role = comboBoxRoleType.Text.Trim();
                string addr = textBoxAddress.Text;
                string email= textBoxEmail.Text;
                string wt = comboBoxWorkType.Text.Trim();
                DateTime tempDate = DateTime.Parse(textBoxDOB.Text);
                RecordBLL rd = new RecordBLL();
                Employee s = new Employee();
                s.Name = fname + lname;
                s.Address = addr;
                s.DoB = tempDate;
                s.Email = email;
                s.Phone = phone;
                s.WorkType = wt;
                s.Password = password;
                s.RoleType = role;
                int id = rd.addStaff(s);
                MessageBox.Show("Register success!\n Your user ID is " + id.ToString(),
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm lf = new LoginForm(id);
                lf.ShowDialog();
                this.Close();
            }
        }

        private void reset()
        {
            firstNameErrorLabel.Visible = false;
            lastNameErrorLabel.Visible = false;
            phoneErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            confirmErrorLabel.Visible = false;
            userTypeErrorLabel.Visible = false;
            addressErrorLabel.Visible = false;
            dobErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            workTypeErrorLabel.Visible = false;
        }

        private void LinkLabelBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }
    }
}
