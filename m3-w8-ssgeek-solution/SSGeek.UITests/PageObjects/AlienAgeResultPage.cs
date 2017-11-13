using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSGeek.UITests.PageObjects
{
    public class AlienAgeResultPage : BasePage
    {       
        public AlienAgeResultPage(IWebDriver driver)
            : base(driver, "/Calculators/AlienAgeResult")
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
