using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceAgendaPraticien.Models;
using ServiceAgendaPraticien.Services;

namespace ServiceAgendaPraticien.Controllers
{
    [ApiController]
    [Route("api/Praticiens")]
    public class PraticienController : ControllerBase
    {
        private readonly IPraticienService _praticienService;

        public PraticienController(IPraticienService praticienService)
        {
            _praticienService = praticienService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetPraticiens()
        {
            var praticiens = _praticienService.GetPraticiens();
            return Ok(praticiens);
        }

        [HttpGet("{id}")]
        public IActionResult GetPraticienById(int id)
        {
            var praticien = _praticienService.GetPraticienById(id);
            if (praticien == null)
            {
                return NotFound();
            }
            return Ok(praticien);
        }

        [HttpPost]
        public IActionResult CreatePraticien([FromBody] Praticien praticien)
        {
            if (praticien == null)
            {
                return BadRequest();
            }

            _praticienService.CreatePraticien(praticien);
            return CreatedAtAction(nameof(GetPraticienById), new { id = praticien.PraticienId }, praticien);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePraticien(int id, [FromBody] Praticien praticien)
        {
            if (praticien == null || id != praticien.PraticienId)
            {
                return BadRequest();
            }

            var existingPraticien = _praticienService.GetPraticienById(id);
            if (existingPraticien == null)
            {
                return NotFound();
            }

            _praticienService.UpdatePraticien(praticien);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePraticien(int id)
        {
            var praticien = _praticienService.GetPraticienById(id);
            if (praticien == null)
            {
                return NotFound();
            }

            _praticienService.DeletePraticien(id);
            return NoContent();
        }
    }
}

