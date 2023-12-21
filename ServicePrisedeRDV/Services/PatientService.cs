using System.Collections.Generic;
using System.Linq;
using ServicePrisedeRDV.Data;
using ServicePrisedeRDV.Models;

namespace ServicePriseDeRDV.Services
{
    public class PatientService : IPatientService
    {
        private readonly PriseDeRDVDbContext _context;

        public PatientService(PriseDeRDVDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return _context.Patients.Find(id);
        }

        public Patient AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }

        public Patient UpdatePatient(int id, Patient patient)
        {
            var existingPatient = _context.Patients.Find(id);

            if (existingPatient != null)
            {
                existingPatient.Nom = patient.Nom;
                // Mettez à jour d'autres propriétés si nécessaire

                _context.SaveChanges();
                return existingPatient;
            }

            return null;
        }

        public bool DeletePatient(int id)
        {
            var existingPatient = _context.Patients.Find(id);

            if (existingPatient != null)
            {
                _context.Patients.Remove(existingPatient);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
