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

        public BrowserWindow(IWebDriver driver)
        {
            this.driver = driver;
        }
        By AllertFrameWindow = By.XPath("(//div[@class='header-text'])[3]");
        By BrowserWindows = By.XPath("//span[text()='Browser Windows']");
        By NewTabButton = By.Id("tabButton");
        By WindowTabButton = By.Id("windowButton");
        By MessageWindowButton = By.Id("messageWindowButton");
        By SampleHeading = By.Id("sampleHeading");

        public BrowserWindow VerifyAllertFrameWindowOptionDisplay()
        {
            IsElementDisplayed(AllertFrameWindow);
            return new BrowserWindow(driver);
        }
        public BrowserWindow ClickOnAllertFrameWindowOption()
        {
            Thread.Sleep(2000);
            ClickButtonByXPath(AllertFrameWindow);
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
            driver.SwitchTo().NewWindow(WindowType.Window); 
            Thread.Sleep(2000);
            Assert.AreEqual(driver.SwitchTo().Window(driver.WindowHandles[1]).Url, "https://demoqa.com/sample");
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
            driver.SwitchTo().NewWindow(WindowType.Window);
            //Set<String> winHandles = driver.getWindowHandles();
            //Iterator<String> itr = winHandles.iterator();

            //String currentWin = itr.next();
            //String newBrowserWin = null;
            //if (itr.hasNext())
            //    newBrowserWin = itr.next();

            //String newBrowserWinText;
            //if (newBrowserWin != null)
            //{
            //    driver.switchTo().window(newBrowserWin);

            //    newBrowserWinText = driver.findElement(By.tagName("body")).getText();
            //}
            return new BrowserWindow(driver);
    }
}
}
