using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;


        [Required]
        public DateTime DateOfBirth { get; set; } // بدل Age، أكثر دقة

        [Required]
        public Gender Gender { get; set; } // استخدام Enum بدل النصوص

        public string ContactInfo { get; set; } = string.Empty;
        public string MedicalHistory { get; set; } = string.Empty;

        // العلاقة 1:M مع Appointment
        public virtual List<Appointment> Appointments { get; set; } = new();

        // العلاقة 1:M مع Billing
        public virtual List<Billing> Billings { get; set; } = new();

        // العلاقة 1:M مع MedicalRecord
        public virtual List<MedicalRecord> MedicalRecords { get; set; } = new();
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
