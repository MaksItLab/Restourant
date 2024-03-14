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
        /// <summary>
        /// Заказы
        /// </summary>
        public DbSet<Order> Orders {  get; set; }

        /// <summary>
        /// Клиенты
        /// </summary>
        public DbSet<Client> Clients { get; set; }
        /// <summary>
        /// Чеки
        /// </summary>
        public DbSet<Check> Checks { get; set; }
        /// <summary>
        /// Ингридиенты
        /// </summary>
        public DbSet<Ingridient> Ingridients { get; set; }
        /// <summary>
        /// Блюда
        /// </summary>
        public DbSet<Dish> Dishes {  get; set; }
        /// <summary>
        /// Категории блюд
        /// </summary>
        public DbSet<CategoryDish> CategoryDishes { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEmployeesConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new CheckConfiguration());
            modelBuilder.ApplyConfiguration(new IngridientConfiguration());
            modelBuilder.ApplyConfiguration(new DishConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryDishConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
