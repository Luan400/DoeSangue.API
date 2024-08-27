using DoeSangue.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;

namespace DoeSangue.Infrastructure.Persistence
{
    public class DoeSangueDbContext : DbContext
    {
        public DoeSangueDbContext(DbContextOptions<DoeSangueDbContext> options) : base(options)
        {
        }

        public DbSet<BloodStock> BloodStock { get; set; }
        public DbSet<Donation> Donation { get; set; }
        public DbSet<Donor> Donor { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
