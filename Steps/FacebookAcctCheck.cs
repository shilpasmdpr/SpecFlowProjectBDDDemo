using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public sealed class FacebookAcctCheck
    {
        private IWebDriver driver;

        public FacebookAcctCheck(IWebDriver driver)
        {
            this.driver = driver;
        }
       

    }
}
