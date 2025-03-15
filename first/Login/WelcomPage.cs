using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first.Login
{
    public partial class WelcomPage : Form
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        

        private void WelcomPage_Load(object sender, EventArgs e)
        {
            

        }

        

       

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();

        }
    }
}
