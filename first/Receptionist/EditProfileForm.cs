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
            var old = con.ExecuteScalar<string>("select PasswordHash from Users where UserId=@UserId;", new { UserId = user_id });
            if (old != txt_old.Text)
            {

                MessageBox.Show("data not correct","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txt_new.Text != txt_confirm.Text)
            {
                MessageBox.Show( "New passwords do not match!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            var updateQuery = "UPDATE Users SET Username = @Username, PasswordHash = @Password WHERE UserId = @UserId";
            con.Execute(updateQuery, new { Username = txt_username.Text, Password = txt_new.Text, UserId = user_id });

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
    }
}
