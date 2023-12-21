using Microsoft.AspNetCore.Mvc;
using ServiceAgendaPraticien.Models;
using ServiceAgendaPraticien.Services;

namespace ServiceAgendaPraticien.Controllers
{
    [ApiController]
    [Route("api/agendas")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaService _agendaService;

        public AgendaController(IAgendaService agendaService)
        {
            _agendaService = agendaService;
        }

        [HttpGet]
        public IActionResult GetAllAgendas()
        {
            var agenda = _agendaService.GetAgendas();
            return Ok(agenda);

        }
        [HttpGet("id)")]
        public IActionResult GetAgendaById(int id)
        {
            var agenda = _agendaService.GetAgendaById(id);
            if (agenda == null)
                return NotFound();

            return Ok(agenda);
        }
        [HttpPost]
        public IActionResult CreateAgenda([FromBody] Agenda agenda)
        {
            _agendaService.CreateAgenda(agenda);
            return CreatedAtAction(nameof(GetAgendaById), new { id = agenda }, agenda);
        }
        [HttpPut("id")]
        public IActionResult UpdateAgenda(int id, [FromBody] Agenda agenda)
        {
            if (id != agenda.AgendaId)
                return BadRequest();
            _agendaService.UpdateAgenda(agenda);
            return NoContent();
        }
        [HttpDelete("id")]
        public IActionResult DeleteAgenda(int id)
        {
            _agendaService.DeleteAgenda(id);
            return NoContent();
        }
    }
}
