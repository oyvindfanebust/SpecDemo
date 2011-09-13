using System.Linq;

namespace Frende.SpecDemo.Web.Domain
{
	public class Calculator
	{
		public int GetPrice(string[] products)
		{
			return products.Sum(product => GetPrice(product));
		}

		private int GetPrice(string product)
		{
			if (product.ToLower().Equals("espresso"))
				return 10;

			return 20;
		}
	}
}