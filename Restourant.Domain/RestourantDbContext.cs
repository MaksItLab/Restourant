using Microsoft.EntityFrameworkCore;
using Restourant.Domain.Enities;

namespace Restourant.Domain
{
	public class RestourantDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryDishes> CategoriesDishes { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Delivery> Deliverys { get; set; }
		public DbSet<Dishes> Dishes { get; set; }
		public DbSet<Employees> Employees { get; set; }
		public DbSet<Ingridients> Ingridients { get; set; }
		public DbSet<Invoices> Invoices { get; set; }
		public DbSet<ListOfOrders> ListOfOrders { get; set; }
		public DbSet<Loyalty> Loyalty { get; set; }
		public DbSet<Orders> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Providers> Providers { get; set; }
		public DbSet<RoleEmployees> RoleEmployees { get; set; }
		public DbSet<Storage> Storage { get; set; }
	}
}
