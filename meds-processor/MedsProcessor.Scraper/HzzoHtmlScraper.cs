using  AngleSharp;

namespace MedsProcessor.MedsProcessor.Scraper
{
public class HzzoHtmlScraper{

readonly IBrowsingContext _browsingContext;
public HzzoHtmlScraper(IBrowsingContext browsingContext)
		{
			this._browsingContext = browsingContext;
		}

}
}