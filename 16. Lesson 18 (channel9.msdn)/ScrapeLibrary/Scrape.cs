using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url)+"That's all folks!";
        }
        public string ScrapeWebpage(string url, string filePath)
        {
            string replay = GetWebpage(url);

            File.WriteAllText(filePath, replay);
            return replay;
        }
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
