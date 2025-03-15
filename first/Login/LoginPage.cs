using first.Admin;
using first.models;
using System;
using System.Linq;
using System.Windows.Forms;
using first.Receptionist;
using Microsoft.Data.SqlClient;

using Dapper;

namespace first.Login
{
    public partial class LoginPage : Form
    {
        HOSPITALDbContext db;
        public LoginPage()
        {
            InitializeComponent();
            db = new HOSPITALDbContext();
        }

        

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
        }

        public void clear()
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text;
            string password = txt_password.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rec = db.Users.FirstOrDefault(a => a.Username == userName && a.PasswordHash == password);

            if (rec != null)
            {
                string role = rec.Role.ToString();
                clear();

                if (role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (role == "Doctor")
                {

                  Doctor.doctorform doctorForm = new Doctor.doctorform(rec.UserId);
                    doctorForm.Show();
                    this.Hide();

                }
                else if (role == "Receptionist")
                {
                    MessageBox.Show($"Login Success!\nRole: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تمرير الـ UserId إلى الفورم الجديد
                    Receptionist.ReceptionistDashbordForm receptionistForm = new Receptionist.ReceptionistDashbordForm(rec.UserId,rec.Username);

                    string query = @"
                                        SELECT d.DoctorId 
                                        FROM Doctors d 
                                        JOIN Users u ON d.UsersmemberId = u.UserId 
                                        WHERE u.UserId = @UserId";

                    using (SqlConnection con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True; TrustServerCertificate=True;"))
                    {
                        con.Open();
                        int doctorId = con.QueryFirstOrDefault<int>(query, new { UserId = rec.UserId });

                        if (doctorId > 0)
                        {
                            var doctorForm = new Doctor.doctorform(doctorId);
                            doctorForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Doctor ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (role == "Receptionist")
                {
                    ReceptionistDashbordForm receptionistForm = new ReceptionistDashbordForm(rec.UserId);

                    receptionistForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("User Not Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (showPasswordCheckBox.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';


            }
        }
    }
}
