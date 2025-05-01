using Janubiya.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Janubiya.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // Define your DbSet properties here
        public DbSet<User> Users { get; set; }
        // Add more DbSets for other models
    }

}