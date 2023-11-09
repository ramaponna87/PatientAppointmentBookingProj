using Microsoft.AspNetCore.Identity;

namespace PatientAppointmentBookingProj.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
