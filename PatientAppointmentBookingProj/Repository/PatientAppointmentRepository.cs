using PatientAppointmentBookingProj.Data;
using PatientAppointmentBookingProj.Models.ViewModel;
using PatientAppointmentBookingProj.Repository.IRepository;

namespace PatientAppointmentBookingProj.Repository
{
    public class PatientAppointmentRepository : IPatientAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientAppointmentRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public Task<IEnumerable<PatientAppointmentVM>> GetAllAppointments()
        {
            throw new NotImplementedException();
        }
    }
}
