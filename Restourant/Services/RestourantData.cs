//using Microsoft.EntityFrameworkCore;
//using Restourant.DataAccess.Postgres;
//using Restourant.DataAccess.Postgres.Models;
//using Restourant.Services.Interfaces;

//namespace Restourant.Services
//{
//	public class RestourantData : IRestourantData
//	{

//		private readonly RestourantDbContext _DB;
//		private readonly ILogger<RestourantData> _Logger;

//		public RestourantData(RestourantDbContext db, ILogger<RestourantData> Logger)
//		{
//			_DB = db;
//			_Logger = Logger;

//		}
//		public async Task<IEnumerable<CategoryDish>> GetCategoryDishes()
//		{
//			var arr = await _DB.CategoryDishes
//				.Select(x => new
//				{
//					x.Id,
//					x.Name,
//				}).ToListAsync();
//			return (IEnumerable<CategoryDish>)arr;
//		}

//		public IEnumerable<Check> GetChecks()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Client> GetClients()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Delivery> GetDeliverys()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Dish> GetDishes()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Employee> GetEmployees()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Ingridient> GetIngridients()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Invoice> GetInvoices()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Order> GetOrders()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<CategoryProduct> GetProducts()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Provider> GetProviders()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<RoleEmployee> GetRoleEmployees()
//		{
//			throw new NotImplementedException();
//		}

//		public IEnumerable<Storage> GetStorages()
//		{
//			throw new NotImplementedException();
//		}
//	}
//}
