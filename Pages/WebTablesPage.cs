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
    public class WebTablesPage : BasePage
    {
        private IWebDriver driver;
        public WebTablesPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By FirstName = By.Id("firstName");
        By LastName = By.Id("lastName");
        By Email = By.Id("userEmail");
        By Age = By.Id("age");
        By Salary = By.Id("salary");
        By Department = By.Id("department");
        By SubmitButton = By.Id("submit");
        By WebTables = By.XPath("//*[text()='Web Tables']");
        By EditIcon = By.XPath("(//span[@title='Edit'])[1]");
        By RegistrationForm = By.XPath("//div[text()='Registration Form']");
        By TableFirstNameValue = By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[1]");
        By TableLastNameValue = By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[2]");
        By TableAgeValue = By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[3]");
        By TableEmailValue = By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[4]");
        By TableSalaryValue= By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[5]");
        By TableDepartmentValue = By.XPath("(//div[@class='rt-tr-group']//div[@role='gridcell'])[6]");

        public WebTablesPage VerifyWebTablesDisplay()
        {
            Thread.Sleep(2000);
            IsElementDisplayed(WebTables);
            Thread.Sleep(2000);
            return new WebTablesPage(driver);
        }
        public WebTablesPage ClickOnWebTables()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement WebTablesEle = driver.FindElement(WebTables);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", WebTablesEle);
            driver.FindElement(WebTables).Click();
            Thread.Sleep(2000);
            return new WebTablesPage(driver);
        }
        public WebTablesPage AssertRegistrationHeading()
        {
            Assert.AreEqual("Registration Form", GetInnerTextAttributeValueByLocator(RegistrationForm));

            return new WebTablesPage(driver);
        }
        public WebTablesPage ClickOnWebTablesEditIcon()
        {
            driver.FindElement(EditIcon).Click();
            return new WebTablesPage(driver);
        }
        public WebTablesPage EditTheExistingWebTableElements(string firstName, string lastName, string email, int age, int salary, string department)
        {
            driver.FindElement(FirstName).Clear();
            SendKeys(FirstName, firstName);
            driver.FindElement(LastName).Clear();
            SendKeys(LastName, lastName);
            driver.FindElement(Email).Clear();
            SendKeys(Email,email);
            driver.FindElement(Age).Clear();
            SendKeys(Age, age.ToString());
            driver.FindElement(Salary).Clear();
            SendKeys(Salary,salary.ToString());
            driver.FindElement(Department).Clear();
            SendKeys(Department, department);
            Thread.Sleep(2000);
            driver.FindElement(SubmitButton).Click();
            Thread.Sleep(2000);
            return new WebTablesPage(driver);
        }
        public WebTablesPage VerifyUpdatedValues(string firstName, string lastName, string age, string email, string salary, string department)
        {
            Assert.AreEqual(firstName, GetInnerTextAttributeValueByLocator(TableFirstNameValue));
            Assert.AreEqual(lastName, GetInnerTextAttributeValueByLocator(TableLastNameValue));
            Assert.AreEqual(email, GetInnerTextAttributeValueByLocator(TableEmailValue));
            Assert.AreEqual(age.Trim(), GetInnerTextAttributeValueByLocator(TableAgeValue).Trim());
            Assert.AreEqual(salary.Trim(), GetInnerTextAttributeValueByLocator(TableSalaryValue).Trim());
            Assert.AreEqual(department, GetInnerTextAttributeValueByLocator(TableDepartmentValue));
            return new WebTablesPage(driver);
        }
    }
}
