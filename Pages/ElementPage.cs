using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class ElementPage : BasePage
    {
        private IWebDriver driver;

        public ElementPage(IWebDriver driver, IWebDriver driver1)
        {
            this.driver = driver;
        }

        public ElementPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By ElementOption = By.XPath("//*[text()='Elements']");
        By TextBoxHeading = By.XPath("//div[text()='Text Box']");
        By TextBoxOption = By.XPath("//span[text()='Text Box']");
        By FullNameInput = By.Id("userName");
        By EmailInput = By.Id("userEmail");
        By CurrentAddressInput = By.Id("currentAddress");
        By PermanentAddressInput = By.Id("permanentAddress");
        By FullNameValue = By.Id("name");
        By EmailValue = By.Id("email");
        By CurrentAddressValue = By.Id("currentAddress");
        By PermanentAddressValue = By.Id("permanentAddress");

        public void verifyElementDisplay()
        {
            IsElementDisplayed(ElementOption);
            //return new ElementPage(driver);
        }
        public void ClickOnElementOption()
        {
            Thread.Sleep(2000);
            driver.FindElement(ElementOption).Click();
            Thread.Sleep(2000);
           // return new ElementPage(driver);
        }
        public void verifyTextBoxDisplay()
        {
            IsElementDisplayed(TextBoxOption);
            //return new ElementPage(driver);
        }
        public void ClickOnTextBox()
        {
            driver.FindElement(TextBoxOption).Click();
           // return new ElementPage(driver);
        }
        public void VerifyTextBoxHeading()
        {
            Assert.AreEqual("Text Box", TextBoxHeading);
            //return new ElementPage(driver);
        }
        public void VerifyTextBoxElements()
        {
            Assert.AreEqual("Text Box", TextBoxHeading);
            //return new ElementPage(driver);
        }
        public void EnterTextBoxValues(string fullName,string Email,string currentAddress, string permanentAddress)
        {
            SendKeys(FullNameInput, fullName);
            SendKeys(EmailInput, Email);
            SendKeys(CurrentAddressInput, currentAddress);
            SendKeys(PermanentAddressInput, permanentAddress);
            //return new ElementPage(driver);
        }
        public void VerifyTextBoxValues(string fullName, string Email, string currentAddress, string permanentAddress)
        {
            Assert.AreEqual(fullName, GetInnerTextAttributeValueByLocator(FullNameValue));
            Assert.AreEqual(fullName, GetInnerTextAttributeValueByLocator(EmailValue));
            Assert.AreEqual(fullName, GetInnerTextAttributeValueByLocator(CurrentAddressValue));
            Assert.AreEqual(fullName, GetInnerTextAttributeValueByLocator(PermanentAddressValue));
            //return new ElementPage(driver);
        }
    }
}
