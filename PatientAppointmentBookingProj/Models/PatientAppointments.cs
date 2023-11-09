using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PatientAppointmentBookingProj.Models
{
    public class PatientAppointments
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please select a date")]

        public string Name { get; set; }

        [Required]
        public string Issue { get; set; }

        [Display(Name = "Appointment Date and Time")]
        [Required(ErrorMessage = "Please select a date")]
        public DateTime AppointmentDateTime { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public bool isApproved { get; set; }

    }
}
