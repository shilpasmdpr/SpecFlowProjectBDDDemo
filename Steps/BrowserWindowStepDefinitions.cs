using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]

    public class BrowserWindowStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private BrowserWindow browserWindow;

        public BrowserWindowStepDefinitions(IWebDriver driver) : base(driver)
        {
            browserWindow = new BrowserWindow(driver);
            this.driver = driver;
        }
        [Then(@"Verify Allert Frame Window Option Display")]
        public void ThenVerifyAllertFrameWindowOptionDisplay()
        {
            browserWindow.VerifyAllertFrameWindowOptionDisplay();
        }

        [When(@"Click on Allert Frame Window Option")]
        public void WhenClickOnAllertFrameWindowOption()
        {
            browserWindow.ClickOnAllertFrameWindowOption();
        }

        [Then(@"Verify Browser Windows Display")]
        public void ThenVerifyBrowserWindowsDisplay()
        {
            browserWindow.VerifyBrowserWindowsDisplay();
        }

        [When(@"Click on Browser Windows")]
        public void WhenClickOnBrowserWindows()
        {
            browserWindow.ClickOnBrowserWindowsOption();
        }

        [When(@"Click On New Tab")]
        public void WhenClickOnNewTab()
        {
            browserWindow.ClickOnNewTabButton();
        }

        [Then(@"Verify New Tab Content")]
        public void ThenVerifyNewTabContent()
        {
            browserWindow.VerifyNewTabContent();
        }

        [When(@"Click On New Window")]
        public void WhenClickOnNewWindow()
        {
            browserWindow.ClickOnNewWindow();
        }

        [Then(@"Verify New Window Content")]
        public void ThenVerifyNewWindowContent()
        {
            browserWindow.VerifyNewWindowContent();
        }

        [Then(@"Verify New Window Message")]
        public void ThenVerifyNewWindowMessage()
        {
            browserWindow.VerifyNewWindowContent();
        }
    }
}
