using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By UserName = By.Id("email");
        By Password = By.Id("pass");
        By LoginButton = By.Name("login");

        public HomePage EnterCredentialsAndClick(string un,string pwd)
        {
            driver.FindElement(UserName).SendKeys(un);
            driver.FindElement(Password).SendKeys(pwd);
            return new HomePage(driver);
        }
        public HomePage ClickOnLoginButton()
        {
            
            driver.FindElement(LoginButton).Click();
            return new HomePage(driver);
        }

    }
}
