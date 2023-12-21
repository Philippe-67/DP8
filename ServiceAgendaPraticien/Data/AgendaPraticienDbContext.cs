using ServiceAgendaPraticien.Models;
using Microsoft.EntityFrameworkCore;

namespace ServiceAgendaPraticien.Data
{
    public class AgendaPraticienDbContext:DbContext
    {

        public AgendaPraticienDbContext(DbContextOptions<AgendaPraticienDbContext> options)
        : base(options)
        {
        }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la clé primaire pour Agenda
            modelBuilder.Entity<Agenda>().HasKey(a => a.AgendaId);

            // Configuration de la relation entre Praticien et Agenda
            modelBuilder.Entity<Agenda>()
                .HasOne(a => a.Praticien)
                .WithMany(p => p.Agendas)
                .HasForeignKey(a => a.PraticienId)
                .OnDelete(DeleteBehavior.Cascade); // Vous pouvez ajuster le comportement de suppression selon vos besoins

            // Configuration de la clé primaire pour Praticien
            modelBuilder.Entity<Praticien>().HasKey(p => p.PraticienId);

            // Autres configurations si nécessaires

            base.OnModelCreating(modelBuilder);
        }
    }
}

