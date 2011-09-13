using WatiN.Core;

namespace Frende.SpecDemo.Specs.Pages
{
	[Page(UrlRegex = "/Order")]
	public class OrderPage : Page
	{
		public void SelectProduct(string product)
		{
			Document.CheckBox(Find.ByLabelText(product)).Click();
		}

		public void Order()
		{
			Document.Button("order").Click();
		}
	}
}