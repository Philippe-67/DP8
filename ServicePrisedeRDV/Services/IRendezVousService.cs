using System;
using System.Collections.Generic;
using ServicePrisedeRDV.Models;


namespace ServicePriseDeRDV.Services
{
    public interface IRendezVousService
    {
        IEnumerable<RendezVous> GetRendezVous();
        RendezVous GetRendezVousById(int id);
        RendezVous AddRendezVous(RendezVous rendezVous);
        RendezVous UpdateRendezVous(int id, RendezVous rendezVous);
        bool DeleteRendezVous(int id);
    }
}
