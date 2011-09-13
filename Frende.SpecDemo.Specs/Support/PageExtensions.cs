using TechTalk.SpecFlow;
using WatiN.Core;

namespace Frende.SpecDemo.Specs.Support
{
	public static class PageExtensions
	{
		public static T GoTo<T>(this T page) where T : Page, new()
		{
			const string baseUrl = "http://localhost:61604";
			var url = page.Metadata.UrlRegex.ToString();
			FeatureContext.Current.Get<Browser>().GoTo(baseUrl + "/" + url);

			return page;
		}
	}
}