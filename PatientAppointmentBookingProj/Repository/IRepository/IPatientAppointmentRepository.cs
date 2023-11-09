using PatientAppointmentBookingProj.Models.ViewModel;

namespace PatientAppointmentBookingProj.Repository.IRepository
{
    public interface IPatientAppointmentRepository
    {
        Task<IEnumerable<PatientAppointmentVM>> GetAllAppointments();

    }
}
