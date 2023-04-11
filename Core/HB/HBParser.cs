using AngleSharp.Html.Dom;

namespace HtmlParser.Core.HB
{
    public class HBParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var names = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("tm-title__link"));

            foreach(var item in items)
            {
                names.Add(item.TextContent);
            }

            return names.ToArray();
        }
    }
}
