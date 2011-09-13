using Frende.SpecDemo.Web.Domain;
using Should;
using Xunit.Extensions;

namespace Frende.SpecDemo.Tests
{
	public class CalculatorTest
	{
		[Theory]
		[InlineData("cappucino", 20)]
		[InlineData("dbl_espresso", 20)]
		[InlineData("espresso", 10)]
		public void product_should_cost(string product, int expectedPrice)
		{
			var calculator = new Calculator();

			int price = calculator.GetPrice(product);

			price.ShouldEqual(expectedPrice);
		}
	}
}