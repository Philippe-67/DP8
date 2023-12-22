using System.ComponentModel.DataAnnotations;

namespace ServiceAgendaPraticien.Models
{
    public class Praticien
    {
        [Key]
        public int PraticienId { get; set; }
        public string Nom    { get;set; }
        public string Prenom { get; set;}
        public string Specialite { get; set;}

        // Relation avec les agendas du praticien
        public List<Agenda>? Agendas { get; set; }
    }
}
