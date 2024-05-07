using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using System.Diagnostics;

namespace MVC_Demo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
			// Mỗi 1 IActionResult có thể return 1 view
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult AboutUs()
		{
			return View();
		}

		public IActionResult GoToHome()
		{
			// Hành động gì đó trc khi về trang chủ
			// Redirect - điều hướng về action để về trang chủ 
			return RedirectToAction("Index");

		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}