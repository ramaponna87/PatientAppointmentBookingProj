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
        public async Task<IEnumerable<PatientAppointmentVM>> GetAllAppointments()
        {
            try
            {
                var all = await _context.PatientAppointments.Select(x =>
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

        //Get apppointment details by Id
        public PatientAppointmentVM GetAppointmentDetailsById(int id)
        {
            try
            {
                var details = _context.PatientAppointments.Where(x => x.Id == id).Select(x => new PatientViewModel
                {
                    id = x.Id,
                    Name = x.Name,
                    AppointmentDateTime = x.AppointmentDateTime,
                    Issue = x.Issue,
                    Email = x.EmailAddress,
                    ContactNumber = x.ContactNumber,
                    isApproved = x.isApproved

                }).First();

                return details;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Save appointment Details
        public PatientAppointmentVM SaveAppointmentDetails(PatientAppointmentVM details)
        {
            try
            {
                var ApDetails = new PatientAppointments()
                {
                    Name = details.Name,
                    AppointmentDateTime = details.AppointmentDateTime,
                    Issue = details.Issue,
                    ContactNumber = details.ContactNumber,
                    EmailAddress = details.Email,
                    isApproved = details.isApproved
                };
                _context.PatientAppointments.Add(ApDetails);
                _context.SaveChanges();
                return details;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PatientAppointmentVM UpdateAppointmentDetailsById(PatientAppointmentVM details)
        {
            var exists = _context.PatientAppointments.Any(x => x.Name == details.Name && x.AppointmentDateTime == details.AppointmentDateTime);
            if (!exists)
            {
                var ApDetails = new PatientAppointments()
                {
                    Name = details.Name,
                    AppointmentDateTime = details.AppointmentDateTime,
                    Issue = details.Issue,
                    ContactNumber = details.ContactNumber,
                    EmailAddress = details.Email,

                };
                _context.PatientAppointments.Update(ApDetails);
                _context.SaveChanges();
                return details;
            }

            return details;
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
