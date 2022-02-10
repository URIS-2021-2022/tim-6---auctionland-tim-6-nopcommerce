﻿// <auto-generated />
using System;
using Liciter___Agregat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Liciter___Agregat.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220208125612_InitialCreat")]
    partial class InitialCreat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Liciter___Agregat.Models.FizickoLiceModel", b =>
                {
                    b.Property<Guid>("FizickoLiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojRacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FizickoLiceId");

                    b.ToTable("FizickoLiceModels");
                });

            modelBuilder.Entity("Liciter___Agregat.Models.PravnoLiceModel", b =>
                {
                    b.Property<Guid>("PravnoLiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojRacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KontaktOsoba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaticniBroj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PravnoLiceId");

                    b.ToTable("PravnoLiceModels");
                });
#pragma warning restore 612, 618
        }
    }
}
