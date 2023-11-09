using PatientAppointmentBookingProj.Models.ViewModel;

namespace PatientAppointmentBookingProj.Repository.IRepository
{
    public interface IPatientAppointmentRepository
    {
        Task<IEnumerable<PatientAppointmentVM>> GetAllAppointments();

        PatientAppointmentVM SaveAppointmentDetails(PatientAppointmentVM details);

        PatientAppointmentVM GetAppointmentDetailsById(int id);

        PatientAppointmentVM UpdateAppointmentDetailsById(PatientAppointmentVM details);

        Task Delete(int id);

        bool approveappointment(int id);

    }
}
