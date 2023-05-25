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
    public class CheckBoxPage : BasePage
    {
        private IWebDriver driver;

        public CheckBoxPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By CheckBoxOption = By.XPath("//*[text()='Check Box']");
        By Toggle = By.XPath("//button[@title='Toggle']");
        By ChildToggle = By.XPath("(//button[@title='Toggle'])[2]");
        By NotesOption = By.XPath("//span[text()='Notes']");
        By SelectedNotes = By.XPath("//*[@class='rct-icon rct-icon-check']//following::span[1]");
        By SelectedOption = By.XPath("//*[@class='rct-icon rct-icon-check']");
        public CheckBoxPage VerifyCheckBoxOptionDisplay()
        {
            IsElementDisplayed(CheckBoxOption);
            return new CheckBoxPage(driver);
        }
        public CheckBoxPage ClickOnTextBox()
        {
            driver.FindElement(CheckBoxOption).Click();
            return new CheckBoxPage(driver);
        }
        public CheckBoxPage ClickOnToggle()
        {
            driver.FindElement(Toggle).Click();
            Thread.Sleep(2000);
            driver.FindElement(ChildToggle).Click();
            return new CheckBoxPage(driver);
        }
        public CheckBoxPage ClickOnNotesOption()
        {
            driver.FindElement(NotesOption).Click();
            Thread.Sleep(2000);
            return new CheckBoxPage(driver);
        }
        public CheckBoxPage VerifyNotesIsSelected()
        {
            IsElementSelected(SelectedOption);
            IsElementDisplayed(SelectedNotes);
            Thread.Sleep(2000);
            return new CheckBoxPage(driver);
        }
    }
}
