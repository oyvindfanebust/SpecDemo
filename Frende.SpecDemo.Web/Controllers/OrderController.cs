using System.Web.Mvc;
using Frende.SpecDemo.Web.Domain;

namespace Frende.SpecDemo.Web.Controllers
{
	public class OrderController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Price(string[] products)
		{
			var calculator = new Calculator();
			var price = calculator.GetPrice(products);
			ViewBag.Price = price;
			return View();
		}
	}
}
