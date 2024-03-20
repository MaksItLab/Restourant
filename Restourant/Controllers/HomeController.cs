using Microsoft.AspNetCore.Mvc;
using Restourant.DataAccess.Postgres;
using Restourant.Services.Interfaces;

namespace Restourant.Controllers
{
	public class HomeController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}
	}
}
