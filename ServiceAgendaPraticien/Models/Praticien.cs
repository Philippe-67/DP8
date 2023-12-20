namespace ServiceAgendaPraticien.Models
{
    public class Praticien
    {
        public int PaticienId { get; set; }
        public string Nom    { get;set; }
        public string Prenom { get; set;}
        public int Specialite { get; set;}
        // Relation avec les agendas du praticien
        public List<Agenda> Agendas { get; set; }
    }
}
