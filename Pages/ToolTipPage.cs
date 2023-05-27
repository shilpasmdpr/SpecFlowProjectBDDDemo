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
    public class ToolTipPage : BasePage
    {
        private IWebDriver driver;

        public ToolTipPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By ToolTipsOpt=By.XPath("//span[text()='Tool Tips']");
        By ClickButtonToSeeAlert = By.Id("alertButton");
        

        public ToolTipPage VerifyToolTipsOptDisplay()
        {
            IsElementDisplayed(ToolTipsOpt);
            return new ToolTipPage(driver);
        }
        public ToolTipPage ClickOnToolTipsOpt()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement ToolTipEle = driver.FindElement(By.XPath("//span[text()='Tool Tips']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", ToolTipEle);
            Thread.Sleep(2000);
            ClickButtonByXPath(ToolTipsOpt);
            return new ToolTipPage(driver);
        }
        public ToolTipPage MouseHoverAndFetchData()
        {
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.Id("toolTipButton")); 
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            IWebElement tooltipElement = driver.FindElement(By.XPath("//div[@role='tooltip']"));
            tooltipElement.Click();
            string tooltipText = tooltipElement.GetAttribute("innerText");
            Thread.Sleep(2000);
            Assert.AreEqual(tooltipText, "You hovered over the Button");
            return new ToolTipPage(driver);
        }
        public ToolTipPage MouseHoverOnTextBoxAndFetchData()
        {
            Thread.Sleep(1000);
            IWebElement element1 = driver.FindElement(By.Id("toolTipTextField"));
            Actions action = new Actions(driver);
            action.MoveToElement(element1).Perform();
            IWebElement tooltipElement1 = driver.FindElement(By.XPath("//div[@role='tooltip']"));
            tooltipElement1.Click();
            string tooltipText1 = tooltipElement1.GetAttribute("innerText");
            Thread.Sleep(2000);
            Assert.AreEqual(tooltipText1, "You hovered over the text field");
            Console.WriteLine(tooltipText1);
            return new ToolTipPage(driver);
        }
        public ToolTipPage MouseHoverOnContraryAndFetchData()
        {
            Thread.Sleep(1000);
            IWebElement element2 = driver.FindElement(By.XPath("//*[text()='Contrary']"));
            Actions action = new Actions(driver);
            action.MoveToElement(element2).Perform();
            IWebElement tooltipElement2 = driver.FindElement(By.XPath("//div[@role='tooltip']"));
            tooltipElement2.Click();
            string tooltipText2 = tooltipElement2.GetAttribute("innerText");
            Thread.Sleep(2000);
            Assert.AreEqual(tooltipText2, "You hovered over the Contrary");
            Console.WriteLine(tooltipText2);
            return new ToolTipPage(driver);
        }
        public ToolTipPage MouseHoverOnNumberAndFetchData()
        {
            Thread.Sleep(1000);
            IWebElement element3 = driver.FindElement(By.XPath("//*[text()='1.10.32']"));
            Actions action = new Actions(driver);
            action.MoveToElement(element3).Perform();
            IWebElement tooltipElement3 = driver.FindElement(By.XPath("//div[@role='tooltip']"));
            tooltipElement3.Click();
            string tooltipText3 = tooltipElement3.GetAttribute("innerText");
            Thread.Sleep(2000);
            Assert.AreEqual(tooltipText3, "You hovered over the 1.10.32");
            Console.WriteLine(tooltipText3);
            return new ToolTipPage(driver);
        }
    }
}
