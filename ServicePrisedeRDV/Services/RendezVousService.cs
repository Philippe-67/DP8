using ServicePrisedeRDV.Data;
using ServicePrisedeRDV.Models;

namespace ServicePriseDeRDV.Services
{
    public class RendezVousService : IRendezVousService
    {
        private readonly PriseDeRDVDbContext _context;

        public RendezVousService(PriseDeRDVDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RendezVous> GetRendezVous()
        {
            return _context.RendezVous.ToList();
        }

        public RendezVous GetRendezVousById(int id)
        {
            return _context.RendezVous.Find(id);
        }

        public RendezVous AddRendezVous(RendezVous rendezVous)
        {
            _context.RendezVous.Add(rendezVous);
            _context.SaveChanges();
            return rendezVous;
        }

        public RendezVous UpdateRendezVous(int id, RendezVous rendezVous)
        {
            var existingRendezVous = _context.RendezVous.Find(id);

            if (existingRendezVous != null)
            {
                existingRendezVous.Date = rendezVous.Date;
                // Mettez à jour d'autres propriétés si nécessaire

                _context.SaveChanges();
                return existingRendezVous;
            }

            return null;
        }

        public bool DeleteRendezVous(int id)
        {
            var existingRendezVous = _context.RendezVous.Find(id);

            if (existingRendezVous != null)
            {
                _context.RendezVous.Remove(existingRendezVous);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

