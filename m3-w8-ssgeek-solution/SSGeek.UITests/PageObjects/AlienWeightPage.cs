using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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
    public class AlienWeightPage : BasePage
    {
        public AlienWeightPage(IWebDriver driver)
            : base(driver, "/Calculators/AlienWeight")
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "AlienPlanet")]
        public IWebElement AlienPlanet { get; set; }

        [FindsBy(How = How.Id, Using = "EarthWeight")]
        public IWebElement EarthWeight { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        public IWebElement CalculateButton { get; set; }

        public void ClearForm()
        {
            EarthWeight.Clear();
        }

        public AlienWeightResultPage FillOutForm(string planet, int earthWeight)
        {
            SelectElement planetDropDown = new SelectElement(AlienPlanet);
            planetDropDown.SelectByText(planet);
            EarthWeight.SendKeys(earthWeight.ToString());

            CalculateButton.Click();

            return new AlienWeightResultPage(driver);
        }
    }
}
