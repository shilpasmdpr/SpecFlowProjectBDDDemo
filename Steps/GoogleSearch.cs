using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public sealed class GoogleSearch
    {
        private IWebDriver driver;

        public GoogleSearch(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Launch the Google URL")]
        public void GivenLaunchTheGoogleURL()
        {
            driver.Url=("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the search key")]
        public void WhenEnterTheSearchKey(Table table)
        {
           var SearchContent =  table.CreateSet<SearchKey>();
            foreach(var keyword in SearchContent)
            {
                driver.FindElement(By.XPath("//*[@title='Search']")).Clear();
                driver.FindElement(By.XPath("//*[@title='Search']")).SendKeys(keyword.searchText);
                driver.FindElement(By.XPath("//*[@title='Search']")).SendKeys(Keys.Enter);
            }
        }

        [Then(@"Verify the result")]
        public void ThenVerifyTheResult()
        {
        }
        public class SearchKey
        {
            public string searchText { get; set; }
        }

    }
}
