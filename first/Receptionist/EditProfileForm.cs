using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using first.models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using BCrypt.Net;

namespace first.Receptionist
{
    public partial class EditProfileForm : Form
    {
        private int user_id;

        IDbConnection con;

        public EditProfileForm(int id)
        {
            InitializeComponent();
            user_id = id;
            con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            var quary = "select Username from Users where UserId=@UserId;";
            var user = con.QueryFirstOrDefault<Usersmember>(quary, new { UserId = user_id });

            if (user != null)
            {
                txt_username.Text = user.Username;
            }
          
        }



        private void btn_edidpro_Click(object sender, EventArgs e)
        {
            // جلب كلمة المرور المشفرة من قاعدة البيانات
            var storedHashedPassword = con.ExecuteScalar<string>("SELECT PasswordHash FROM Users WHERE UserId=@UserId;",
                new { UserId = user_id });

            // التحقق من صحة كلمة المرور باستخدام BCrypt
            if (!BCrypt.Net.BCrypt.Verify(txt_old.Text, storedHashedPassword))
            {
                MessageBox.Show("The current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من تطابق كلمتي المرور الجديدتين
            if (txt_new.Text != txt_confirm.Text)
            {
                MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // التحقق من عدم تكرار اسم المستخدم
            var existingUser = con.ExecuteScalar<string>("SELECT Username FROM Users WHERE Username = @Username AND UserId != @UserId;",
                new { Username = txt_username.Text, UserId = user_id });

            if (existingUser != null)
            {
                MessageBox.Show("This username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // **تشفير كلمة المرور  قبل تخزينها**
            string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(txt_new.Text);

            var updateQuery = "UPDATE Users SET Username = @Username, PasswordHash = @Password WHERE UserId = @UserId";
            con.Execute(updateQuery, new { Username = txt_username.Text, Password = hashedNewPassword, UserId = user_id });

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testt()
        {

            string username = "noha";
            string password = "1234";  // كلمة المرور الأصلية
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);  // تشفير كلمة المرور
            int role = 2;

            string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role);";

            con.Execute(query, new { Username = username, PasswordHash = hashedPassword, Role = role });

            Console.WriteLine("✅ تم إدراج المستخدم بنجاح!");
        }

        

    }
}