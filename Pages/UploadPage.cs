using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectBDDDemo.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProjectBDDDemo.Pages
{
    public class UploadPage : BasePage
    {
        private IWebDriver driver;

        public UploadPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        By UploadAndDownloadOption = By.XPath("//*[text()='Upload and Download']");
        By UploadFile = By.Id("uploadFile");
        By UploadFilePath = By.Id("uploadedFilePath");
        By Download = By.Id("downloadButton");
        private IWebElement UploadFilePathInput => driver.FindElement(By.XPath("//input[@type='file']"));

        public UploadPage VerifyUploadElementDisplay()
        {
            IsElementDisplayed(UploadAndDownloadOption);
            return new UploadPage(driver);
        }
        public UploadPage ClickOnUploadAndDownloadOption()
        {
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement UploadAndDownloadOptionEle = driver.FindElement(UploadAndDownloadOption);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", UploadAndDownloadOptionEle);
            driver.FindElement(UploadAndDownloadOption).Click();

            Thread.Sleep(2000);
            return new UploadPage(driver);
        }
        public UploadPage ClickAndUploadFile()
        {
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Id("uploadFile"));
            // Specify the path to the file you want to upload
            string filePath = "C:\\Users\\shilp\\Downloads\\sampleFile.jpeg";
            // Enter the file path into the file input field
            element.SendKeys(filePath);
            return new UploadPage(driver);
        }
        public UploadPage VerifyUploadFile()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(GetInnerTextAttributeValueByLocator(UploadFilePath), "C:\\fakepath\\sampleFile.jpeg");
            return new UploadPage(driver);
        }
        public UploadPage ClickOnDownloadButton()
        {
            Thread.Sleep(2000);
            ClickButtonByXPath(Download);
            return new UploadPage(driver);
        }
        public UploadPage CheckFileDownloaded(string filename)
        {
            bool exist = false;
            string Path = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads";
            string[] filePaths = Directory.GetFiles(Path);
            foreach (string p in filePaths)
            {
                if (p.Contains(filename))
                {
                    FileInfo thisFile = new FileInfo(p);
                    //Check the file that are downloaded in the last 3 minutes
                    if (thisFile.LastWriteTime.ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(1).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(2).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(3).ToShortTimeString() == DateTime.Now.ToShortTimeString())
                        exist = true;
                    File.Delete(p);
                    break;
                }
            }
            return new UploadPage(driver);
        }
    }
}
