using Restourant.DataAccess.Postgres.Models;

namespace Restourant.Services.Interfaces
{
    public interface IRestourantData
    {
        IEnumerable<Employee> GetEmployees();
		Task<IEnumerable<CategoryDish>> GetCategoryDishes();
        IEnumerable<CategoryProduct> GetProducts();
        IEnumerable<Check> GetChecks();
        IEnumerable<Client> GetClients();
        IEnumerable<Delivery> GetDeliverys();
        IEnumerable<Dish> GetDishes();
        IEnumerable<Ingridient> GetIngridients();
        IEnumerable<Invoice> GetInvoices();
        IEnumerable<Order> GetOrders();
        IEnumerable<Provider> GetProviders();
        IEnumerable<RoleEmployee> GetRoleEmployees();
        IEnumerable<Storage> GetStorages();



    }
}
