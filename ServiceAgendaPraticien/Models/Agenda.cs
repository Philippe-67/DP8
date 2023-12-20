namespace ServiceAgendaPraticien.Models
{
    public class Agenda
    {
        public int AgendaId { get; set; }

        // Relation avec le praticien
        public int PraticienId { get; set; }
        public Praticien Praticien { get; set; }
    }
}
