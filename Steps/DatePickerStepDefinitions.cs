using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class DatePickerStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private DatePickerPage datePickerPage;

        public DatePickerStepDefinitions(IWebDriver driver) : base(driver)
        {
            datePickerPage = new DatePickerPage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Date Picker Display")]
        public void ThenVerifyDatePickerDisplay()
        {
            datePickerPage.VerifyDatePickerDisplay();
        }

        [When(@"Click on Date Picker")]
        public void WhenClickOnDatePicker()
        {
            datePickerPage.ClickOnDatePicker();
        }

        [When(@"Update The Date")]
        public void WhenUpdateTheDate()
        {
            datePickerPage.UpdateTheDate();
        }

        [When(@"Update Date And Time")]
        public void WhenUpdateDateAndTime()
        {
            datePickerPage.UpdateTheDateAndTime();
        }

        
    }
}
