﻿// <auto-generated />
using System;
using HRBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HRBackend.Migrations
{
    [DbContext(typeof(HRBackendContext))]
    [Migration("20240917215206_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HRBackend.Models.Candidatos.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrincipalesCapacitaciones")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrincipalesCompetencias")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PuestoAspira")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecomendadoPor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SalarioAspira")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("HRBackend.Models.Candidatos.ExperienciaLaboral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidatoId")
                        .HasColumnType("integer");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaDesde")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaHasta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PuestoOcupado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Salario")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("ExperienciaLaborals");
                });

            modelBuilder.Entity("HRBackend.Models.Empleado.Capacitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaDesde")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaHasta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Institucion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Capacitacions");
                });

            modelBuilder.Entity("HRBackend.Models.Empleado.Competencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("HRBackend.Models.Empleado.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SalarioMensual")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("HRBackend.Models.Empleado.Idioma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Idiomas");
                });

            modelBuilder.Entity("HRBackend.Models.Empleado.Puesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<decimal>("NivelMaximoSalario")
                        .HasColumnType("numeric");

                    b.Property<decimal>("NivelMinimoSalario")
                        .HasColumnType("numeric");

                    b.Property<string>("NivelRiesgo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("HRBackend.Models.Candidatos.ExperienciaLaboral", b =>
                {
                    b.HasOne("HRBackend.Models.Candidatos.Candidato", null)
                        .WithMany("ExperienciaLaboral")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("HRBackend.Models.Candidatos.Candidato", b =>
                {
                    b.Navigation("ExperienciaLaboral");
                });
#pragma warning restore 612, 618
        }
    }
}
