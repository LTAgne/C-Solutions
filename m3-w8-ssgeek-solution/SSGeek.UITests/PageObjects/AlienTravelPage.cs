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
    public class AlienTravelPage : BasePage
    {        
        public AlienTravelPage(IWebDriver driver) : 
            base(driver, "/Calculators/AlienTravel")
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "AlienPlanet")]
        public IWebElement AlienPlanet { get; set; }

        [FindsBy(How = How.Id, Using = "ModeOfTransport")]
        public IWebElement ModeOfTransport { get; set; }

        [FindsBy(How = How.Id, Using = "EarthAgeInYears")]
        public IWebElement EarthAgeInYears { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        public IWebElement CalculateButton { get; set; }

        public void ClearForm()
        {
            EarthAgeInYears.Clear();
        }

        public AlienTravelResultPage FillOutForm(int earthAge, string planet, string modeOfTransport)
        {
            SelectElement planetDropDown = new SelectElement(AlienPlanet);
            SelectElement modeOfTransportDropDown = new SelectElement(ModeOfTransport);

            modeOfTransportDropDown.SelectByText(modeOfTransport);
            planetDropDown.SelectByText(planet);
            EarthAgeInYears.SendKeys(earthAge.ToString());
            
            CalculateButton.Click();

            return new AlienTravelResultPage(driver);
        }


    }
}
