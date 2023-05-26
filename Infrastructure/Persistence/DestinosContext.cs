﻿using Domain.Entities;
using Infrastructure.Config;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Persistence
{
    public class DestinosContext : DbContext
    {


        public DbSet<ViajeCiudad> ViajeCiudades { get; set; }

        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Escala> Escalas { get; set; }

        public DbSet<Ciudad> Ciudades { get; set; }



        public DestinosContext(DbContextOptions<DestinosContext> options)
        : base(options) { }
        public DestinosContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Destinos;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False",
            options => options.EnableRetryOnFailure()); ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new PaisConfiguration(modelBuilder.Entity<Pais>());
            new ProvinciaConfiguration(modelBuilder.Entity<Provincia>());
            new CiudadConfiguration(modelBuilder.Entity<Ciudad>());
            new EscalaConfiguration(modelBuilder.Entity<Escala>());
            new ViajeCiudadConfiguration(modelBuilder.Entity<ViajeCiudad>());
         


            base.OnModelCreating(modelBuilder);


        }

      
    

}

}
