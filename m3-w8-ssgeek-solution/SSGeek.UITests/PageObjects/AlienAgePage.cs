using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SSGeek.UITests.PageObjects
{
    /* 
    * A Page Object encapsulates the page so that the unit tests
    * do not need to actually know the id's, class names, or element tags
    * on the page.
    */
    public class AlienAgePage : BasePage
    {           
        public AlienAgePage(IWebDriver driver)
            : base(driver, "/Calculators/AlienAge")
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Name, Using = "AlienPlanet")]
        public IWebElement AlienPlanet { get; set; }

        [FindsBy(How = How.Name, Using = "EarthAgeInYears")]
        public IWebElement EarthAgeInYears { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        public IWebElement CalculateButton { get; set; }
        
        public void ClearForm()
        {            
            EarthAgeInYears.Clear();
        }

        public AlienAgeResultPage FillOutForm(int earthAge, string planet)
        {
            SelectElement planetDropDown = new SelectElement(AlienPlanet);
            planetDropDown.SelectByText(planet);
            EarthAgeInYears.SendKeys(earthAge.ToString());

            CalculateButton.Click();

            return new AlienAgeResultPage(driver);
        }

        
                
    }
}
