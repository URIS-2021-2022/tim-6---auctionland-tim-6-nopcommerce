﻿// <auto-generated />
using System;
using Javno_Nadmetanje_Agregat.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Javno_Nadmetanje_Agregat.Migrations
{
    [DbContext(typeof(JavnoNadmetanjeContext))]
    [Migration("20220223154430_ic")]
    partial class ic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.JavnoNadmetanje", b =>
                {
                    b.Property<Guid>("JavnoNadmetanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojUcesnika")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("IzlicitiranaCena")
                        .HasColumnType("int");

                    b.Property<bool>("Izuzeto")
                        .HasColumnType("bit");

                    b.Property<int>("Krug")
                        .HasColumnType("int");

                    b.Property<int>("PeriodZakupa")
                        .HasColumnType("int");

                    b.Property<int>("PocetnaCenaHektar")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusJavnogNadmetanjaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipJavnogNadmetanjaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VisinaDopuneDepozita")
                        .HasColumnType("int");

                    b.Property<DateTime>("VremeKraja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VremePocetka")
                        .HasColumnType("datetime2");

                    b.HasKey("JavnoNadmetanjeId");

                    b.HasIndex("StatusJavnogNadmetanjaId");

                    b.HasIndex("TipJavnogNadmetanjaId");

                    b.ToTable("JavnoNadmetanje");

                    b.HasData(
                        new
                        {
                            JavnoNadmetanjeId = new Guid("1ae8137b-1674-4c91-a4b5-87a133f5dd87"),
                            BrojUcesnika = 10,
                            Datum = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IzlicitiranaCena = 8000,
                            Izuzeto = false,
                            Krug = 1,
                            PeriodZakupa = 24,
                            PocetnaCenaHektar = 5000,
                            StatusJavnogNadmetanjaId = new Guid("167a01c0-2e68-46a8-b201-3a23e3a20bff"),
                            TipJavnogNadmetanjaId = new Guid("bc679089-e19f-43e4-946f-651ffbdb2afb"),
                            VisinaDopuneDepozita = 100,
                            VremeKraja = new DateTime(2022, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            VremePocetka = new DateTime(2022, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            JavnoNadmetanjeId = new Guid("94e9fb20-1834-433c-b588-4a6e4eb32150"),
                            BrojUcesnika = 10,
                            Datum = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IzlicitiranaCena = 8000,
                            Izuzeto = false,
                            Krug = 1,
                            PeriodZakupa = 24,
                            PocetnaCenaHektar = 5000,
                            StatusJavnogNadmetanjaId = new Guid("167a01c0-2e68-46a8-b201-3a23e3a20bff"),
                            TipJavnogNadmetanjaId = new Guid("bc679089-e19f-43e4-946f-651ffbdb2afb"),
                            VisinaDopuneDepozita = 100,
                            VremeKraja = new DateTime(2022, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            VremePocetka = new DateTime(2022, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            JavnoNadmetanjeId = new Guid("955f059b-94d9-442f-b7df-4b42538b7e07"),
                            BrojUcesnika = 10,
                            Datum = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IzlicitiranaCena = 8000,
                            Izuzeto = false,
                            Krug = 1,
                            PeriodZakupa = 24,
                            PocetnaCenaHektar = 5000,
                            StatusJavnogNadmetanjaId = new Guid("167a01c0-2e68-46a8-b201-3a23e3a20bff"),
                            TipJavnogNadmetanjaId = new Guid("bc679089-e19f-43e4-946f-651ffbdb2afb"),
                            VisinaDopuneDepozita = 100,
                            VremeKraja = new DateTime(2022, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            VremePocetka = new DateTime(2022, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.StatusJavnogNadmetanja", b =>
                {
                    b.Property<Guid>("StatusJavnogNadmetanjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NazivStatusaJavnogNadmetanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusJavnogNadmetanjaId");

                    b.ToTable("StatusJavnogNadmetanja");

                    b.HasData(
                        new
                        {
                            StatusJavnogNadmetanjaId = new Guid("167a01c0-2e68-46a8-b201-3a23e3a20bff"),
                            NazivStatusaJavnogNadmetanja = "Prvi krug"
                        },
                        new
                        {
                            StatusJavnogNadmetanjaId = new Guid("f876fbcc-a7d0-49f8-b6ef-9b5a59c44fa0"),
                            NazivStatusaJavnogNadmetanja = "Drugi krug sa starim uslovima"
                        },
                        new
                        {
                            StatusJavnogNadmetanjaId = new Guid("cb5b3279-811c-4ca4-abaa-69016ba157b6"),
                            NazivStatusaJavnogNadmetanja = "Drugi krug sa novim uslovima"
                        },
                        new
                        {
                            StatusJavnogNadmetanjaId = new Guid("955f059b-94d9-442f-b7df-4b42538b7e07"),
                            NazivStatusaJavnogNadmetanja = "Dummy za izmenu"
                        },
                        new
                        {
                            StatusJavnogNadmetanjaId = new Guid("94e9fb20-1834-433c-b588-4a6e4eb32150"),
                            NazivStatusaJavnogNadmetanja = "Dummy za brisanje"
                        });
                });

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.TipJavnogNadmetanja", b =>
                {
                    b.Property<Guid>("TipJavnogNadmetanjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NazivTipaJavnogNadmetanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipJavnogNadmetanjaId");

                    b.ToTable("TipJavnogNadmetanja");

                    b.HasData(
                        new
                        {
                            TipJavnogNadmetanjaId = new Guid("bc679089-e19f-43e4-946f-651ffbdb2afb"),
                            NazivTipaJavnogNadmetanja = "Javna licitacija"
                        },
                        new
                        {
                            TipJavnogNadmetanjaId = new Guid("d7a80343-d802-43d6-b128-79ba8554acd2"),
                            NazivTipaJavnogNadmetanja = "Otvaranje zatvorenih ponuda"
                        },
                        new
                        {
                            TipJavnogNadmetanjaId = new Guid("955f059b-94d9-442f-b7df-4b42538b7e07"),
                            NazivTipaJavnogNadmetanja = "Dummy za izmenu"
                        },
                        new
                        {
                            TipJavnogNadmetanjaId = new Guid("94e9fb20-1834-433c-b588-4a6e4eb32150"),
                            NazivTipaJavnogNadmetanja = "Dummy za brisanje"
                        });
                });

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.JavnoNadmetanje", b =>
                {
                    b.HasOne("Javno_Nadmetanje_Agregat.Entities.StatusJavnogNadmetanja", "StatusJavnogNadmetanja")
                        .WithMany("ListaJavnihNadmetanja")
                        .HasForeignKey("StatusJavnogNadmetanjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Javno_Nadmetanje_Agregat.Entities.TipJavnogNadmetanja", "TipJavnogNadmetanja")
                        .WithMany("ListaJavnihNadmetanja")
                        .HasForeignKey("TipJavnogNadmetanjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusJavnogNadmetanja");

                    b.Navigation("TipJavnogNadmetanja");
                });

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.StatusJavnogNadmetanja", b =>
                {
                    b.Navigation("ListaJavnihNadmetanja");
                });

            modelBuilder.Entity("Javno_Nadmetanje_Agregat.Entities.TipJavnogNadmetanja", b =>
                {
                    b.Navigation("ListaJavnihNadmetanja");
                });
#pragma warning restore 612, 618
        }
    }
}