using Frende.SpecDemo.Specs.Pages;
using Frende.SpecDemo.Specs.Support;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs.Steps
{
	[Binding]
	public class Bestille_kaffe_steps
	{
		[Given(@"at jeg er på ordresiden")]
		public void GittAtJegErPaOrdresiden()
		{
			OrderPage.GoTo();
		}

		[Given("at jeg har valgt en (.*)")]
		public void AtJegHarValgtEnDobbelEspresso(string product)
		{
			OrderPage.SelectProduct(product);
		}

		[When(@"jeg bestiller")]
		public void NarJegBestiller()
		{
			OrderPage.Order();
		}

		[Then(@"skal prisen være ([0-9]+) kr")]
		public void SaSkalPrisenVaere20Kr(int price)
		{
			var actualPrice = OrderPricePage.GetPrice();
			Assert.That(actualPrice, Is.EqualTo(price + " kr"));
		}

		private static OrderPricePage OrderPricePage
		{
			get { return Browser.Page<OrderPricePage>(); }
		}

		private static OrderPage OrderPage
		{
			get { return Browser.Page<OrderPage>(); }
		}

		private static Browser Browser
		{
			get { return FeatureContext.Current.Get<Browser>(); }
		}
	}
}
