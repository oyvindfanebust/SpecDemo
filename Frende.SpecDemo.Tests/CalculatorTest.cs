using Frende.SpecDemo.Web.Domain;
using Should;
using Xunit;
using Xunit.Extensions;

namespace Frende.SpecDemo.Tests
{
	public class CalculatorTest
	{
		[Theory]
		[InlineData(new[] { "cappucino" }, 20)]
		[InlineData(new[] { "dbl_espresso" }, 20)]
		[InlineData(new[] { "espresso" }, 10)]
		[InlineData(new[] { "cappucino", "dbl_espresso" }, 40)]
		[InlineData(new[] { "cappucino", "espresso" }, 30)]
		public void multiple_products_should_cost(string[] products, int expectedPrice)
		{
			var calculator = new Calculator();

			int price = calculator.GetPrice(products);

			price.ShouldEqual(expectedPrice);
		}
	}
}