using Microsoft.AspNetCore.Mvc;
using ServicePrisedeRDV.Models;
using ServicePriseDeRDV.Services;

namespace ServicePriseDeRDV.Controllers
{
    [Route("api/RendezVous")]
    [ApiController]
    public class RendezVousController : ControllerBase
    {
        private readonly IRendezVousService _rendezVousService;

        public RendezVousController(IRendezVousService rendezVousService)
        {
            _rendezVousService = rendezVousService;
        }

        [HttpGet]
        public IActionResult GetRendezVous()
        {
            var rendezVous = _rendezVousService.GetRendezVous();
            return Ok(rendezVous);
        }

        [HttpGet("{id}")]
        public IActionResult GetRendezVousById(int id)
        {
            var rendezVous = _rendezVousService.GetRendezVousById(id);

            if (rendezVous == null)
                return NotFound();

            return Ok(rendezVous);
        }

        [HttpPost]
        public IActionResult AddRendezVous([FromBody] RendezVous rendezVous)
        {
            var addedRendezVous = _rendezVousService.AddRendezVous(rendezVous);
            return CreatedAtAction(nameof(GetRendezVousById), new { id = addedRendezVous.Id }, addedRendezVous);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRendezVous(int id, [FromBody] RendezVous rendezVous)
        {
            var updatedRendezVous = _rendezVousService.UpdateRendezVous(id, rendezVous);

            if (updatedRendezVous == null)
                return NotFound();

            return Ok(updatedRendezVous);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRendezVous(int id)
        {
            var isDeleted = _rendezVousService.DeleteRendezVous(id);

            if (!isDeleted)
                return NotFound();

            return NoContent();
        }
    }
}
