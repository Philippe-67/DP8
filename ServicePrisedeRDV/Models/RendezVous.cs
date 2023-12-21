namespace ServicePrisedeRDV.Models
{
    public class RendezVous
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        // Clé étrangère
        public int PatientId { get; set; }

        // Propriété de navigation
        public Patient Patient { get; set; }
    }
}
