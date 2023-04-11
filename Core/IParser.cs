using AngleSharp.Html.Dom;

namespace HtmlParser.Core
{
    public interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
