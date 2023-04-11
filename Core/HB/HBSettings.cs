namespace HtmlParser.Core.HB
{
    public class HBSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://habr.com";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
