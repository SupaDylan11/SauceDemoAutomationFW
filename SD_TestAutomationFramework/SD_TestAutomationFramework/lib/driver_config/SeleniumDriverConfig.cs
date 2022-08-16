using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SD_TestAutomationFramework.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSecs, bool isHeadless)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSecs, isHeadless);
        }

        private void DriverSetUp(int pageLoadInSecs, int implicitWaitInSecs, bool isHeadless)
        {
            // This is the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            // This is the time the driver waits for the elements
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
            if (isHeadless) SetHeadless();
        }

        private void SetHeadless()
        {
            if (Driver is ChromeDriver)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("headless");
                Driver.Dispose();
                Driver = new ChromeDriver(options);
            }
            else if (Driver is FirefoxDriver)
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArgument("--headless");
                Driver.Dispose();
                Driver = new FirefoxDriver(options);
            }
            else
            {
                throw new ArgumentException("Browser not supported by framework");
            }
        }
    }
}
