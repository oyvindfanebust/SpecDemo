using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs
{
	[Binding]
	public class Bestille_kaffe_steps
	{
		[Given("at jeg har valgt en dobbel espresso")]
		public void GivenIHaveEnteredSomethingIntoTheCalculator()
		{
			FeatureContext.Current.Get<Browser>().GoTo("http://localhost:61604/Order");
			FeatureContext.Current.Get<Browser>().SelectList("products").SelectByValue("dbl_espresso");
		}
	}
}
