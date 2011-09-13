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
		public ActionResult Price(ProductModel product)
		{
			var calculator = new Calculator();
			var price = calculator.GetPrice(product.ProductName);
			ViewBag.Price = price; 
			return View();
		}
	}

	public class ProductModel
	{
		public string ProductName { get; set; }
	}
}
