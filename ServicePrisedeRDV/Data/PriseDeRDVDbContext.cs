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
    }
}
