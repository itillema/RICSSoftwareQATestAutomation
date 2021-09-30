using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RICS_Software_QA
{
    public class Location_LocationDetails_Testing
    {
        //Local Chrome Web Driver (This solution contains the correct NuGet package for Chrome WebDriver, so this isn't needed)
        public IWebDriver webDriver = new ChromeDriver(@"C:\SeleniumTesting\Drivers\chromedriver_win32");

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl("https://portalqa.rics.io/#/login");
            //Enter Username and Password
            webDriver.FindElement(By.Name("username")).SendKeys("isaac@qa.com");  //Broken
            webDriver.FindElement(By.Name("password")).SendKeys("Guest12345!");   //Broken
            webDriver.FindElement(By.Id("loginButton")).Click();
        }

        [Test]
        public void ViewLocationDetails_ShouldNavigateToLocationDetailsPage()
        {
            webDriver.FindElement(By.LinkText("Alec's Shoes")).Click(); // Find correct element for Alec's Shoes location
            webDriver.FindElement(By.LinkText("Location Details")).Click(); // Find correct element for Location Details

            var locationDetailsPage = webDriver.FindElement(By.Id("Details"));

            Assert.That(locationDetailsPage.Displayed, Is.True);

        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}