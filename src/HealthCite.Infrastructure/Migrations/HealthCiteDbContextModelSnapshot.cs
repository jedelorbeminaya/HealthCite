﻿// <auto-generated />
using System;
using HealthCite.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthCite.Infrastructure.Migrations
{
    [DbContext(typeof(HealthCiteDbContext))]
    partial class HealthCiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthCite.Domain.Entities.Citas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Consultorios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CitasIDId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctoresId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitasIDId");

                    b.HasIndex("DoctoresId");

                    b.ToTable("Consultorios");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Doctores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CitasId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitasId");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Especialidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConsultorioIDId")
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultorioIDId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.EstadoCitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CitaIDId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitaIDId");

                    b.ToTable("EstadosCitas");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.HistorialMedico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Antecedentes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enfermedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicacionesActuales")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HistoriaMedico");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Pacientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CitasId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistorialMedicoIDId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CitasId");

                    b.HasIndex("HistorialMedicoIDId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuariosIDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosIDId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Consultorios", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Citas", "CitasID")
                        .WithMany("ConsultorioID")
                        .HasForeignKey("CitasIDId");

                    b.HasOne("HealthCite.Domain.Entities.Doctores", "Doctores")
                        .WithMany("ConsultorioID")
                        .HasForeignKey("DoctoresId");

                    b.Navigation("CitasID");

                    b.Navigation("Doctores");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Doctores", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Citas", "Citas")
                        .WithMany("DoctoresID")
                        .HasForeignKey("CitasId");

                    b.Navigation("Citas");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Especialidades", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Consultorios", "ConsultorioID")
                        .WithMany("EspecialidadID")
                        .HasForeignKey("ConsultorioIDId");

                    b.Navigation("ConsultorioID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.EstadoCitas", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Citas", "CitaID")
                        .WithMany("EstadoID")
                        .HasForeignKey("CitaIDId");

                    b.Navigation("CitaID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Pacientes", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Citas", "Citas")
                        .WithMany("PacienteID")
                        .HasForeignKey("CitasId");

                    b.HasOne("HealthCite.Domain.Entities.HistorialMedico", "HistorialMedicoID")
                        .WithMany("PacienteID")
                        .HasForeignKey("HistorialMedicoIDId");

                    b.Navigation("Citas");

                    b.Navigation("HistorialMedicoID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Roles", b =>
                {
                    b.HasOne("HealthCite.Domain.Entities.Usuarios", "UsuariosID")
                        .WithMany("RolID")
                        .HasForeignKey("UsuariosIDId");

                    b.Navigation("UsuariosID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Citas", b =>
                {
                    b.Navigation("ConsultorioID");

                    b.Navigation("DoctoresID");

                    b.Navigation("EstadoID");

                    b.Navigation("PacienteID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Consultorios", b =>
                {
                    b.Navigation("EspecialidadID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Doctores", b =>
                {
                    b.Navigation("ConsultorioID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.HistorialMedico", b =>
                {
                    b.Navigation("PacienteID");
                });

            modelBuilder.Entity("HealthCite.Domain.Entities.Usuarios", b =>
                {
                    b.Navigation("RolID");
                });
#pragma warning restore 612, 618
        }
    }
}
