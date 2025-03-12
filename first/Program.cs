using first.Receptionist;
using first.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            Application.Run(new ReceptionistDashbordForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // تشغيل WelcomePage عند بدء التطبيق
            Application.Run(new WelcomPage());

        }
    }
}
