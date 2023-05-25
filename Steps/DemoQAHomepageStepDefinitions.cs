using NUnit.Framework;
using OpenQA.Selenium;
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

        public DemoQAHomepageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
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
            Assert.AreEqual("DEMOQA", driver.Title);
        }
    }
}
