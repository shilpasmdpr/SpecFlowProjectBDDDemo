using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class CreateUserPage : BasePage
    {
        private IWebDriver driver;
        string UserName;

        public CreateUserPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By BookStoreApplicationOpt = By.XPath("//*[text()='Book Store Application']");
        By LoginPage = By.XPath("//*[text()='Login']");
        By NewUser = By.Id("newUser");
        By RegisterToBookStore = By.XPath("//*[text()='Register to Book Store']");
        By InputFirstName = By.Id("firstname");
        By InputLastName = By.Id("lastname");
        By InputUserName = By.Id("userName");
        By InputPassword = By.Id("password");
        By RegisterButton = By.Id("register");
        By Login = By.Id("login");

        public CreateUserPage VerifyBookStoreApplicationDisplay()
        {
            IsElementDisplayed(BookStoreApplicationOpt);
            return new CreateUserPage(driver);
        }
        public CreateUserPage ClickOnBookStoreApplication()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement BookStoreAppEle = driver.FindElement(BookStoreApplicationOpt);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", BookStoreAppEle);
            Thread.Sleep(1000);
            ClickButtonByXPath(BookStoreApplicationOpt);
            return new CreateUserPage(driver);
        }
        public CreateUserPage VerifyLoginDisplay()
        {
            IsElementDisplayed(LoginPage);
            return new CreateUserPage(driver);
        }
        public CreateUserPage ClickOnLoginOpt()
        {
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement LoginPageEle = driver.FindElement(LoginPage);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", LoginPageEle);
            ClickButtonByXPath(LoginPage);
            return new CreateUserPage(driver);
        }
        public CreateUserPage ClickOnNewUserButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement NewUserEle = driver.FindElement(NewUser);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", NewUserEle);
            ClickButtonByXPath(NewUser);
            return new CreateUserPage(driver);
        }
        public CreateUserPage VerifyRegistrationFormHeading()
        {
            IsElementDisplayed(RegisterToBookStore);
            return new CreateUserPage(driver);
        }
        public CreateUserPage EnterUserValues(string firstName, string lastName, string password)
        {
            string username = GenerateRandomUsername();
            Console.WriteLine("Random Username: " + username);
            SendKeys(InputFirstName, firstName);
            SendKeys(InputLastName, lastName);
            SendKeys(InputUserName, username);
            SendKeys(InputPassword, password);
            string UserName = GetInnerTextAttributeValueByLocator(InputUserName);
            Thread.Sleep(2000);
            return new CreateUserPage(driver);
        }

        private string GenerateRandomUsername()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] chars = new char[8]; // Change the length as per your requirement

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = allowedChars[random.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        public CreateUserPage PassCaptcha()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("//iframe[@title='reCAPTCHA']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("recaptcha-checkbox-border"))).Click();
            //SpeechRecognitionResult result = recognizer.recognizeOnceAsync.get(); 
            //driver.SwitchTo().DefaultContent();
            Thread.Sleep(5000); // Manually perform captcha validation
            return new CreateUserPage(driver);
        }
        public CreateUserPage ClickOnRegisterButton()
        {
            driver.SwitchTo().DefaultContent();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement RegisterEle = driver.FindElement(RegisterButton);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", RegisterEle);
            driver.FindElement(By.Id("register")).Click();
            return new CreateUserPage(driver);
        }
        public CreateUserPage VerifySuccessfulUserCreation()
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Assert.IsTrue(alertText.Contains("User Register Successfully"));
            return new CreateUserPage(driver);
        }
        public CreateUserPage LoginAsUserAndVerify(string password)
        {
            driver.Url = "https://demoqa.com/login";
            Thread.Sleep(2000);
            SendKeys(InputUserName, UserName);
            SendKeys(InputPassword, password);
            ClickButtonByXPath(Login);
            return new CreateUserPage(driver);
        }
        public CreateUserPage VerifyPageTitle()
        {
            string url = driver.Url;
            Thread.Sleep(2000);
            Assert.AreEqual(url, "https://demoqa.com/profile");
            return new CreateUserPage(driver);
        }
    }
}
