using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class DatePickerPage : BasePage
    {
        private IWebDriver driver;

        public DatePickerPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By DatePicker = By.XPath("//span[text()='Date Picker']");
        By InputSelectDate = By.Id("datePickerMonthYearInput");
        By InputDateAndTime = By.Id("dateAndTimePickerInput");
        By DateCalendar = By.XPath("(//div[contains(@class,'react-datepicker__day react-datepicker__day')])[10]");
        By Time = By.XPath("//li[text()='01:15']");

        public DatePickerPage VerifyDatePickerDisplay()
        {
            IsElementDisplayed(DatePicker);
            return new DatePickerPage(driver);
        }
        public DatePickerPage ClickOnDatePicker()
        {
            Thread.Sleep(1000);
            ClickButtonByXPath(DatePicker);
            return new DatePickerPage(driver);
        }
        public DatePickerPage UpdateTheDate()
        {
            Thread.Sleep(1000);
            ClickButtonByXPath(InputSelectDate);
            ClickButtonByXPath(DateCalendar);
            return new DatePickerPage(driver);
        }
        public DatePickerPage UpdateTheDateAndTime()
        {
            Thread.Sleep(1000);
            ClickButtonByXPath(InputDateAndTime);
            ClickButtonByXPath(DateCalendar);
            ClickButtonByXPath(Time);
            return new DatePickerPage(driver);
        }
    }
}
