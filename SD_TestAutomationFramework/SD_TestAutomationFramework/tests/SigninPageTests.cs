using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SD_TestAutomationFramework.lib;

namespace SD_TestAutomationFramework.tests
{
    public class SigninPageTests
    {
        private SD_Website<ChromeDriver> SD_Website = new();

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSIgninButton_ThenIShouldLandOnTheSignInPage()
        {

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}
