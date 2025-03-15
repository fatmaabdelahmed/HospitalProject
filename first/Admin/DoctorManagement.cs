using first.Doctor;
using first.Login;
using first.models;
using first.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first.Admin
{
    public partial class DoctorManagement : Form
    {
        private HOSPITALDbContext db;
        private int id;


        public DoctorManagement()
        {
            InitializeComponent();
            db = new HOSPITALDbContext();

        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {


            dgv_doctors.DataSource = db.Doctors.Select(n => new
            {
                n.DoctorId,
                n.Name,
                n.ContactInfo,
                n.Specialization,
                n.Schedule,
                UsersmemberId = n.UsersmemberId
            }).ToList();
        }

        private void btn_add_doc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contactInfo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            ClearFields();
            LoadUsers();

            MessageBox.Show("User added successfully.");
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

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Doctors.Remove(doctor);
                db.SaveChanges();
                ClearFields();
                LoadUsers();
                MessageBox.Show("User deleted successfully.");
            }

        }
        private void ClearFields()
        {
            txt_name.Text = string.Empty;
            txt_schedule.Text = string.Empty;
            txt_contactInfo.Text = string.Empty;
            txt_dept.Text = string.Empty;

        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
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

        private void pc_prev_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void pc_next_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Hide();
        }

        private void dgv_doctors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_doctors.SelectedRows[0].Cells[0].Value;
            models.Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
            if (doctor != null)
            {
                txt_name.Text = doctor.Name;
                txt_contactInfo.Text = doctor.ContactInfo;
                txt_schedule.Text = doctor.Schedule;
                txt_dept.Text = doctor.Specialization;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
