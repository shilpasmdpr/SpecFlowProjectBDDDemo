using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]

    public class AlertsStepDefinitions
    {
        private IWebDriver driver;
        private AlertPage alertPage;
        public AlertsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            alertPage = new AlertPage(driver);
        }
        [Then(@"Verify Alert Menu Display")]
        public void ThenVerifyAlertMenuDisplay()
        {
            alertPage.VerifyAlertMenuDisplay();
            
        }
        [When(@"Click On Alert Tab")]
        public void WhenClickOnAlertTab()
        {
            alertPage.ClickOnAlert();
        }

        [When(@"Click on Click Button to see alert")]
        public void WhenClickOnClickButtonToSeeAlert()
        {
            alertPage.ClickOnClickButtontoseealert();
        }

        [Then(@"Verify Alert and Click On OK")]
        public void ThenVerifyAlertAndClickOnOK()
        {
            alertPage.ClickOnAlertOK();
        }

        [When(@"Click on On button click, alert will appear after seconds")]
        public void WhenClickOnOnButtonClickAlertWillAppearAfterSeconds()
        {
            alertPage.ClickOnTimerAlertButton();
        }

        [Then(@"Verify Appear Alert and Click On OK")]
        public void ThenVerifyAppearAlertAndClickOnOK()
        {
            alertPage.ClickOnAlertOK();
        }

        [When(@"Click On button click, confirm box will appear")]
        public void WhenClickOnButtonClickConfirmBoxWillAppear()
        {
            alertPage.ClickOnConfirmBoxWillAppeartton();
        }

        [Then(@"Verify Appear Alert and Click On Cancel")]
        public void ThenVerifyAppearAlertAndClickOnCancel()
        {
            alertPage.ClickOnAlertCancel();
        }

        [When(@"Click On button click, prompt box will appear")]
        public void WhenClickOnButtonClickPromptBoxWillAppear()
        {
            alertPage.ClickOnPromtButton();
        }

        [When(@"Enter text and Click On OK")]
        public void WhenEnterTextAndClickOnOK()
        {
            alertPage.EnterTextAndAccept();
        }
    }
}
