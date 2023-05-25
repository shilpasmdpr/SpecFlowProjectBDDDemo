using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public CheckBoxPage verifyElementDisplay()
        {
            IsElementDisplayed(CheckBoxOption);
            return new CheckBoxPage(driver);
        }
    }
}
