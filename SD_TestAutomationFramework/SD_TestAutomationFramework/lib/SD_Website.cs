using OpenQA.Selenium;
using SD_TestAutomationFramework.lib.driver_config;
using SD_TestAutomationFramework.lib.pages;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 6166f81917fb39d2079190128b7483f20ca3f45a

namespace SD_TestAutomationFramework.lib
{
    public class SD_Website<T> where T : IWebDriver, new()
    {
        // Acessible Page objects and Selenium driver
        public IWebDriver SeleniumDriver { get; set; }
<<<<<<< HEAD
        public SD_BasketPage SD_BasketPage { get; set; }
=======
        public SD_SigninPage SD_SignInPage { get; set; }
>>>>>>> 6166f81917fb39d2079190128b7483f20ca3f45a

        public SD_Website(int pageLoadInsecs = 20, int implicitWaitInSecs = 20, bool isHeadless = false)
        {
            //instatiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInSecs, isHeadless).Driver;
<<<<<<< HEAD
            //instantiate our page objects with the selenium driver
            SD_BasketPage = new SD_BasketPage(SeleniumDriver);
=======
            //instatiate our page objects with the selenium driver
            SD_SignInPage = new SD_SigninPage(SeleniumDriver);
>>>>>>> 6166f81917fb39d2079190128b7483f20ca3f45a
        }
    }
}
