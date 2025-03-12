using first.Admin;
using first.models;
using System;
using System.Linq;
using System.Windows.Forms;

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


            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please fill in all fields", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rec = db.Users.Where(a => a.Username == userName && a.PasswordHash == password).FirstOrDefault();

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
                //else if (role == "Doctor")
                //{
                //    DoctorForm doctorForm = new DoctorForm();
                //    doctorForm.Show();
                //    this.Hide();

                //}
                else if (role == "Receptionist")
                {
                    MessageBox.Show($"Login Success!\nRole: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Receptionist.ReceptionistDashbordForm reciptionestForm = new Receptionist.ReceptionistDashbordForm();
                    reciptionestForm.Show();
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
