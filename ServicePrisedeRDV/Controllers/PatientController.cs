using Microsoft.AspNetCore.Mvc;
using ServicePrisedeRDV.Models;

//using ServicePriseDeRDV.Models;
using ServicePriseDeRDV.Services;

namespace ServicePriseDeRDV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            var patients = _patientService.GetPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatientById(int id)
        {
            var patient = _patientService.GetPatientById(id);

            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        [HttpPost]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            var addedPatient = _patientService.AddPatient(patient);
            return CreatedAtAction(nameof(GetPatientById), new { id = addedPatient.PatientId }, addedPatient);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePatient(int id, [FromBody] Patient patient)
        {
            var updatedPatient = _patientService.UpdatePatient(id, patient);

            if (updatedPatient == null)
                return NotFound();

            return Ok(updatedPatient);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)
        {
            var isDeleted = _patientService.DeletePatient(id);

            if (!isDeleted)
                return NotFound();

            return NoContent();
        }
    }
}
