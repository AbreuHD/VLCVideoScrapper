﻿using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace App.Scrapping
{
    internal class Streamtape
    {
        internal string GetDirectUri(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var pageResult = web.Load(new Uri(url));
            var responseNode= pageResult.DocumentNode.SelectSingleNode("//*[@id=\"about-us\"]/script[1]").InnerText;
            var cutNode = responseNode.Split("'norobotlink').innerHTML = '")[1];
            var link = cutNode.Replace("' + ('xcd", "").Replace("').substring(1).substring(2);", "");
            return "https:"+ link;
        }
    }
}
