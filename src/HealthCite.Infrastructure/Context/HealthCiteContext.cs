using Microsoft.EntityFrameworkCore;
using HealthCite.Infrastructure.Models;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;

public class MedicalContext : DbContext
{
    public MedicalContext(DbContextOptions<MedicalContext> options) : base(options) { }

    public DbSet<CitasModel> Citas { get; set; }
    public DbSet<ConsultoriosModel> Departamento { get; set; }
    public DbSet<DoctoresModel> Doctor { get; set; }
    public DbSet<PacientesModel> Paciente { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


    }
}