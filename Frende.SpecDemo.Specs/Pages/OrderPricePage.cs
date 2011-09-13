using WatiN.Core;

namespace Frende.SpecDemo.Specs.Pages
{
	[Page(UrlRegex = "/Order/Price")]
	public class OrderPricePage : Page
	{
		public string GetPrice()
		{
			return Document.Element("price").Text;
		}
	}
}