using EntityFrameworkProject.Configuration;
using EntityFrameworkProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    internal class EventsContext : DbContext
    {

        public DbSet<Event> Events { get; set; }
        public DbSet<Performer> Performers { get; set; }

        public EventsContext() : base() { }
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=EventDb2;Trusted_Connection=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new PerformerConfiguration());
        }

    }
}
