using OpenQA.Selenium;


namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_BasketPage
    {
        #region properties
        private IWebDriver _seleniumDriver;
        private IWebElement _continueShopping => _seleniumDriver.FindElement(By.Id("continue-shopping"));
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("checkout"));

        #endregion

        //constructor
        public SD_BasketPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region 
        public void ContinueShopping() => _continueShopping.Click();
        public void GoToCheckout() => _checkoutButton.Click();

        public void RemoveItemFromCart(string item)
        {
            IWebElement itemToRemove = _seleniumDriver.FindElement(By.Id($"remove-{item}"));
            itemToRemove.Click();
        }
        public IWebElement ItemInBasket(string item)
        {
            try
            {
                IWebElement element = _seleniumDriver.FindElement(By.Id($"remove-{item}"));
                return element;
            }
            catch (OpenQA.Selenium.NoSuchElementException ex)
            {
                Console.WriteLine($"Item not in basket. ${ex.ToString()}");
                return null;
            }
        } 

        #endregion
    }
}