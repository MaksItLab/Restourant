using Microsoft.EntityFrameworkCore;
using Restourant.DataAccess.Postgres.Configurations;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres
{
    public class RestourantDbContext : DbContext
    {
        public RestourantDbContext(DbContextOptions<RestourantDbContext> options)
            : base(options) { }

        /// <summary>
        /// Сотрудники
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Роли сотрудников
        /// </summary>
        public DbSet<RoleEmployee> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEmployeesConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
