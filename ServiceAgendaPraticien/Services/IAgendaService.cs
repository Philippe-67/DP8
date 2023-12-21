using ServiceAgendaPraticien.Models;

namespace ServiceAgendaPraticien.Services
{
    public interface IAgendaService
    {
        IEnumerable<Agenda> GetAgendas();
        Agenda GetAgendaById(int id);
        void UpdateAgenda(Agenda agenda);
        void DeleteAgenda(int id);
        void CreateAgenda(Agenda agenda);
    }
}
