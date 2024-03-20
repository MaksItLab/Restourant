using Microsoft.AspNetCore.Mvc;
using Restourant.DataAccess.Postgres;

namespace Restourant.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly RestourantDbContext _RestourantDB;

        public EmployeeController(RestourantDbContext restourantDbContext)
        {
                _RestourantDB = restourantDbContext;
        }

        public IActionResult Index()
        {
            var employees = _RestourantDB.Employees.ToList();
            var roles = _RestourantDB.Roles.ToList();
            
		    
			return View(employees);
        }

        // метод добавления сотрудника
        // метод удаления
        // метод изменения
    }
}
