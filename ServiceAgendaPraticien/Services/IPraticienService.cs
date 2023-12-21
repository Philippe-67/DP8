using ServiceAgendaPraticien.Models;

namespace ServiceAgendaPraticien.Services
{
    public interface IPraticienService
    {
        IEnumerable<Praticien> GetPraticiens();
        Praticien GetPraticienById(int id);
        void CreatePraticien(Praticien praticien);
        void UpdatePraticien(Praticien praticien);
        void DeletePraticien(int id);
    }
}
