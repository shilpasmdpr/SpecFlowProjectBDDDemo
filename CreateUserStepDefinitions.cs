using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using SpecFlowProjectBDDDemo.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo
{
    [Binding]
    public class CreateUserStepDefinitions : BasePage
    {
        private IWebDriver driver;
        private CreateUserPage createUserPage;

        public CreateUserStepDefinitions(IWebDriver driver) : base(driver)
        {
            createUserPage = new CreateUserPage(driver);
            this.driver = driver;
        }
        [Then(@"Verify Book Store Application Option Display")]
        public void ThenVerifyBookStoreApplicationOptionDisplay()
        {
            createUserPage.VerifyBookStoreApplicationDisplay();
        }

        [When(@"Click on Book Store Application")]
        public void WhenClickOnBookStoreApplication()
        {
            createUserPage.ClickOnBookStoreApplication();
        }

        [Then(@"Verify login option Display")]
        public void ThenVerifyLoginOptionDisplay()
        {
            createUserPage.VerifyLoginDisplay();
        }

        [When(@"Click on login option")]
        public void WhenClickOnLoginOption()
        {
            createUserPage.ClickOnLoginOpt();
        }

        [When(@"Click on New User")]
        public void WhenClickOnNewUser()
        {
            createUserPage.ClickOnNewUserButton();
        }

        [Then(@"Verify Register to Book Store Heading")]
        public void ThenVerifyRegisterToBookStoreHeading()
        {
            createUserPage.VerifyRegistrationFormHeading();
        }

        [When(@"Enter FirstName (.*) , LastName (.*), UserName (.*) and (.*)")]
        public void WhenEnterFirstNameFirstNameLastNameLastNameUserNameUserNameAndPassword(string firstName, string lastName, string userName, string password)
        {
            createUserPage.EnterUserValues(firstName, lastName, password);
        }

        // need to handle the captcha manually 
        [Then(@"Verify CAPTCHA")]
        public void ThenVerifyCAPTCHA()
        {
            createUserPage.PassCaptcha();
        }

        [When(@"Click On Register Button")]
        public void WhenClickOnRegisterButton()
        {
            createUserPage.ClickOnRegisterButton();
        }

        [Then(@"Verify User Creation Successful Message")]
        public void ThenVerifyUserCreationSuccessfulMessage()
        {
            createUserPage.VerifySuccessfulUserCreation();
        }
        
        [When(@"Login as a new user with Password@(.*)")]
        public void WhenLoginAsANewUserWithPassword(string password)
        {
            createUserPage.LoginAsUserAndVerify(password);
        }

        [Then(@"Verify Page title")]
        public void ThenVerifyPageTitle()
        {
            createUserPage.VerifyPageTitle();
        }

    }
}
