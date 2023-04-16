using Microsoft.EntityFrameworkCore;
using MyPortfolio.Core.Models;
using Microsoft.EntityFrameworkCore.Design;
using MyPortfolio.DataAccess.Configurations;
using Microsoft.Extensions.Options;
using MyPortfolio.Core.Entities;

namespace MyPortfolio.DataAccess.DataAccess
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Postgres config
            builder.UseSerialColumns();
            builder.HasPostgresExtension("uuid-ossp").UseIdentityColumns();

            builder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(builder);

            // Initialization
            Initializer initializer = new Initializer();
            builder.Entity<User>().HasData(initializer.Users);
            builder.Entity<JobPosition>().HasData(initializer.JobPositions);
            builder.Entity<Company>().HasData(initializer.Companies);

        }
        public static void Main() { }
    }
}