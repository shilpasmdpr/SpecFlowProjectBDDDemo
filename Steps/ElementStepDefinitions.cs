using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo
{
    [Binding]
    public sealed class ElementStepDefinitions
    {
        private IWebDriver driver;
        private ElementPage elementPage;
        public ElementStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            elementPage = new ElementPage(driver);
        }
        [Then(@"Verify Element Display")]
        public void ThenVerifyElementDisplay()
        {
            elementPage.verifyElementDisplay();
            Thread.Sleep(2000);
        }

        [When(@"Click On Element Option")]
        public void WhenClickOnElementOption()
        {
            Thread.Sleep(2000);
            elementPage.ClickOnElementOption();
        }

        [Then(@"Verify Text Box Option Display")]
        public void ThenVerifyTextBoxOptionDisplay()
        {
            elementPage.verifyTextBoxDisplay();
        }

        [When(@"Click On Text Box Option")]
        public void WhenClickOnTextBoxOption()
        {
            elementPage.ClickOnTextBox();
        }

        [Then(@"Verify Text Box heading Display")]
        public void ThenVerifyTextBoxHeadingDisplay()
        {
            elementPage.VerifyTextBoxHeading();
        }

        [Then(@"Verify Text Fields")]
        public void ThenVerifyTextFields()
        {
            elementPage.VerifyTextBoxFields();
        }
        [When(@"Enter Values Into Text Box Full Name (.*) , Email (.*),Current Address(.*)And Permanent Address(.*) Submit")]
        public void WhenEnterValuesIntoTextBoxFullNameEmailCurrentAddressAndPermanentAddressSubmit(string fullName, string Email, string currentAddress, string permanentAddress)
        {
            elementPage.EnterTextBoxValues(fullName,Email,currentAddress,permanentAddress);
        }

        [Then(@"Verify (.*),(.*),(.*)And (.*) Values")]
        public void ThenVerifyAndValues(string fullName, string Email, string currentAddress, string permanentAddress)
        {
            elementPage.VerifyTextBoxValues(fullName, Email, currentAddress, permanentAddress);
        }



    }
}
