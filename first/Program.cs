using first.Receptionist;
using first.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // Add this for Application class
using first.Doctor;
using first.Reports;

namespace first
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


           // Application.Run(new ReceptionistDashbordForm());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomPage());
          //  Application.Run(new ReceptionistDashbordForm());
            // تشغيل WelcomePage عند بدء التطبيق
            //Application.Run(new QRcode(2));
            //Application.Run(new reports());

       

        //    Application.Run(new QRcode());



        }

    }
}
