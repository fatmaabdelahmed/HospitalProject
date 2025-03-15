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








            if (user.Role == UserRole.Doctor)
            {
                first.models.Doctor doctor = new first.models.Doctor()
                {
                    UsersmemberId = user.UserId,
                    Name = user.Username
                };









            db.Users.Update(user);
            db.SaveChanges();


            if (user.Role == UserRole.Doctor)
            {
                first.models.Doctor doctor = db.Doctors.SingleOrDefault(d => d.UsersmemberId == user.UserId);

                if (doctor == null)
                {
                    doctor = new first.models.Doctor()
                    {
                        UsersmemberId = user.UserId,
                        Name = user.Username
                    };

                    db.Doctors.Add(doctor);
                }
                else
                {
                    doctor.Name = user.Username;
                }

                db.SaveChanges();
            }

            ClearFields();
            LoadUsers();
            MessageBox.Show("User updated successfully.");
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            Usersmember user = db.Users.SingleOrDefault(n => n.UserId == id);
            if (user == null)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                ClearFields();
                LoadUsers();
                MessageBox.Show("User deleted successfully.");
            }
        }

        private void ClearFields()
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            cb_role.SelectedIndex = 0;
        }

        private void dgv_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_doc_Click(object sender, EventArgs e)

        private void btn_logout_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }




            first.models.Doctor doctor = new first.models.Doctor()
            {
                Name = txt_name.Text,
                ContactInfo = txt_contactInfo.Text,
                Specialization = txt_dept.Text,
                Schedule = txt_schedule.Text

            };

            db.Doctors.Add(doctor);
            db.SaveChanges();
            LoadUsers();

            MessageBox.Show("User added successfully.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_doc_Click(object sender, EventArgs e)
        {

            first.models.Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
            if (doctor == null)
            {
                MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            doctor.Name = txt_name.Text;
            doctor.ContactInfo = txt_contactInfo.Text;
            doctor.Specialization = txt_dept.Text;
            doctor.Schedule = txt_schedule.Text;


            db.Doctors.Update(doctor);
            db.SaveChanges();
            ClearFields();
            LoadUsers();
            MessageBox.Show("User updated successfully.");

        }

        private void btn_delete_doc_Click(object sender, EventArgs e)
        {
            first.models.Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
            if (doctor == null)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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


            id = (int)dgv_doctors.SelectedRows[0].Cells[0].Value;
            first.models.Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
            if (doctor != null)
            {
                txt_name.Text = doctor.Name;
                txt_contactInfo.Text = doctor.ContactInfo;
                txt_dept.Text = doctor.Specialization;
                txt_schedule.Text = doctor.Schedule;


            }


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

