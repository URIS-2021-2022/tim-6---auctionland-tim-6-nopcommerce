﻿// <auto-generated />
using System;
using Komisija_Agregat.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Komisija_Agregat.Migrations
{
    [DbContext(typeof(KomisijaContext))]
    partial class KomisijaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Komisija_Agregat.Entities.ClanKomisije", b =>
                {
                    b.Property<Guid>("ClanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailClana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeClana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("KomisijaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrezimeClana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanId");

                    b.HasIndex("KomisijaId");

                    b.ToTable("ClanoviKomisije");
                });

            modelBuilder.Entity("Komisija_Agregat.Entities.Komisija", b =>
                {
                    b.Property<Guid>("KomisijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PredsednikId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("KomisijaId");

                    b.HasIndex("PredsednikId");

                    b.ToTable("Komisije");
                });

            modelBuilder.Entity("Komisija_Agregat.Entities.Predsednik", b =>
                {
                    b.Property<Guid>("PredsednikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailPredsednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePredsednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimePredsednika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PredsednikId");

                    b.ToTable("Predsednici");
                });

            modelBuilder.Entity("Komisija_Agregat.Entities.ClanKomisije", b =>
                {
                    b.HasOne("Komisija_Agregat.Entities.Komisija", "Komisija")
                        .WithMany("Clanovi")
                        .HasForeignKey("KomisijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Komisija");
                });

            modelBuilder.Entity("Komisija_Agregat.Entities.Komisija", b =>
                {
                    b.HasOne("Komisija_Agregat.Entities.Predsednik", "PredsednikKomisije")
                        .WithMany()
                        .HasForeignKey("PredsednikId");

                    b.Navigation("PredsednikKomisije");
                });

            modelBuilder.Entity("Komisija_Agregat.Entities.Komisija", b =>
                {
                    b.Navigation("Clanovi");
                });
#pragma warning restore 612, 618
        }
    }
}
