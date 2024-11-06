using Microsoft.EntityFrameworkCore;
using PotatoApi.Entities;

namespace PotatoApi.Database
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Potato> Potatoes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
