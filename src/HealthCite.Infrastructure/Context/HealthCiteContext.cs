using Microsoft.EntityFrameworkCore;
using HealthCite.Infrastructure.Models;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;

public class MedicalContext : DbContext
{
    public MedicalContext(DbContextOptions<MedicalContext> options) : base(options) { }

    public DbSet<CitaModel> Citas { get; set; }
    public DbSet<DepartamentoModel> Departamento { get; set; }
    public DbSet<DoctorModel> Doctor { get; set; }
    public DbSet<PacienteModel> Paciente { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


    }
}