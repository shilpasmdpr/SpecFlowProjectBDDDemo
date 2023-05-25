using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Utility
{
    public class BasePage
    {
        private IWebDriver driver;

        public Boolean IsElementDisplayed(By by)
        {
           
                if(driver.FindElement(by).Displayed)

                {
                return true;
            }else
            {
                return false;
            }
        }
        public void SendKeys(By by,string text)
        {

            driver.FindElement(by).SendKeys(text);
        }
        public String GetInnerTextAttributeValueByLocator(By by)
        {
            return driver.FindElement(by).GetAttribute("innerText");
        }
        public Boolean IsElementSelected(By by)
        {
            return driver.FindElement(by).Selected;
        }
        
        }
}
