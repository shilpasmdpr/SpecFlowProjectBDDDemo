using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class DroppableStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private DroppablePage droppablePage;

        public DroppableStepDefinitions(IWebDriver driver) : base(driver)
        {
            droppablePage = new DroppablePage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Droppable Option Display")]
        public void ThenVerifyDroppableOptionDisplay()
        {
            droppablePage.VerifyDroppableDisplay();
        }

        [When(@"Click On Droppable Option")]
        public void WhenClickOnDroppableOption()
        {
            droppablePage.ClickOnDroppable();
        }

        [When(@"Perform drag and drop")]
        public void WhenPerformDragAndDrop()
        {
            droppablePage.PerformDragAndDrop();
        }

        [Then(@"Verify the dropped message")]
        public void ThenVerifyTheDroppedMessage()
        {
            droppablePage.VerifyDragAndDrop();
        }
    }
}
