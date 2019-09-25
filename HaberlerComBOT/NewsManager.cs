using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace HaberlerComBOT
{
    public static class NewsManager
    {
        private static readonly Uri url = new Uri("https://www.haberler.com/gunun-mansetleri/");

        public static List<CuffNews> Cuffs
        {
            get
            {
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    return Parse.ParseCuff(client.DownloadString(url));
                }
            }
        }
    }
}
