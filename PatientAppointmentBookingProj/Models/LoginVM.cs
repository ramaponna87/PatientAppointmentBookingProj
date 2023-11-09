﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PatientAppointmentBookingProj.Models
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}