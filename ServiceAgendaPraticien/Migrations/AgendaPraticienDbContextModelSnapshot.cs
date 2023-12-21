﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceAgendaPraticien.Data;

#nullable disable

namespace ServiceAgendaPraticien.Migrations
{
    [DbContext(typeof(AgendaPraticienDbContext))]
    partial class AgendaPraticienDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ServiceAgendaPraticien.Models.Agenda", b =>
                {
                    b.Property<int>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgendaId"), 1L, 1);

                    b.Property<int>("PraticienId")
                        .HasColumnType("int");

                    b.HasKey("AgendaId");

                    b.HasIndex("PraticienId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("ServiceAgendaPraticien.Models.Praticien", b =>
                {
                    b.Property<int>("PaticienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaticienId"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Specialite")
                        .HasColumnType("int");

                    b.HasKey("PaticienId");

                    b.ToTable("Praticiens");
                });

            modelBuilder.Entity("ServiceAgendaPraticien.Models.Agenda", b =>
                {
                    b.HasOne("ServiceAgendaPraticien.Models.Praticien", "Praticien")
                        .WithMany("Agendas")
                        .HasForeignKey("PraticienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Praticien");
                });

            modelBuilder.Entity("ServiceAgendaPraticien.Models.Praticien", b =>
                {
                    b.Navigation("Agendas");
                });
#pragma warning restore 612, 618
        }
    }
}