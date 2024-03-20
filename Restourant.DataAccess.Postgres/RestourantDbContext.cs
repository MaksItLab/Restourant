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
        /// <summary>
        /// Категории блюд
        /// </summary>
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        /// <summary>
        /// Доставки
        /// </summary>
        public DbSet<Delivery> Deliveries { get; set; }
        /// <summary>
        /// Продукты
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Поставщики
        /// </summary>
        public DbSet<Provider> Providers { get; set; }
        /// <summary>
        /// Склады
        /// </summary>
        public DbSet<Storage> Storages { get; set; }
        /// <summary>
        /// Накладные
        /// </summary>
        public DbSet<Invoice> Invoices { get; set; }
        
        



		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryDishConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryProductConfiguration());
            modelBuilder.ApplyConfiguration(new CheckConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryConfiguration());
            modelBuilder.ApplyConfiguration(new DishConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new IngridientConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEmployeesConfiguration());
            modelBuilder.ApplyConfiguration(new StorageConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
