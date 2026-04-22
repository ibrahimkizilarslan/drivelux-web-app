using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Context
{
    public class DriveLuxContextFactory : IDesignTimeDbContextFactory<DriveLuxContext>
    {
        public DriveLuxContext CreateDbContext(string[] args)
        {

            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..\\DriveLux.WebAPI"));
            // appsettings.json dosyasını oku
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Connection string'i al
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // DbContextOptions oluştur
            var optionsBuilder = new DbContextOptionsBuilder<DriveLuxContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DriveLuxContext(optionsBuilder.Options);
        }
    }
}
