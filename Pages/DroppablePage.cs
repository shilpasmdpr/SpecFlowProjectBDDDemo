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
    public class DroppablePage : BasePage
    {
        private IWebDriver driver;

        public DroppablePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By DroppableOption = By.XPath("//span[text()='Droppable']");
        By DroppedMsg = By.XPath("(//div[@id='droppable']//p)[1]");


        public DroppablePage VerifyDroppableDisplay()
        {
            IsElementDisplayed(DroppableOption);
            return new DroppablePage(driver);
        }
        public DroppablePage ClickOnDroppable()
        {
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement DroppableEle = driver.FindElement(DroppableOption);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", DroppableEle);
            ClickButtonByXPath(DroppableOption);
            return new DroppablePage(driver);
        }
        public DroppablePage PerformDragAndDrop()
        {
            Thread.Sleep(1000);
            IWebElement targetElement = driver.FindElement(By.Id("droppable"));
            IWebElement sourceElement = driver.FindElement(By.Id("draggable"));
            Actions actions = new Actions(driver);

            // Perform the drag and drop action
            actions.ClickAndHold(sourceElement)
                   .MoveToElement(targetElement)
                   .Release()
                   .Build()
                   .Perform();
            return new DroppablePage(driver);
        }
        public DroppablePage VerifyDragAndDrop()
        {
            Thread.Sleep(1000);
            Assert.AreEqual(GetInnerTextAttributeValueByLocator(DroppedMsg), "Dropped!");
            return new DroppablePage(driver);
        }
    }
}
