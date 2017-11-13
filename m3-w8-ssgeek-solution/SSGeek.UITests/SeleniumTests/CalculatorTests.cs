using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.UITests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSGeek.UITests.SeleniumTests
{
    [TestClass]
    public class AlienAgeTests
    {
        private static IWebDriver driver;
        
        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:64626/");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void SubmitAlienWeight_WithValidData_GoToResultPage()
        {
            AlienWeightPage alienPage = new AlienWeightPage(driver);
            alienPage.Navigate();

            alienPage.ClearForm();
            AlienWeightResultPage resultPage = alienPage.FillOutForm("Mars", 100);

            Assert.AreEqual("If you are 100 lbs on planet Earth, you would weigh 38 lbs on Mars.", resultPage.ResultText.Text);
        }

        [TestMethod]
        public void SubmitAlienAge_WithValidData_GoToResultPage()
        {
            AlienAgePage alienPage = new AlienAgePage(driver);
            alienPage.Navigate();

            alienPage.ClearForm();
            AlienAgeResultPage resultPage = alienPage.FillOutForm(10, "Mars");

            Assert.AreEqual("If you are 10 years old on planet Earth, then you are 18.81 Mars years old.", resultPage.ResultText.Text);
        }

        [TestMethod]
        public void SubmitAlienTravel_WithValidData_GoToResultPage()
        {
            AlienTravelPage alienPage = new AlienTravelPage(driver);
            alienPage.Navigate();

            alienPage.ClearForm();
            AlienTravelResultPage resultPage = alienPage.FillOutForm(18, "Mars", "Boeing 747");

            Assert.AreEqual("Traveling by boeing 747 you will reach Mars in 9.75 years. You will be 27.75 years old.", resultPage.ResultText.Text);
        }
    }
}
