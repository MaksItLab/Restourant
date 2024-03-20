using Microsoft.AspNetCore.Mvc;
using Restourant.DataAccess.Postgres;

namespace Restourant.Controllers
{
	public class CategoryDishiesController : Controller
	{
		private readonly RestourantDbContext _RestourantData;


		public CategoryDishiesController(RestourantDbContext RestourantData)
		{
			_RestourantData = RestourantData;
		}
		public IActionResult Index()
		{
			var res = _RestourantData.CategoryDishes.ToList();
			return View(res);
		}
	}
}
