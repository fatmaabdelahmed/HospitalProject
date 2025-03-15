using first.Login;
using first.models;
using first.Reports;
using System;
using System.Linq;
using System.Windows.Forms;

namespace first.Admin
{
    public partial class AdminForm : Form
    {


        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }















        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
        }





        private void btn_reports_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Hide();

        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
            this.Hide();
        }

        private void lb_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }

        }

        private void lb_reports_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
        }

        private void lb_doctor_Click(object sender, EventArgs e)
        {
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
            this.Hide();

        }

        private void lb_user_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Hide();
        }
    }
}

