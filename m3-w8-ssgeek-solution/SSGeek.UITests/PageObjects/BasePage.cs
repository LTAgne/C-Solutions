using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGeek.UITests.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public string Url { get; private set; }

        public BasePage(IWebDriver driver, string url)
        {
            this.driver = driver;
            this.Url = url;
        }

        public void Navigate()
        {
            string url = driver.Url; // get the current URL (full)
            Uri currentUri = new Uri(url); // create a Uri instance of it
            string baseUrl = currentUri.Authority; // just get the "base" bit of the URL
            driver.Navigate().GoToUrl(baseUrl + Url);
        }
    }
}
