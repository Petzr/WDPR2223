﻿// <auto-generated />
using System;
using Laak.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace wdpr.Migrations
{
    [DbContext(typeof(TheaterContext))]
    partial class TheaterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Laak.Models.Artiest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bandid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Bandid");

                    b.ToTable("Artiest");
                });

            modelBuilder.Entity("Laak.Models.Band", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Band");
                });

            modelBuilder.Entity("Laak.Models.Voorstelling", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Artiestid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bankid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Prijs")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Tijd")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ZaalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Artiestid");

                    b.HasIndex("Bankid");

                    b.HasIndex("ZaalId");

                    b.ToTable("Voorstellingen");
                });

            modelBuilder.Entity("Laak.Models.Zaal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AantalStoelen")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Zaal");
                });

            modelBuilder.Entity("Laak.Models.Artiest", b =>
                {
                    b.HasOne("Laak.Models.Band", null)
                        .WithMany("Artiest")
                        .HasForeignKey("Bandid");
                });

            modelBuilder.Entity("Laak.Models.Voorstelling", b =>
                {
                    b.HasOne("Laak.Models.Artiest", "Artiest")
                        .WithMany()
                        .HasForeignKey("Artiestid");

                    b.HasOne("Laak.Models.Band", "Bank")
                        .WithMany("Voorstellingen")
                        .HasForeignKey("Bankid");

                    b.HasOne("Laak.Models.Zaal", "Zaal")
                        .WithMany()
                        .HasForeignKey("ZaalId");

                    b.Navigation("Artiest");

                    b.Navigation("Bank");

                    b.Navigation("Zaal");
                });

            modelBuilder.Entity("Laak.Models.Band", b =>
                {
                    b.Navigation("Artiest");

                    b.Navigation("Voorstellingen");
                });
#pragma warning restore 612, 618
        }
    }
}
