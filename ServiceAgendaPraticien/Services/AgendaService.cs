using Microsoft.EntityFrameworkCore;
using ServiceAgendaPraticien.Data;
using ServiceAgendaPraticien.Models;

namespace ServiceAgendaPraticien.Services
{
    public class AgendaService: IAgendaService
    {
        private readonly AgendaPraticienDbContext _context;

        public AgendaService(AgendaPraticienDbContext context)
        {
            _context = context;
        }

       

        public IEnumerable<Agenda>GetAgendas()
        {
            return _context.Agenda.ToList();
        }
        public void CreateAgenda(Agenda agenda)
        {
            _context.Agenda.Add(agenda);
            _context.SaveChanges();
        }

        public void UpdateAgenda(Agenda agenda)
        {
            _context.Entry(agenda).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAgenda(int id)
        {
            var agenda = _context.Agenda.Find(id);
            if (agenda != null)
            {
                _context.Agenda.Remove(agenda);
                _context.SaveChanges();
            }
        }

        Agenda IAgendaService.GetAgendaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
