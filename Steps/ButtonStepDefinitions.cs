using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class ButtonStepDefinitions
    {
        private IWebDriver driver;
        private ButtonPage buttonPage;
        public ButtonStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            buttonPage = new ButtonPage(driver);
        }
        [Then(@"Verify Button Element Display")]
        public void ThenVerifyButtonElementDisplay()
        {
            buttonPage.verifyElementDisplay();
        }

        [When(@"Click on Button Element")]
        public void WhenClickOnButtonElement()
        {
            buttonPage.ClickOnElementOption();
        }

        [Then(@"Verify Button Page Heading")]
        public void ThenVerifyButtonPageHeading()
        {
            buttonPage.AssertButtonPageHeading();
        }

        [When(@"Double Click on Double Click Me Button")]
        public void WhenDoubleClickOnDoubleClickMeButton()
        {
            buttonPage.DoubleClickOnDoubleClickMebutton();
        }

        [Then(@"Verify Double Click Me message")]
        public void ThenVerifyDoubleClickMeMessage()
        {
            buttonPage.VerifyDoubleClickMsgDisplay();
        }

        [Then(@"Verify Right Click Me  message")]
        public void ThenVerifyRightClickMeMessage()
        {
            buttonPage.VerifyRightClickMsgDisplay();
        }

        [Then(@"Verify Click Me message")]
        public void ThenVerifyClickMeMessage()
        {
            buttonPage.VerifyClickMsgDisplay();
        }

        [When(@"Right Click on Right Click Me Button")]
        public void WhenRightClickOnRightClickMeButton()
        {
            buttonPage.RightClickOnDoubleClickMebutton();
        }

        [When(@"Click on Click Me Button")]
        public void WhenClickOnClickMeButton()
        {
            buttonPage.ClickOnClickMebutton();
        }
    }
}
