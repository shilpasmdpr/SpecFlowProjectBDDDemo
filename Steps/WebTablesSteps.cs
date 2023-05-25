using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class WebTablesSteps
    {
            private IWebDriver driver;
        WebTablesPage webTablesPage;

            [Then(@"Verify Web Tables Element Display")]
        public void ThenVerifyWebTablesElementDisplay()
        {
            webTablesPage.VerifyWebTablesDisplay();
        }
        [When(@"Click On Web Tables Element")]
        public void WhenClickOnWebTablesElement()
        {
            webTablesPage.ClickOnWebTables();
        }
        
        [When(@"Click On Edit Web Tables")]
        public void WhenClickOnEditWebTables()
        {
            webTablesPage.ClickOnWebTablesEditIcon();
        }
        [Then(@"Verify Registration Heading Display")]
        public void ThenVerifyRegistrationHeadingDisplay()
        {
            webTablesPage.AssertRegistrationHeading();
        }
        [When(@"Enter Values Into Text Box Full Name (.*) , Last Name (.*), Email (.*), Age (.*) ,Salary (.*) And Department(.*) Submit")]
        public void WhenEnterValuesIntoTextBoxFullNameFirstNameLastNameLastNameEmailEmailAgeAgeSalarySalaryAndDepartmentDepartmentSubmit(string firstName, string lastName, string email, int age, int salary, string department)
        {
            webTablesPage.EditTheExistingWebTableElements(firstName, lastName,email, age, salary,department);
        }
        

        [Then(@"Verify (.*) , (.*),(.*), (.*) ,(.*) ,(.*)")]
        public void ThenVerifyFirstNameLastNameEmailAgeSalaryDepartment(string firstName, string lastName, string age, string email, string salary, string department)
        {
            webTablesPage.VerifyUpdatedValues(firstName, lastName, age,email,salary,department);
        }

    }
}
