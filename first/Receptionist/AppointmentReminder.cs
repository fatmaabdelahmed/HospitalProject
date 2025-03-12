using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Net.Http;
using System.Text;

namespace first.Receptionist
{
    public class AppointmentReminder
    {
       
        public static async Task StartReminderServiceAsync()
        {
            try
            {
                Console.WriteLine($"🔄 التحقق من المواعيد - {DateTime.Now}");

                var upcomingAppointments = GetUpcomingAppointments();

                foreach (var appointment in upcomingAppointments)
                {
                    if (IsValidEmail(appointment.ContactInfo))
                    {
                        SendEmail(appointment.ContactInfo, appointment.PatientName, appointment.AppointmentDate);
                    }
              
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ خطأ أثناء إرسال التذكيرات: {ex.Message}");
            }
        }

        private static List<Appointment> GetUpcomingAppointments()
        {
            using (var con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                string query = @"
                SELECT a.AppointmentId, a.AppointmentDate, p.ContactInfo, p.Name AS PatientName 
                FROM Appointments a
                JOIN Patients p ON a.PatientId = p.PatientId
                WHERE DATEDIFF(HOUR, GETDATE(), a.AppointmentDate) <= 24 
                AND a.AppointmentDate > GETDATE();";

                return con.Query<Appointment>(query).ToList();
            }
        }

        private static bool IsValidEmail(string contactInfo)
        {
            return contactInfo.Contains("@") && contactInfo.Contains(".");
        }

    

        private static void SendEmail(string email, string patientName, DateTime appointmentDate)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string senderEmail = "hagerayman737@gmail.com";
                string senderPassword = "inuc oeqg toqt pvpp";

                var smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Your medical appointment is tomorrow",
                    Body = $"Dear {patientName}, You have an appointment on {appointmentDate:yyyy-MM-dd HH:mm}. Please arrive on time. افتح يعم انا عمدهههه ",
                    IsBodyHtml = false
                };
                mailMessage.To.Add(email);

                smtpClient.Send(mailMessage);
                Console.WriteLine($"📧 تم إرسال الإيميل إلى {email}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ فشل إرسال الإيميل إلى {email}: {ex.Message}");
            }
        }

 
    }

    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ContactInfo { get; set; }
        public string PatientName { get; set; }
    }
}
