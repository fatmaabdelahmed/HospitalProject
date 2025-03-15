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
    public partial class UserManagement : Form
    {
        private HOSPITALDbContext db;
        private int id;
        public UserManagement()
        {
            InitializeComponent();
            db = new HOSPITALDbContext();



        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            cb_role.DataSource = Enum.GetValues(typeof(UserRole));

        }
        private void LoadUsers()
        {
            dgv_users.DataSource = db.Users.Select(n => new
            {
                n.UserId,
                n.Username,
                n.PasswordHash,
                n.Role
            }).ToList();


        }

        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_users.SelectedRows[0].Cells[0].Value;
            Usersmember user = db.Users.SingleOrDefault(n => n.UserId == id);
            if (user != null)
            {
                txt_username.Text = user.Username;
                txt_password.Text = user.PasswordHash;
                cb_role.SelectedItem = user.Role;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.Users.Any(n => n.Username == txt_username.Text))
            {
                MessageBox.Show("This username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usersmember user = new Usersmember()
            {
                Username = txt_username.Text,
                PasswordHash = txt_password.Text,
                Role = (UserRole)cb_role.SelectedItem
            };

            db.Users.Add(user);
            db.SaveChanges();


            if (user.Role == UserRole.Doctor)
            {
                first.models.Doctor doctor = new first.models.Doctor()
                {
                    UsersmemberId = user.UserId,
                    Name = user.Username
                };

                db.Doctors.Add(doctor);
                db.SaveChanges();
            }

            ClearFields();
            LoadUsers();
            MessageBox.Show("User added successfully.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Usersmember user = db.Users.SingleOrDefault(n => n.UserId == id);
            if (user == null)
            {
                MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.Users.Any(n => n.Username == txt_username.Text && n.UserId != id))
            {
                MessageBox.Show("This username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.Username = txt_username.Text;
            user.PasswordHash = txt_password.Text;
            user.Role = (UserRole)cb_role.SelectedItem;

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
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
