using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class AutoCompleteStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private AutoCompletePage autoComplete;

        public AutoCompleteStepDefinitions(IWebDriver driver) : base(driver)
        {
            autoComplete = new AutoCompletePage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Widgets Option Display")]
        public void ThenVerifyWidgetsOptionDisplay()
        {
            autoComplete.VerifyWidgetDisplay();
        }

        [When(@"Click on Widgets Option")]
        public void WhenClickOnWidgetsOption()
        {
            autoComplete.ClickOnWidget();
        }

        [Then(@"Verify Auto Complete Display")]
        public void ThenVerifyAutoCompleteDisplay()
        {
            autoComplete.VerifyAutoComplete();
        }

        [When(@"Click on Auto Complete")]
        public void WhenClickOnAutoComplete()
        {
            autoComplete.ClickOnAutoComplete();
        }

        [When(@"Enter Type multiple color names")]
        public void WhenEnterTypeMultipleColorNames()
        {
            autoComplete.EnterMultipleColorNames();
        }

        //[When(@"Enter Type single color name")]
        //public void WhenEnterTypeSingleColorName()
        //{
        //    throw new PendingStepException();
        //}
    }
}
