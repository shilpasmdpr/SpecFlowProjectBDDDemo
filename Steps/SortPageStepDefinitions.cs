using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class SortPageStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private SortPage sortPage;

        public SortPageStepDefinitions(IWebDriver driver) : base(driver)
        {
            sortPage = new SortPage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Interactions Option Display")]
        public void ThenVerifyInteractionsOptionDisplay()
        {
            sortPage.VerifyInteractionsMenuDisplay();
        }

        [When(@"Click On Interactions Option")]
        public void WhenClickOnInteractionsOption()
        {
            sortPage.ClickOnInteractionsMenuDisplay();
        }

        [Then(@"Verify Sortable Option Display")]
        public void ThenVerifySortableOptionDisplay()
        {
            sortPage.VerifySortOptionDisplay();
        }

        [When(@"Click On Sortable Option")]
        public void WhenClickOnSortableOption()
        {
            sortPage.ClickOnSortOption();
        }

        [When(@"Suffle the list")]
        public void WhenSuffleTheList()
        {
            sortPage.ShuffleTheList();
        }

        [When(@"Sort the list and verify")]
        public void WhenSortTheList()
        {
            sortPage.SortTheListAndVerify();
        }

    }
}
