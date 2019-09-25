using HtmlAgilityPack;
using System.Collections.Generic;

namespace HaberlerComBOT
{
    public static class Parse
    {
        private static readonly HtmlDocument doc = new HtmlDocument();

        public static List<CuffNews> ParseCuff(string html)
        {
            doc.LoadHtml(html);
            var titles = doc.DocumentNode.SelectNodes(XPaths.TITLE);
            var details = doc.DocumentNode.SelectNodes(XPaths.DETAIL);
            var images = doc.DocumentNode.SelectNodes(XPaths.IMAGE_URL);
            var cuffs = new List<CuffNews>();
            for (int i = 0; i < titles.Count; i++)
            {
                cuffs.Add(new CuffNews
                {
                    Title = titles[i].InnerText.Trim(),
                    Detail = details[i].InnerText.Trim(),
                    ImageUrl = images[i].Attributes["src"].Value
                });
            }
            return cuffs;
        }

    }
}
