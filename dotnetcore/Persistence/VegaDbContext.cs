using dotnetcore.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        :base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
    }
}