using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CustomLayouts.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CustomLayoutsMigrationsDbContextFactory : IDesignTimeDbContextFactory<CustomLayoutsMigrationsDbContext>
    {
        public CustomLayoutsMigrationsDbContext CreateDbContext(string[] args)
        {
            CustomLayoutsEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CustomLayoutsMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CustomLayoutsMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CustomLayouts.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
