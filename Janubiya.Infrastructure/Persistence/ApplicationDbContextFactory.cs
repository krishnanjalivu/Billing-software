// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.Extensions.Configuration;
// using System.IO;

// namespace Janubiya.Infrastructure.Persistence
// {
//     public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
//     {
//         public ApplicationDbContext CreateDbContext(string[] args)
//         {
//             // Build config
//             var configuration = new ConfigurationBuilder()
//                 .SetBasePath(Directory.GetCurrentDirectory())
//                 .AddJsonFile("appsettings.json")
//                 .Build();

//             var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
//             optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

//             return new ApplicationDbContext(optionsBuilder.Options);
//         }
//     }
// }
