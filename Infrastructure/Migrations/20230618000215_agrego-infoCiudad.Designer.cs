﻿// <auto-generated />
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
    [Migration("20230618000215_agrego-infoCiudad")]
    partial class agregoinfoCiudad
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

                    b.HasData(
                        new
                        {
                            CiudadId = 1,
                            Nombre = "La Plata",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 2,
                            Nombre = "Mar del Plata",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 3,
                            Nombre = "Bahía Blanca",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 4,
                            Nombre = "San Nicolás de los Arroyos",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 5,
                            Nombre = "Pergamino",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 6,
                            Nombre = "Tandil",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 7,
                            Nombre = "Junín",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 8,
                            Nombre = "Olavarría",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 9,
                            Nombre = "Azul",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 10,
                            Nombre = "Necochea",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 11,
                            Nombre = "Zárate",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 12,
                            Nombre = "Campana",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 13,
                            Nombre = "Morón",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 14,
                            Nombre = "Quilmes",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 15,
                            Nombre = "Avellaneda",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 16,
                            Nombre = "Lomas de Zamora",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 17,
                            Nombre = "Lanús",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 18,
                            Nombre = "San Isidro",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 19,
                            Nombre = "Tigre",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 20,
                            Nombre = "Vicente López",
                            ProvinciaId = 1
                        },
                        new
                        {
                            CiudadId = 21,
                            Nombre = "Varela",
                            ProvinciaId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.InfoCiudad", b =>
                {
                    b.Property<int>("InfoCiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfoCiudadId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoCiudadId");

                    b.HasIndex("CiudadId")
                        .IsUnique();

                    b.ToTable("InfoCiudad");
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

                    b.HasData(
                        new
                        {
                            PaisId = 1,
                            Codigo = "Arg",
                            Nombre = "Argentina"
                        },
                        new
                        {
                            PaisId = 2,
                            Codigo = "Br",
                            Nombre = "Brasil"
                        },
                        new
                        {
                            PaisId = 3,
                            Codigo = "Uy",
                            Nombre = "Uruguay"
                        });
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

                    b.HasData(
                        new
                        {
                            ProvinciaId = 1,
                            Nombre = "Buenos Aires",
                            PaisId = 1
                        },
                        new
                        {
                            ProvinciaId = 2,
                            Nombre = "Tierra del Fuego",
                            PaisId = 1
                        },
                        new
                        {
                            ProvinciaId = 3,
                            Nombre = "Bahía",
                            PaisId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.ViajeCiudad", b =>
                {
                    b.Property<int>("ViajeCiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ViajeCiudadId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViajeId")
                        .HasColumnType("int");

                    b.HasKey("ViajeCiudadId");

                    b.HasIndex("CiudadId");

                    b.ToTable("ViajeCiudades");
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

            modelBuilder.Entity("Domain.Entities.InfoCiudad", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudad")
                        .WithOne("infoCiudad")
                        .HasForeignKey("Domain.Entities.InfoCiudad", "CiudadId")
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
                    b.Navigation("ViajeCiudades");

                    b.Navigation("infoCiudad")
                        .IsRequired();
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
