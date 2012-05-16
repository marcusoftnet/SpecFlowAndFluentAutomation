using System;
using System.Configuration;
using FluentAutomation.API;
using FluentAutomation.API.Enumerations;

namespace Specs.Automation
{
    public class PageWrapperBase
    {
        private readonly Uri pageURL;

        public PageWrapperBase(string pagePath)
        {
            var rootUrl = new Uri(ConfigurationManager.AppSettings["baseUrl"]);
            pageURL = new Uri(rootUrl, pagePath);
        }

        public void Visit()
        {
            Browser.Open(pageURL);
        }

        private static BrowserAutomation _instance;
        public static CommandManager Browser
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BrowserAutomation();
                    _instance.I.Use(BrowserType.Firefox);
                }
                return _instance.I;
            }
        }
    }
}