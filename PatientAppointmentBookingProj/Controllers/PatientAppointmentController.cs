using Microsoft.AspNetCore.Mvc;
using PatientAppointmentBookingProj.Repository.IRepository;

namespace PatientAppointmentBookingProj.Controllers
{
    public class PatientAppointmentController : Controller
    {
        private readonly IPatientAppointmentRepository _patientdbRepository;

        public PatientAppointmentController(IPatientAppointmentRepository patientdbRepository)
        {
            _patientdbRepository = patientdbRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
