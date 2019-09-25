using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberlerComBOT
{
    public static class XPaths
    {
        public static readonly string TITLE = "//*[@id=\"content\"]/div[3]/ul/li/div/strong/a/font";
        public static readonly string DETAIL = "//*[@id=\"content\"]/div[3]/ul/li/p";
        public static readonly string IMAGE_URL = "//*[@id=\"content\"]/div[3]/ul/li/a/img";
    }
}
