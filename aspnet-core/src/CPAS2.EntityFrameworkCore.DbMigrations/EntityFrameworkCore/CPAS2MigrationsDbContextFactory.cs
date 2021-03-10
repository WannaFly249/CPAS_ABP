using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CPAS2.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CPAS2MigrationsDbContextFactory : IDesignTimeDbContextFactory<CPAS2MigrationsDbContext>
    {
        public CPAS2MigrationsDbContext CreateDbContext(string[] args)
        {
            CPAS2EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CPAS2MigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CPAS2MigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CPAS2.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
