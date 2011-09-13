namespace Frende.SpecDemo.Web.Domain
{
	public class Calculator
	{
		public int GetPrice(string product)
		{
			if (product.ToLower().Equals("espresso"))
				return 10;

			return 20;
		}
	}
}