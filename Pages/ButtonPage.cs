using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class ButtonPage : BasePage
    {
        private IWebDriver driver;

        public ButtonPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By ButtonOption = By.XPath("//*[text()='Buttons']");
        By DoubleClickMe = By.Id("doubleClickBtn");
        By RightClickMe = By.Id("rightClickBtn");
        By ClickMe = By.XPath("//button[text()='Click Me']");
        By ButtonsPageHeading = By.XPath("//div[text()='Buttons']");
        By DoubleClickMsg = By.Id("doubleClickMessage");
        By RightClickMsg = By.Id("rightClickMessage");
        By ClickMsg = By.Id("dynamicClickMessage");
        private IWebElement ele;

        public ButtonPage verifyElementDisplay()
        {
            IsElementDisplayed(ButtonOption);
            return new ButtonPage(driver);
        }
        public ButtonPage ClickOnElementOption()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement ButtonOptionEle = driver.FindElement(ButtonOption);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", ButtonOptionEle);
            Thread.Sleep(2000);
            ClickButtonByXPath(ButtonOption);
            Thread.Sleep(2000);
            return new ButtonPage(driver);
        }
        public ButtonPage AssertButtonPageHeading()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(GetInnerTextAttributeValueByLocator(ButtonsPageHeading), "Buttons");
            Thread.Sleep(2000);
            return new ButtonPage(driver);
        }
        public ButtonPage ClickOnClickMebutton()
        {
            ClickButtonByXPath(ClickMe);
            return new ButtonPage(driver);
        }
        public ButtonPage DoubleClickOnDoubleClickMebutton()
        {
             ele = driver.FindElement(DoubleClickMe);
            PerformDoubleClickAction(ele);
            return new ButtonPage(driver);
        }
        public ButtonPage VerifyDoubleClickMsgDisplay()
        {
           Assert.AreEqual("You have done a double click", GetInnerTextAttributeValueByLocator(DoubleClickMsg));
            return new ButtonPage(driver);
        }
        public ButtonPage RightClickOnDoubleClickMebutton()
        {
            IWebElement RightClickele = driver.FindElement(RightClickMe);
            PerformRightClickAction(RightClickele);
            return new ButtonPage(driver);
        }
        public ButtonPage VerifyRightClickMsgDisplay()
        {
            Assert.AreEqual("You have done a right click", GetInnerTextAttributeValueByLocator(RightClickMsg));
            return new ButtonPage(driver);
        }
        public ButtonPage ClickOnDoubleClickMebutton()
        {
            ClickButtonByXPath(ClickMe);
            return new ButtonPage(driver);
        }
        public ButtonPage VerifyClickMsgDisplay()
        {
            Assert.AreEqual("You have done a dynamic click", GetInnerTextAttributeValueByLocator(ClickMsg));
            return new ButtonPage(driver);
        }
    }
}
