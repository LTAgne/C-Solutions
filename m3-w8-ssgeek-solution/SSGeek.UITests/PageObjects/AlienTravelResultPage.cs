using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGeek.UITests.PageObjects
{
    /* 
    * A Page Object encapsulates the page so that the unit tests
    * do not need to actually know the id's, class names, or element tags
    * on the page.
    */
    public class AlienTravelResultPage : BasePage
    {
        public AlienTravelResultPage(IWebDriver driver)
            : base(driver, "/Calculators/AlienTravelResult")
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#calculatorResult img")]
        public IWebElement PlanetImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#calculatorResult h2")]
        public IWebElement ResultText { get; set; }

    }
}
