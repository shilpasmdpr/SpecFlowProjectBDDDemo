using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Features
{
    [Binding]

    public class CheckBoxSteps
    {
        private IWebDriver driver;
        CheckBoxPage checkBox;


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
