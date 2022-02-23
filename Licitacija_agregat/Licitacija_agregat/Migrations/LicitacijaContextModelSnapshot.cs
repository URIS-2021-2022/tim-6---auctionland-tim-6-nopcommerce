﻿// <auto-generated />
using System;
using Licitacija_agregat.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Licitacija_agregat.Migrations
{
    [DbContext(typeof(LicitacijaContext))]
    partial class LicitacijaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Licitacija_agregat.Entities.Etapa", b =>
                {
                    b.Property<Guid>("EtapaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojEtape")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dan")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LicitacijaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EtapaId");

                    b.HasIndex("LicitacijaId");

                    b.ToTable("Etape");
                });

            modelBuilder.Entity("Licitacija_agregat.Entities.Licitacija", b =>
                {
                    b.Property<Guid>("LicitacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Broj")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Godina")
                        .HasColumnType("int");

                    b.Property<int>("Korak_cene")
                        .HasColumnType("int");

                    b.Property<int>("Ogranicenje")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Rok_za_dostavljanje_prijave")
                        .HasColumnType("datetime2");

                    b.HasKey("LicitacijaId");

                    b.ToTable("Licitacije");

                    b.HasData(
                        new
                        {
                            LicitacijaId = new Guid("e1f1f516-a9c4-4209-baa7-02e1583484ce"),
                            Broj = 5,
                            Datum = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Godina = 2005,
                            Korak_cene = 5,
                            Ogranicenje = 5,
                            ProgramId = new Guid("d684e88a-a3ef-40b8-a3c5-c73012d1cf26"),
                            Rok_za_dostavljanje_prijave = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Licitacija_agregat.Entities.Etapa", b =>
                {
                    b.HasOne("Licitacija_agregat.Entities.Licitacija", "Licitacija")
                        .WithMany("ListaEtapa")
                        .HasForeignKey("LicitacijaId");

                    b.Navigation("Licitacija");
                });

            modelBuilder.Entity("Licitacija_agregat.Entities.Licitacija", b =>
                {
                    b.Navigation("ListaEtapa");
                });
#pragma warning restore 612, 618
        }
    }
}
