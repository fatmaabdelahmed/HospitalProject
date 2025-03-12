using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace first.Receptionist
{
    public static class ReceptionistServices
    {
        //(Appointments)
        public static string Getallappointment = @"
    SELECT 
        a.AppointmentId,
        a.AppointmentDate,   
        a.Status, 
        p.PatientId,  -- إضافة PatientId 
        p.Name AS PatientName,    
        d.DoctorId,  -- إضافة DoctorId
        d.Name AS DoctorName  
    FROM Appointments a 
    JOIN Patients p ON a.PatientId = p.PatientId 
    JOIN Doctors d ON a.DoctorId = d.DoctorId;
";

        public static string AddAppointment = @"
            INSERT INTO Appointments (PatientId, DoctorId, AppointmentDate, Status) 
            VALUES (@PatientId, @DoctorId, @AppointmentDate, @Status);
        ";

        public static string EditAppointment = @"
            UPDATE Appointments 
            SET 
                PatientId = @PatientId, 
                DoctorId = @DoctorId, 
                AppointmentDate = @AppointmentDate, 
                Status = @Status 
            WHERE AppointmentId = @AppointmentId;
        ";

        public static string DeleteAppointment = @"
            DELETE FROM Appointments WHERE AppointmentId = @AppointmentId;
        ";

        public static string SearchAppointmentsByDate = @"
            SELECT 
                a.AppointmentId, 
                a.AppointmentDate,   
                a.Status, 
                p.Name AS PatientName,    
                d.Name AS DoctorName  
            FROM Appointments a 
            JOIN Patients p ON a.PatientId = p.PatientId 
            JOIN Doctors d ON a.DoctorId = d.DoctorId
            WHERE 
                CAST(a.AppointmentDate AS DATE) = @AppointmentDate 
                OR p.Name LIKE '%' + @PatientName + '%' 
                OR d.Name LIKE '%' + @DoctorName + '%';
        ";

        //billing
        public static string GetAllBills = @"
    SELECT 
        b.AppointmentId,
        a.PatientId,
        p.Name AS PatientName,
        d.Name AS DoctorName,
        b.TotalAmount,
        b.PaidAmount,
        (b.TotalAmount - b.PaidAmount) AS OutstandingBalance,
        b.PaymentStatus,
        b.PaymentDate
    FROM Billings b
    JOIN Appointments a ON b.AppointmentId = a.AppointmentId
    JOIN Patients p ON a.PatientId = p.PatientId
    JOIN Doctors d ON a.DoctorId = d.DoctorId;
";



        public static string AddBill = @"
            INSERT INTO Billings (AppointmentId, PatientId, TotalAmount, PaidAmount, PaymentStatus, PaymentDate) 
            VALUES (@AppointmentId, @PatientId, @TotalAmount, @PaidAmount, @PaymentStatus, @PaymentDate);
        ";

        public static string EditBill = @"
            UPDATE Billings 
            SET 
                TotalAmount = @TotalAmount, 
                PaidAmount = @PaidAmount, 
                PaymentStatus = @PaymentStatus, 
                PaymentDate = @PaymentDate
            WHERE AppointmentId = @AppointmentId;
        ";

        // ✅ حذف فاتورة
        public static string DeleteBill = @"
            DELETE FROM Billings WHERE AppointmentId = @AppointmentId;
        ";

        // ✅ البحث عن الفواتير حسب اسم المريض أو الطبيب أو حالة الدفع
        public static string SearchBills = @"
            SELECT 
                b.AppointmentId,
                p.Name AS PatientName,
                d.Name AS DoctorName,
                b.TotalAmount,
                b.PaidAmount,
                (b.TotalAmount - b.PaidAmount) AS OutstandingBalance,
                b.PaymentStatus,
                b.PaymentDate
            FROM Billings b
            JOIN Appointments a ON b.AppointmentId = a.AppointmentId
            JOIN Patients p ON a.PatientId = p.PatientId
            JOIN Doctors d ON a.DoctorId = d.DoctorId
            WHERE 
                p.Name LIKE '%' + @PatientName + '%' 
                OR d.Name LIKE '%' + @DoctorName + '%'
                OR b.PaymentStatus = @PaymentStatus;
        ";

        //patient

        public static string Getallpatient = @"
            SELECT 
                PatientId, 
                Name, 
                DateOfBirth, 
                Gender, 
                ContactInfo, 
                MedicalHistory 
            FROM Patients;
        ";

        public static string AddPatient = @"
            INSERT INTO Patients (Name, DateOfBirth, Gender, ContactInfo, MedicalHistory) 
            VALUES (@Name, @DateOfBirth, @Gender, @ContactInfo, @MedicalHistory);
        ";

        public static string EditPatient = @"
            UPDATE Patients 
            SET 
                Name = @Name, 
                DateOfBirth = @DateOfBirth, 
                Gender = @Gender, 
                ContactInfo = @ContactInfo, 
                MedicalHistory = @MedicalHistory 
            WHERE PatientId = @PatientId;
        ";

        public static string DeletePatient = @"
            DELETE FROM Patients WHERE PatientId = @PatientId;
        ";

        public static string SearchPatientByName = @"
            SELECT 
                PatientId, 
                Name, 
                DateOfBirth, 
                Gender,
                ContactInfo, 
                MedicalHistory 
            FROM Patients
            WHERE 
                Name LIKE '%' + @Name + '%' 
            OR ContactInfo = @ContactInfo OR (@PatientId IS NOT NULL AND PatientId = @PatientId);
        "; 
    }
}
