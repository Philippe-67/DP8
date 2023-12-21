namespace ServicePrisedeRDV.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        // Propriété de navigation
        public ICollection<RendezVous> RendezVous { get; set; }
    }
}
