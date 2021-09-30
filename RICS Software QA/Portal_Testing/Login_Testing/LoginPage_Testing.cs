using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace RICS_Software_QA
{
    public class LoginPage_Testing
    {
        //Local Chrome Web Driver (This solution contains the correct NuGet package for Chrome WebDriver, so this isn't needed)
        public IWebDriver webDriver = new ChromeDriver(@"C:\SeleniumTesting\Drivers\chromedriver_win32");  

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl("https://portalqa.rics.io/#/login");
        }

        [Test]
        public void NavigateToPortal_PortalLoginPageLoads() 
        {

            //Enter Username and Password
            var userNameField = webDriver.FindElement(By.Name("username"));

            //Assertion
            Assert.That(userNameField.Displayed, Is.True);
        }

        [Test]
        public void LoginToPortal_ShouldLogUserIntoPortalDashboard()
        {
            
            webDriver.FindElement(By.Name("username")).SendKeys("isaac@qa.com"); //Broken --- Says that the element is not interactable
            webDriver.FindElement(By.Name("password")).SendKeys("Guest12345!"); //Broken --- Says that the element is not interactable
            webDriver.FindElement(By.Id("loginButton")).Click();  //Working
            var allActiveLocations = webDriver.FindElement(By.Id("usersGrid")); //Working

            Assert.That(allActiveLocations.Displayed, Is.True);

        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}