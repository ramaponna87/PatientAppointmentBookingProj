using Microsoft.AspNetCore.Mvc;
using PatientAppointmentBookingProj.Models.ViewModel;
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

        public async Task<IActionResult> GetAllAppointments()
        {
            var all = await _patientdbRepository.GetAllAppointments();
            return View(all);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new PatientAppointmentVM());
            }
            else
            {
                var patient = _patientdbRepository.GetAppointmentDetailsById(id);

                if (patient != null)
                {
                    return View(patient);
                }
                TempData["errorMessage"] = "Patient details not found";
                return RedirectToAction("GetAllAppointments");
            }

        }

        [HttpPost]
        public IActionResult CreateOrEdit(PatientAppointmentVM model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    if (model.id == 0)
                    {
                        _patientdbRepository.SaveAppointmentDetails(model);
                        TempData["successMessage"] = "details Added Successfully!";
                        return RedirectToAction(nameof(GetAllAppointments));
                    }
                    else
                    {
                        _patientdbRepository.UpdateAppointmentDetailsById(model);
                        TempData["successMessage"] = "Updated Successfully!";
                        return RedirectToAction(nameof(GetAllAppointments));
                    }

                }
                else
                {
                    TempData["errorMessage"] = "Model state is Invalid";
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }

            return View();

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var patientdetails = _patientdbRepository.Delete(id);
            return RedirectToAction(nameof(GetAllAppointments));
        }


        public bool approveAppointment(int id)
        {
            bool update = _patientdbRepository.approveappointment(id);
            return update;

        }



    }
}
