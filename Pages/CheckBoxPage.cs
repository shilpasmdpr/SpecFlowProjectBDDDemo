using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class CheckBoxPage
    {
        private IWebDriver driver;

        public CheckBoxPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public HomePage verifyPageTitle()
        {
            string pageTitle = driver.Title;
            return new HomePage(driver);
        }
    }
}
