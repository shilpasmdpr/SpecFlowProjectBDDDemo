using OpenQA.Selenium;
using SpecFlowProjectBDDDemo.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBDDDemo.Steps
{
    [Binding]
    public class UploadsAndDownloadsStepDefinitions
    {
        private IWebDriver driver;
        UploadPage? uploadPage;
        public UploadsAndDownloadsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Then(@"Verify Upload And Download Element Display")]
        public void ThenVerifyUploadAndDownloadElementDisplay()
        {
            uploadPage.VerifyUploadElementDisplay();
        }

        [When(@"Click on Upload And Download Element")]
        public void WhenClickOnUploadAndDownloadElement()
        {
            uploadPage.ClickOnUploadAndDownloadOption();
        }

        [When(@"Click on choose file and Upload a file")]
        public void WhenClickOnChooseFileAndUploadAFile()
        {
            uploadPage.ClickAndUploadFile();
        }

        [Then(@"Verify file uploaded successfully")]
        public void ThenVerifyFileUploadedSuccessfully()
        {
            uploadPage.VerifyUploadFile();
        }

        [When(@"Click on download button")]
        public void WhenClickOnDownloadButton()
        {
            uploadPage.ClickOnDownloadButton();
        }

        [Then(@"Verify file downloaded successfully")]
        public void ThenVerifyFileDownloadedSuccessfully()
        {
            uploadPage.CheckFileDownloaded("sampleFile");
        }
    }
}
