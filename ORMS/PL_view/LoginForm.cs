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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(int uid)
        {
            InitializeComponent();
            textBoxUserId.Text = uid.ToString();
            textBoxPassword.Focus();
        }

        LoginBLL ctr = new LoginBLL();
        RecordBLL rd = new RecordBLL();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBoxUserType.SelectedIndex = 0;
        }
        //validate and log in
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string uid = textBoxUserId.Text.Trim();
            string password = textBoxPassword.Text;
            string type = comboBoxUserType.Text.Trim();

            if (!ctr.idValidator(uid))
            {
                MessageBox.Show("User id should be 1-6 numbers.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
            }
            else if (!ctr.passwordValidator(password))
            {
                MessageBox.Show("Password should be 6-22 characters.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
            else if (!rd.checkStaff(int.Parse(uid), password, type))
            {
                MessageBox.Show("User id or password is incorrect, please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
            else if (type.Equals("HR"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                HrForm df = new HrForm();
                df.ShowDialog();
                this.Close();
            }
            else if (type.Equals("Attendant"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                AttendantForm df = new AttendantForm();
                df.ShowDialog();
                this.Close();
            }
            else if (type.Equals("Assistant"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                AssistantForm lf = new AssistantForm();
                lf.ShowDialog();
                this.Close();
            }
            else if (type.Equals("Manager"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                ManagerForm mf = new ManagerForm();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void LinkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
            this.Close();
        }
    }
}
