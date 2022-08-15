using OpenQA.Selenium;
using SD_TestAutomationFramework.lib.driver_config;
using SD_TestAutomationFramework.lib.pages;

namespace SD_TestAutomationFramework.lib
{
    public class SD_Website<T> where T : IWebDriver, new()
    {
        // Acessible Page objects and Selenium driver
        public IWebDriver SeleniumDriver { get; set; }

        public SD_SigninPage SD_SignInPage { get; set; }
        public SD_BasketPage SD_BasketPage { get; set; }
        public SD_ProductsPage SD_ProductsPage { get; set; }
        public SD_CheckoutPage SD_CheckoutPage { get; set; }
        public SD_OverviewPage SD_OverviewPage { get; set; }
        public SD_CheckoutComplete SD_CheckoutComplete { get; set; }
        public SD_Website(int pageLoadInsecs = 20, int implicitWaitInSecs = 20, bool isHeadless = false)
        {
            //instatiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInsecs, implicitWaitInSecs, isHeadless).Driver;
            //instatiate our page objects with the selenium driver
            SD_ProductsPage = new SD_ProductsPage(SeleniumDriver);
            SD_SignInPage = new SD_SigninPage(SeleniumDriver);
            SD_BasketPage = new SD_BasketPage(SeleniumDriver);
            //instantiate checkout page object with selenium driver
            SD_CheckoutPage = new SD_CheckoutPage(SeleniumDriver);
            //instantiate overview page object with selenium driver
            SD_OverviewPage = new SD_OverviewPage(SeleniumDriver);
            //instantiate checkout-complete page object with selenium driver
            SD_CheckoutComplete = new SD_CheckoutComplete(SeleniumDriver);
        }
    }
}
