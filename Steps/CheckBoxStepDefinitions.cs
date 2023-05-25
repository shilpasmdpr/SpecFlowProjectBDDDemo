using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo
{
    [Binding]
    public class CheckBoxStepDefinitions
    {
        private IWebDriver driver;
        CheckBoxPage checkBox;

        public CheckBoxStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Then(@"Verify Check Box Display")]
        public void ThenVerifyCheckBoxDisplay()
        {
            checkBox.VerifyCheckBoxOptionDisplay();
        }

        [When(@"Click on Check Box Option")]
        public void WhenClickOnCheckBoxOption()
        {
            checkBox.ClickOnTextBox();
        }

        [When(@"the click on Toggle")]
        public void WhenTheClickOnToggle()
        {
            checkBox.ClickOnToggle();
        }

        [When(@"Click on Notes checkbox")]
        public void WhenClickOnNotesCheckbox()
        {
            checkBox.ClickOnNotesOption();
        }

        [Then(@"Verify Notes Option selected")]
        public void ThenVerifyNotesOptionSelected()
        {
            checkBox.VerifyNotesIsSelected();
        }
    }
}
