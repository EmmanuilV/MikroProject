﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAirport.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyAirport.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20210513073132_BaseTables")]
    partial class BaseTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MyAirport.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("ID")
                        .HasName("pk_citys");

                    b.ToTable("citys");
                });

            modelBuilder.Entity("MyAirport.Models.Flight", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<int?>("FinishCityID")
                        .HasColumnType("integer")
                        .HasColumnName("finish_city_id");

                    b.Property<int>("Places")
                        .HasColumnType("integer")
                        .HasColumnName("places");

                    b.Property<int?>("StartCityID")
                        .HasColumnType("integer")
                        .HasColumnName("start_city_id");

                    b.HasKey("ID")
                        .HasName("pk_flights");

                    b.HasIndex("FinishCityID")
                        .HasDatabaseName("ix_flights_finish_city_id");

                    b.HasIndex("StartCityID")
                        .HasDatabaseName("ix_flights_start_city_id");

                    b.ToTable("flights");
                });

            modelBuilder.Entity("MyAirport.Models.Flight", b =>
                {
                    b.HasOne("MyAirport.Models.City", "FinishCity")
                        .WithMany()
                        .HasForeignKey("FinishCityID")
                        .HasConstraintName("fk_flights_citys_finish_city_id");

                    b.HasOne("MyAirport.Models.City", "StartCity")
                        .WithMany()
                        .HasForeignKey("StartCityID")
                        .HasConstraintName("fk_flights_citys_start_city_id");

                    b.Navigation("FinishCity");

                    b.Navigation("StartCity");
                });
#pragma warning restore 612, 618
        }
    }
}