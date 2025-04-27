using Janubiya.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Janubiya.Infrastructure.Persistence
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}