using first.Login;
using first.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace first.Admin
{
    public partial class AdminForm : Form
    {
        private HOSPITALDbContext db;
        private int id;

        public AdminForm()
        {
            InitializeComponent();
            db = new HOSPITALDbContext();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            cb_role.DataSource = Enum.GetValues(typeof(UserRole));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
                Doctor doctor = new Doctor()
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

            // Check if another user has the same username
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
                Doctor doctor = db.Doctors.SingleOrDefault(d => d.UsersmemberId == user.UserId);

                if (doctor == null)
                {
                    doctor = new Doctor()
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
        {

            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contactInfo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         

            Doctor doctor = new Doctor()
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

            Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
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
            Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
        }

        private void btn_logout2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }

        }

        private void dgv_doctors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = (int)dgv_doctors.SelectedRows[0].Cells[0].Value;
            Doctor doctor = db.Doctors.SingleOrDefault(n => n.DoctorId == id);
            if (doctor != null)
            {
                txt_name.Text = doctor.Name;
                txt_contactInfo.Text = doctor.ContactInfo;
                txt_dept.Text = doctor.Specialization;
                txt_schedule.Text = doctor.Schedule;


            }

        }
    }
}

