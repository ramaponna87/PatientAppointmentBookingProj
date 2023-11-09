namespace PatientAppointmentBookingProj.Models.ViewModel
{
    public class PatientAppointmentVM
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Issue { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public bool isApproved { get; set; }


    }
}
