using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                OR ContactInfo LIKE '%' + @ContactInfo + '%';
        ";
    }
}
