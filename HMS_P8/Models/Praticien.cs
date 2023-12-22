using System.ComponentModel.DataAnnotations;

namespace HMS_P8.Models
{
    public class Praticien
    {

        public int PraticienId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Specialite { get; set; }
    }
}
