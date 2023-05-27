using AventStack.ExtentReports.Model;
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
    public class BrowserWindow : BasePage
    {
        private IWebDriver driver;

        public BrowserWindow(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By AllertFrameWindowMenu = By.XPath("//*[text()='Alerts, Frame & Windows']");
        By AllertFrameWindow = By.XPath("(//div[@class='header-text'])[3]");
        By BrowserWindows = By.XPath("//span[text()='Browser Windows']");
        By NewTabButton = By.Id("tabButton");
        By WindowTabButton = By.Id("windowButton");
        By MessageWindowButton = By.Id("messageWindowButton");
        By SampleHeading = By.Id("sampleHeading");
        By body = By.XPath("//body");

        public BrowserWindow VerifyAllertFrameWindowOptionDisplay()
        {
            IsElementDisplayed(AllertFrameWindowMenu);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnAllertFrameWindowOption()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement AllertFrameWindowMenuEle = driver.FindElement(AllertFrameWindowMenu);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", AllertFrameWindowMenuEle);
            Thread.Sleep(2000);
            ClickButtonByXPath(AllertFrameWindowMenu);
            Thread.Sleep(2000);
            return new BrowserWindow(driver);
        }
        public BrowserWindow VerifyBrowserWindowsDisplay()
        {
            IsElementDisplayed(BrowserWindows);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnBrowserWindowsOption()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement BrowserWindowsEle = driver.FindElement(BrowserWindows);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", BrowserWindowsEle);
            Thread.Sleep(2000);
            ClickButtonByXPath(BrowserWindows);
            Thread.Sleep(2000);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnNewTabButton()
        {
            string expectedURL = "https://demoqa.com/sample";
            Thread.Sleep(2000);
            ClickButtonByXPath(NewTabButton);
            Thread.Sleep(2000);
            Assert.AreEqual(driver.SwitchTo().Window(driver.WindowHandles[1]).Url, expectedURL);
            Thread.Sleep(2000);
            return new BrowserWindow(driver);
        }
        public BrowserWindow VerifyNewTabContent()
        {
            Thread.Sleep(2000);
            IsElementDisplayed(SampleHeading);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnNewWindow()
        {
            Thread.Sleep(2000);
            ClickButtonByXPath(WindowTabButton);
            Thread.Sleep(2000);
            return new BrowserWindow(driver);
        }
        public BrowserWindow VerifyNewWindowContent()
        {
            Thread.Sleep(2000);
            var windowHandles = driver.WindowHandles;
            foreach (var handle in windowHandles)
            {
                driver.SwitchTo().Window(handle);

                Thread.Sleep(2000);
                Assert.AreEqual(driver.SwitchTo().Window(driver.WindowHandles[1]).Url, "https://demoqa.com/sample");
            }
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnNewWindowMessage()
        {
            Thread.Sleep(2000);
            ClickButtonByXPath(MessageWindowButton);
            Thread.Sleep(2000);
            return new BrowserWindow(driver);
        }
        public BrowserWindow VerifyNewWindowMessage()
        {
            Thread.Sleep(2000);
            var windowHandles = driver.WindowHandles;
            foreach (var handle in windowHandles)
            {
                driver.SwitchTo().Window(handle);

                Thread.Sleep(2000);
                string expectedAlertText = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";
                //Assert.Contains(driver.SwitchTo().Window(driver.WindowHandles[1]));
            }
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            return new BrowserWindow(driver);
        }
}
}
