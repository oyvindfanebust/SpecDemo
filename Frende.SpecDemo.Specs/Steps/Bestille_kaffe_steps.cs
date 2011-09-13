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
		private static OrderPage OrderPage
		{
			get { return Browser.Page<OrderPage>(); }
		}

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
			Assert.That(Browser.Element("price").Text, Is.EqualTo(price + " kr"));
		}

		private static Browser Browser
		{
			get { return FeatureContext.Current.Get<Browser>(); }
		}
	}
}
