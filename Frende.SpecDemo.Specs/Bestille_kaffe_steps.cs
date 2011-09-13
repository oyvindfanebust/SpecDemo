using NUnit.Framework;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs
{
	[Binding]
	public class Bestille_kaffe_steps
	{
		[Given("at jeg har valgt en dobbel espresso")]
		public void AtJegHarValgtEnDobbelEspresso()
		{
			Browser.GoTo("http://localhost:61604/Order");
			Browser.SelectList("products").SelectByValue("dbl_espresso");
		}

		[When(@"jeg bestiller")]
		public void NarJegBestiller()
		{
			Browser.Button("order").Click();
		}

		[Then(@"skal prisen være 20 kr")]
		public void SaSkalPrisenVaere20Kr()
		{
			Assert.That(Browser.Element("price").Text, Is.EqualTo("20 kr"));
		}

		private static Browser Browser
		{
			get { return FeatureContext.Current.Get<Browser>(); }
		}
	}
}
