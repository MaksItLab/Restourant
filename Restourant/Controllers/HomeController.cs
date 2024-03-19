using Microsoft.AspNetCore.Mvc;

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
