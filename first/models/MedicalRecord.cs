using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class MedicalRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        public string Diagnosis { get; set; } = string.Empty;
        public string? Prescription { get; set; } // جعلها اختيارية

        public string? TreatmentPlan { get; set; }
        public string? LabResults { get; set; }

        public string? Report { get; set; }


        [Required]
        public DateTime RecordDate { get; set; } = DateTime.Now; // تعيين قيمة افتراضية

        // العلاقات
        public virtual Patient Patient { get; set; } = null!;
        public virtual Doctor Doctor { get; set; } = null!;
    }
}
