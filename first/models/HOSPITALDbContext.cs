using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace first.models
{
    public class HOSPITALDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }



        public virtual DbSet<Usersmember> Users { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }
        public virtual DbSet<DoctorPatient> DoctorPatients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billing>()
      .HasKey(b => b.AppointmentId); // تعيين AppointmentId كمفتاح أساسي

            modelBuilder.Entity<Billing>()
                .HasOne(b => b.Appointment)
                .WithOne(a => a.Billing)
                .HasForeignKey<Billing>(b => b.AppointmentId)
                .IsRequired(false) // الفاتورة مش شرط تكون موجودة لكل موعد
                .OnDelete(DeleteBehavior.Restrict);

           


            #region data_seed
            // 1️⃣ Seeding Users Table
            modelBuilder.Entity<Usersmember>().HasData(
                new Usersmember { UserId = 1, Username = "admin", PasswordHash = "123", Role = UserRole.Admin },
                new Usersmember { UserId = 2, Username = "dr.ahmed", PasswordHash = "123", Role = UserRole.Doctor },
                new Usersmember { UserId = 3, Username = "reception1", PasswordHash = "123", Role = UserRole.Receptionist },
                new Usersmember { UserId = 4, Username = "dr.sara", PasswordHash = "123", Role = UserRole.Doctor },
                new Usersmember { UserId = 5, Username = "dr.james", PasswordHash = "123", Role = UserRole.Doctor }
            );

            // 2️⃣ Seeding Doctors Table
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, Name = "Dr. Ahmed", Specialization = "Cardiology", ContactInfo = "123-456-7890", Schedule = "Mon-Fri, 9 AM - 5 PM", UsersmemberId = 2 },
                new Doctor { DoctorId = 2, Name = "Dr. Sara", Specialization = "Dermatology", ContactInfo = "987-654-3210", Schedule = "Tue-Sat, 10 AM - 6 PM", UsersmemberId = 4 },
                new Doctor { DoctorId = 3, Name = "Dr. James", Specialization = "Orthopedics", ContactInfo = "555-123-7890", Schedule = "Mon-Sat, 8 AM - 4 PM", UsersmemberId = 5 }
            );

            // 3️⃣ Seeding Patients Table
            modelBuilder.Entity<Patient>().HasData(
                new Patient { PatientId = 1, Name = "John Doe", DateOfBirth = new DateTime(1990, 5, 10), ContactInfo = "john.doe@example.com", Gender = Gender.Male, MedicalHistory = "No known allergies. Previous surgery in 2015." },
                new Patient { PatientId = 2, Name = "Jane Smith", DateOfBirth = new DateTime(1985, 7, 22), ContactInfo = "jane.smith@example.com", Gender = Gender.Female, MedicalHistory = "Diabetic. Takes insulin daily." }
            );

            // 4️⃣ Seeding Appointments Table
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, PatientId = 1, DoctorId = 1, AppointmentDate = new DateTime(2025, 3, 16, 10, 0, 0), Status = AppointmentStatus.Scheduled },
                new Appointment { AppointmentId = 2, PatientId = 2, DoctorId = 2, AppointmentDate = new DateTime(2025, 3, 18, 14, 0, 0), Status = AppointmentStatus.Scheduled }
            );

            // 5️⃣ Seeding Billing Table
            modelBuilder.Entity<Billing>().HasData(
                new Billing { AppointmentId = 1, PatientId = 1, TotalAmount = 200.00m, PaidAmount = 50.00m, PaymentStatus = PaymentStatus.Pending, PaymentDate = null },
                new Billing { AppointmentId = 2, PatientId = 2, TotalAmount = 300.00m, PaidAmount = 300.00m, PaymentStatus = PaymentStatus.Paid, PaymentDate = new DateTime(2025, 3, 15) }
            );

            // 6️⃣ Seeding MedicalRecords Table
            modelBuilder.Entity<MedicalRecord>().HasData(
                new MedicalRecord { RecordId = 1, PatientId = 1, DoctorId = 1, Diagnosis = "Hypertension", Prescription = "Lisinopril 10mg", TreatmentPlan = "Monitor BP", LabResults = "BP: 140/90", Report = "Follow up in 2 weeks", RecordDate = new DateTime(2025, 3, 5) },
                new MedicalRecord { RecordId = 2, PatientId = 2, DoctorId = 2, Diagnosis = "Skin Allergy", Prescription = "Antihistamines", TreatmentPlan = "Avoid allergens", LabResults = "Patch test positive", Report = "Recheck in 1 month", RecordDate = new DateTime(2025, 3, 7) }
            );

            #endregion


        }


    }
    }
  


    
