using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first.models;
using Microsoft.EntityFrameworkCore;

namespace first.models
{
    public class Billing
    {

        [Key, ForeignKey("Appointment")]
        public int AppointmentId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal PaidAmount { get; set; }

        [NotMapped]
        public decimal OutstandingBalance => TotalAmount - PaidAmount;

        [Required]
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending; // Enum

        public DateTime? PaymentDate { get; set; } // Nullable لأن الدفع قد لا يكون قد تم بعد

        // العلاقات
        public virtual Patient Patient { get; set; } = null!;
        public virtual Appointment Appointment { get; set; } // Nullable عند الحاجة
    }

    // تعريف Enum لحالة الدفع
    public enum PaymentStatus
    {
        Pending,
        Paid
    }
}

