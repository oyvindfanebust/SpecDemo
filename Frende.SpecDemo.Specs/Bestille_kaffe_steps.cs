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
			FeatureContext.Current.Get<Browser>().SelectList("product").Select("dbl_espresso");
		}
	}

	[Binding]
	public static class WatinSupport
	{
		[BeforeFeature]
		public static void BeforeWebFeature()
		{
			FeatureContext.Current.Set<Browser>(new IE());
		}

		[AfterFeature]
		public static void AfterWebFeature()
		{
			FeatureContext.Current.Get<Browser>().Dispose();
		}
	}
}
