using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo
{
    [Binding]
    public class CheckBox
    {
        private IWebDriver driver;

        public CheckBox(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Then(@"Verify Check Box Display")]
        public void ThenVerifyCheckBoxDisplay()
        {
        }

        [When(@"Click on Check Box Option")]
        public void WhenClickOnCheckBoxOption()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the click on Toggle")]
        public void WhenTheClickOnToggle()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Click on Notes checkbox")]
        public void WhenClickOnNotesCheckbox()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify Notes Option selected")]
        public void ThenVerifyNotesOptionSelected()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"Verify Demo QA page title")]
        public void ThenVerifyDemoQAPageTitle()
        {
            Assert.AreEqual("DEMOQA", driver.Title);
        }
    }
}
