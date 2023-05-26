using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string verifyPageTitle()
        {
            string pageTitle = driver.Title;
            return pageTitle;
        }
    }
}
