using HealthCite.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HealthCiteDb.Infrastructure
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<HealthCiteDbContext>
    {
        public HealthCiteDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HealthCiteDbContext>();

            try
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("SqlMainConnection");
                optionsBuilder.UseSqlServer(connectionString);

                return new HealthCiteDbContext(optionsBuilder.Options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating DbContext: {ex.Message}");
                throw;
            }
        }
    }
}
