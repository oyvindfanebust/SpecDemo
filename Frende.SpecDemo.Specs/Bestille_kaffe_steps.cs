using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs
{
	[Binding]
	public class Bestille_kaffe_steps
	{
		[Given(@"at jeg er på ordresiden")]
		public void GittAtJegErPaOrdresiden()
		{
			Browser.GoTo("http://localhost:61604/Order");			
		}

		[Given("at jeg har valgt en (.*)")]
		public void AtJegHarValgtEnDobbelEspresso(string product)
		{
			Browser.CheckBox(Find.ByLabelText(product)).Click();
		}

		[When(@"jeg bestiller")]
		public void NarJegBestiller()
		{
			Browser.Button("order").Click();
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
