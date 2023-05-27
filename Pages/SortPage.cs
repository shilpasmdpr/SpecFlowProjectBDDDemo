using Microsoft.VisualBasic;
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
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class SortPage : BasePage
    {
        private IWebDriver driver;

        public SortPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By InteractionsMenu = By.XPath("//*[text()='Interactions']");
        By Sortable = By.XPath("//*[text()='Sortable']");

        public SortPage VerifyInteractionsMenuDisplay()
        {
            IsElementDisplayed(InteractionsMenu);
            return new SortPage(driver);
        }
        public SortPage ClickOnInteractionsMenuDisplay()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement InteractionsEle = driver.FindElement(By.XPath("//*[text()='Interactions']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", InteractionsEle);
            ClickButtonByXPath(InteractionsMenu);
            return new SortPage(driver);
        }
        public SortPage VerifySortOptionDisplay()
        {
            IsElementDisplayed(Sortable);
            return new SortPage(driver);
        }
        public SortPage ClickOnSortOption()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement SortableEle = driver.FindElement(By.XPath("//*[text()='Sortable']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", SortableEle);
            ClickButtonByXPath(Sortable);
            return new SortPage(driver);
        }
        public SortPage ShuffleTheList()
        {
            IWebElement targetElement = driver.FindElement(By.XPath("(//*[text()='Three'])[1]"));
            IWebElement sourceElement = driver.FindElement(By.XPath("(//*[text()='One'])[1]"));
            Actions actions = new Actions(driver);

            // Perform the drag and drop action
            actions.ClickAndHold(sourceElement)
                   .MoveToElement(targetElement)
                   .Release()
                   .Build()
                   .Perform();
            return new SortPage(driver);
        }

        [When(@"Sort the list and verify")]
        public SortPage SortTheListAndVerify()
        {
            List<String> displayNames = new List<string>();
            // grab the cells that contain the display names you want to verify are sorted
            IReadOnlyList<IWebElement> cells = driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//following::div[@class='list-group-item list-group-item-action']"));
            // loop through the cells and assign the display names into the ArrayList
            foreach (IWebElement cell in cells)
            {
                displayNames.Add(cell.Text);
            }
            // make a copy of the displayNames array
            List<String> displayNamesSorted = new List<string>(displayNames);
            displayNamesSorted.Sort();
            Console.WriteLine(displayNames.SequenceEqual(displayNamesSorted));
            return new SortPage(driver);
        }

       
    }
}
