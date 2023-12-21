using Microsoft.EntityFrameworkCore;
using ServicePrisedeRDV.Models;
using System;

namespace ServicePrisedeRDV.Data
{
    public class PriseDeRDVDbContext:DbContext
    {
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public PriseDeRDVDbContext(DbContextOptions<PriseDeRDVDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RendezVous>()
                .HasOne(r => r.Patient)
                .WithMany(p => p.RendezVous)
                .HasForeignKey(r => r.PatientId);

            // Autres configurations si nécessaires

            base.OnModelCreating(modelBuilder);
        }
    }
}
