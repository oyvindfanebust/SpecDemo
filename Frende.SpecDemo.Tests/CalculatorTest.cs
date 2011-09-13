using Should;
using Xunit;

namespace Frende.SpecDemo.Tests
{
	public class CalculatorTest
	{
		[Fact]
		public void cappucino_should_cost_20_kr()
		{
			var calculator = new Calculator();

			int price = calculator.GetPrice("cappucino");

			price.ShouldEqual(20);
		}

		[Fact]
		public void double_espresso_should_cost_20_kr()
		{
			var calculator = new Calculator();

			int price = calculator.GetPrice("dbl_espresso");

			price.ShouldEqual(20);
		}

		[Fact]
		public void single_espresso_should_cost_10_kr()
		{
			var calculator = new Calculator();

			int price = calculator.GetPrice("espresso");

			price.ShouldEqual(10);
		}
	}

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