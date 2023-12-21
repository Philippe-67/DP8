using Microsoft.EntityFrameworkCore;
using ServiceAgendaPraticien.Data;
using ServiceAgendaPraticien.Models;

namespace ServiceAgendaPraticien.Services
{
    public class PraticiensService: IPraticienService
    {
        private readonly AgendaPraticienDbContext _context;

        public PraticiensService(AgendaPraticienDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Praticien> GetPraticiens() 
        {
            return _context.Praticiens.ToList();
        }
        public Praticien GetPraticienById(int id)
        {
            return _context.Praticiens.Find(id);
        }
        public void CreatePraticien(Praticien praticien)
        {
        _context.Praticiens.Add(praticien);
        _context.SaveChanges();
        }
        public void UpdatePraticien (Praticien praticien)
        {
            _context.Entry(praticien).State =EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeletePraticien(int id)
        {
            var praticien = _context.Praticiens.Find(id);
            if (praticien != null)
            {
                _context.Praticiens.Remove(praticien);
                _context.SaveChanges();
            }
        }
    }
}
