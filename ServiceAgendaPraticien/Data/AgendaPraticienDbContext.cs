using ServiceAgendaPraticien.Models;
using Microsoft.EntityFrameworkCore;

namespace ServiceAgendaPraticien.Data
{
    public class AgendaPraticienDbContext:DbContext
    {
         
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }

      
    }
}

