using HealthCite.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCite.Infrastructure
{
    public class HealthCiteDbContext : DbContext
    {
        public HealthCiteDbContext(DbContextOptions<HealthCiteDbContext> options) : base(options) { }

        public DbSet<Citas> Citas { get; set; }
        public DbSet<Consultorios> Consultorios { get; set; }
        public DbSet<Doctores> Doctores { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<EstadoCitas> EstadosCitas { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<HistorialMedico> HistoriaMedico { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //}
    }
}
