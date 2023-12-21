using System.Collections.Generic;
using ServicePrisedeRDV.Models;


namespace ServicePriseDeRDV.Services
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatientById(int id);
        Patient AddPatient(Patient patient);
        Patient UpdatePatient(int id, Patient patient);
        bool DeletePatient(int id);
    }
}


