using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class ScrapSelector
    {
        public string GetDirectUri(string url)
        {
            if (url.Contains("streamtape") || url.Contains("watchadsontape"))
            {
                return new Scrapping.Streamtape().GetDirectUri(url);
            }
            else
            {
                return "Not supported";
            }
        }
    }
}
