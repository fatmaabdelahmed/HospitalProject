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
using Newtonsoft.Json;

namespace first.Receptionist
{
    public class AppointmentReminder
    {
        private static readonly string ApiKey = "506304ab10fc4010"; // استبدله بمفتاح Beem
        private static readonly string SecretKey = "NjU3NDBjYzgyY2VjYTBlOTExYmUwOWYzNmQ0ZGFkN2ZiMjAyZDYwODg5NDYyNTg3Yjc4OGU0MTEzMzA0YTVhMQ=="; // استبدله بالـ Secret Key
        private static readonly string SenderId = "YourSenderID"; // اسم المرسل المسجل في Beem

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
                    else if (IsValidPhoneNumber(appointment.ContactInfo))
                    {
                        await SendSmsAsync(appointment.ContactInfo, appointment.PatientName, appointment.AppointmentDate);
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

        private static bool IsValidPhoneNumber(string contactInfo)
        {
            return contactInfo.All(char.IsDigit) && contactInfo.Length >= 10;
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
                    Subject = "موعدك الطبي غداً",
                    Body = $"عزيزي {patientName}, لديك موعد طبي بتاريخ {appointmentDate:yyyy-MM-dd HH:mm}. الرجاء الحضور في الوقت المحدد.",
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

        private static async Task SendSmsAsync(string phoneNumber, string patientName, DateTime appointmentDate)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = "https://api.beem.africa/v1/send";

                    var data = new
                    {
                        sender = SenderId,
                        recipients = new string[] { phoneNumber },
                        message = $"عزيزي {patientName}, لديك موعد طبي بتاريخ {appointmentDate:yyyy-MM-dd HH:mm}. الرجاء الحضور في الوقت المحدد."
                    };

                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ApiKey}:{SecretKey}")));

                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    Console.WriteLine($"📩 استجابة Beem: {responseString}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ خطأ أثناء إرسال الرسالة إلى {phoneNumber}: {ex.Message}");
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
