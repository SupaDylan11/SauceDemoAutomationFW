using OpenQA.Selenium;
using SD_TestAutomationFramework.lib.driver_config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework.lib
{
    public class SD_Website<T> where T : IWebDriver, new()
    {
        public IWebDriver SeleniumDriver { get; set; }
        public SD_Website(int pageLoadInsecs = 20, int implicitWaitInSecs = 20, bool isHeadless = false)
        {
            //instatiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInSecs, isHeadless).Driver;
            //instatiate our page objects with the selenium driver
        }
    }
}
