using Microsoft.AspNetCore.Mvc;

namespace PatientAppointmentBookingProj.Controllers
{
    public class PatientAppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
