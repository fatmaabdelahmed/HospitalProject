﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first.models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled; // Enum

        // العلاقات
        public virtual Patient Patient { get; set; } = null!;
        public virtual Doctor Doctor { get; set; } = null!;

        // العلاقة 1:1 مع Billing
        public virtual Billing? Billing { get; set; }

        public override string ToString()
        {
            return  $"n= {Patient.Name}" ;
        }

    }

    // تعريف Enum للحالة
    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled
    }
}
