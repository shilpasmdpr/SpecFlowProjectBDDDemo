using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class AlertPage : BasePage
    {
        private IWebDriver driver;

        public AlertPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By AlertMenu = By.XPath("//span[text()='Alerts']");
        By ClickButtonToSeeAlert = By.Id("alertButton");
        By TimerAlertButton = By.Id("timerAlertButton");
        By ConfirmButton = By.Id("confirmButton");
        By PromtButton = By.Id("promtButton");

        public AlertPage VerifyAlertMenuDisplay()
        {
            IsElementDisplayed(AlertMenu);
            return new AlertPage(driver);
        }
        public AlertPage ClickOnAlert()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement AlertMenuEle = driver.FindElement(AlertMenu);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", AlertMenuEle);
            Thread.Sleep(1000);
            ClickButtonByXPath(AlertMenu);
            return new AlertPage(driver);
        }
        public AlertPage ClickOnClickButtontoseealert()
        {
            ClickButtonByXPath(ClickButtonToSeeAlert);
            return new AlertPage(driver);
        }
        public AlertPage ClickOnAlertOK()
        {
            driver.SwitchTo().Alert().Accept();
            return new AlertPage(driver);
        }
        public AlertPage ClickOnTimerAlertButton()
        {
            ClickButtonByXPath(TimerAlertButton);
            Thread.Sleep(6000);
            return new AlertPage(driver);
        }
        public AlertPage ClickOnConfirmBoxWillAppeartton()
        {
            ClickButtonByXPath(ConfirmButton);
            Thread.Sleep(6000);
            return new AlertPage(driver);
        }
        public AlertPage ClickOnAlertCancel()
        {
            driver.SwitchTo().Alert().Dismiss();
            return new AlertPage(driver);
        }
        public AlertPage ClickOnPromtButton()
        {
            ClickButtonByXPath(PromtButton);
            Thread.Sleep(6000);
            return new AlertPage(driver);
        }
        public AlertPage EnterTextAndAccept()
        {
            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("Test");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            return new AlertPage(driver);
        }
    }
}
