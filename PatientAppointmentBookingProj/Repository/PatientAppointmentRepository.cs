using Microsoft.EntityFrameworkCore;
using PatientAppointmentBookingProj.Data;
using PatientAppointmentBookingProj.Models;
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

      
        //Get all apppointments
        public Task<IEnumerable<PatientAppointmentVM>> GetAllAppointments()
        {
            try
            {
                var all = _context.PatientAppointments.Select(x =>
                          new PatientAppointmentVM
                          {
                              id = x.Id,
                              Name = x.Name,
                              AppointmentDateTime = x.AppointmentDateTime,
                              Issue = x.Issue,
                              Email = x.EmailAddress,
                              ContactNumber = x.ContactNumber,
                              isApproved = x.isApproved
                          }).ToListAsync();
                return all;
            }
            catch (Exception ex)
            {
                //log exceptions
                throw ex;
            }

        }

        public PatientAppointmentVM GetAppointmentDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public PatientAppointmentVM SaveAppointmentDetails(PatientAppointmentVM details)
        {
            throw new NotImplementedException();
        }

        public PatientAppointmentVM UpdateAppointmentDetailsById(PatientAppointmentVM details)
        {
            throw new NotImplementedException();
        }

        public bool approveappointment(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
