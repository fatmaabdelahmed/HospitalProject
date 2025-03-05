using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class Usersmember
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; set; }  // Admin, Doctor, Receptionist

        // العلاقة 1:1 مع Doctor
        public virtual Doctor? Doctor { get; set; }
    }
    public enum UserRole
    {
        Admin,
        Doctor,
        Receptionist
    }

}
