using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SpecFlowProjectBDDDemo.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo
{
    [Binding]
    public class DemoQAHomepageStepDefinitions
    {
        private IWebDriver driver;
       private HomePage homePage;
        public DemoQAHomepageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            homePage = new HomePage(driver);
        }
        [Given(@"Launch Demo QA URL")]
        public void GivenLaunchDemoQAURL()
        {
            driver.Url = "https://demoqa.com/";
            Thread.Sleep(4000);
        }

        [Then(@"Verify Demo QA page title")]
        public void ThenVerifyDemoQAPageTitle()

        {
            Assert.AreEqual("DEMOQA", homePage.verifyPageTitle());
        }
    }
}
