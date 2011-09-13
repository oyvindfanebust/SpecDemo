using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs.Support
{
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