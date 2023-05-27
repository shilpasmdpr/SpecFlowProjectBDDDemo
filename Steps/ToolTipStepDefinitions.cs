using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class ToolTipStepDefinitions
    {
        private IWebDriver driver;
        private ToolTipPage toolTipPage;

        public ToolTipStepDefinitions(IWebDriver driver)
        {
            toolTipPage = new ToolTipPage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Tool Tip Option Display")]
        public void ThenVerifyToolTipOptionDisplay()
        {
            toolTipPage.VerifyToolTipsOptDisplay();
        }
        [When(@"Mouse hover and Capture the value")]
        public void WhenMouseHoverAndCaptureTheValue()
        {
            toolTipPage.MouseHoverAndFetchData();
        }
        [When(@"Mouse hover on text box and capture the value")]
        public void WhenMouseHoverOnTextBoxAndCaptureTheValue()
        {
            toolTipPage.MouseHoverOnTextBoxAndFetchData();
        }
        [When(@"Click On Tool Tip Option")]
        public void WhenClickOnToolTipOption()
        {
            toolTipPage.ClickOnToolTipsOpt();
        }

        [When(@"Mouse hover on contrary and capture the value")]
        public void WhenMouseHoverOnContraryAndCaptureTheValue()
        {
            toolTipPage.MouseHoverOnContraryAndFetchData();
        }

        [When(@"Mouse hover on number and capture the value")]
        public void WhenMouseHoverOnNumberAndCaptureTheValue()
        {
            toolTipPage.MouseHoverOnNumberAndFetchData();
        }

    }
}
