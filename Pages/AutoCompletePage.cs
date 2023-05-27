using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class AutoCompletePage : BasePage
    {
        private IWebDriver driver;

        public AutoCompletePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By Widgets = By.XPath("//*[text()='Widgets']");
        By AutoComplete = By.XPath("//*[text()='Auto Complete']");
        By AutoCompleteMultipleContainer = By.XPath("//span[text()='Type multiple color names']//following::div[1]");
        By FrameName = By.XPath("");
        public AutoCompletePage VerifyWidgetDisplay()
        {
            IsElementDisplayed(Widgets);
            return new AutoCompletePage(driver);
        }
        public AutoCompletePage ClickOnWidget()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement WidgetsEle = driver.FindElement(By.XPath("//*[text()='Widgets']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", WidgetsEle);
            Thread.Sleep(1000);
            ClickButtonByXPath(Widgets);
            return new AutoCompletePage(driver);
        }
        public AutoCompletePage VerifyAutoComplete()
        {
            IsElementDisplayed(AutoComplete);
            return new AutoCompletePage(driver);
        }
        public AutoCompletePage ClickOnAutoComplete()
        {
            ClickButtonByXPath(AutoComplete);
            return new AutoCompletePage(driver);
        }
        public AutoCompletePage EnterMultipleColorNames()
        {
            //IList<IWebElement> frameCount  = driver.FindElements(By.TagName("iframe"));
            //driver.SwitchTo().Frame("mainFrame");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ClickButtonByXPath(AutoCompleteMultipleContainer);
            SendKeys(AutoCompleteMultipleContainer, "Green");
            Thread.Sleep(2000);
            return new AutoCompletePage(driver);
        }
    }
}
