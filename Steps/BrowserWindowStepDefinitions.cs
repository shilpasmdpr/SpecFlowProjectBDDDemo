using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]

    public class BrowserWindowStepDefinitions
    {
        private IWebDriver driver;
        BrowserWindow? browserWindow;
        public BrowserWindowStepDefinitions(IWebDriver driver)
        {
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
            throw new PendingStepException();
        }

        [Then(@"Verify New Window Message")]
        public void ThenVerifyNewWindowMessage()
        {
            throw new PendingStepException();
        }
    }
}
