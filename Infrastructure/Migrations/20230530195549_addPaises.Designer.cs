﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DestinosContext))]
    [Migration("20230530195549_addPaises")]
    partial class addPaises
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("CiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CiudadId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("CiudadId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Escala", b =>
                {
                    b.Property<int>("EscalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EscalaId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraLlegada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreParada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViajeId")
                        .HasColumnType("int");

                    b.HasKey("EscalaId");

                    b.HasIndex("CiudadId");

                    b.ToTable("Escala", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaisId"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaisId");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Provincia", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinciaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaId");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincia", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ViajeCiudad", b =>
                {
                    b.Property<int>("ViajeCiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ViajeCiudadId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<int>("ViajeId")
                        .HasColumnType("int");

                    b.HasKey("ViajeCiudadId");

                    b.HasIndex("CiudadId");

                    b.ToTable("ViajeCiudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Provincia", "Provincia")
                        .WithMany("Ciudades")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("Domain.Entities.Escala", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudad")
                        .WithMany("Escalas")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("Domain.Entities.Provincia", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Domain.Entities.ViajeCiudad", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudad")
                        .WithMany("ViajeCiudades")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Escalas");

                    b.Navigation("ViajeCiudades");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Provincias");
                });

            modelBuilder.Entity("Domain.Entities.Provincia", b =>
                {
                    b.Navigation("Ciudades");
                });
#pragma warning restore 612, 618
        }
    }
}
