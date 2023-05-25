using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectBDDDemo.Pages;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginpage;
        private HomePage homePage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new ChromeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.facebook.com/login/";
            Thread.Sleep(2000);
            //https://demoqa.com/
        }

        //Data Driven Test
        [Given(@"Launch the URL")]
        public void GivenLaunchTheURL()
        {
            driver.Url = "https://www.facebook.com/login/";
            Thread.Sleep(2000);
        }
        

        [When(@"Enter the (.*) and (.*)")]
        public void WhenEnterTheAnd(string un, string pwd)
        {
            loginpage = new LoginPage(driver);
            loginpage.EnterCredentialsAndClick(un, pwd);
            Thread.Sleep(2000);
        }
        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            loginpage.ClickOnLoginButton();
            Thread.Sleep(2000);
        }
        [Then(@"Verify the page title")]
        public void ThenVerifyThePageTitle()
        {
            homePage = new HomePage(driver);
            Assert.AreEqual("Log in to Facebook", driver.Title);

        }


    }
}
