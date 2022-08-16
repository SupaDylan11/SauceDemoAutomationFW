using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_ProductsPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _backpackLink => _seleniumDriver.FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _filterLink => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        private IWebElement _filterZA => _filterLink.FindElement(By.XPath("//option[text() = 'Name (Z to A)']"));
        private IWebElement _firstItem => _seleniumDriver.FindElement(By.ClassName("inventory_list")).FindElement(By.XPath($"//div[1]")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _shoppingCart => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));
        private IReadOnlyList<IWebElement> _items => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link")).FindElements(By.XPath(".//*"));
        private IWebElement _shoppingCartLink => _seleniumDriver.FindElement(By.Id("shopping_cart_container")).FindElement(By.TagName("a"));
        private IWebElement _itemList => _seleniumDriver.FindElement(By.ClassName("inventory_list"));

        public SD_ProductsPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickBackpackLink() => _backpackLink.Click();
        public void SelectItem(int itemNo) => _itemList.FindElement(By.XPath($"//div[{itemNo}]/div/a/img")).Click();
        public void ClickFilterLink() => _filterLink.Click();
        public void ClickFilterZA() => _filterZA.Click();
        public void ClickFilterType(string filterType) => _seleniumDriver.FindElement(By.XPath($"//option[text() = '{filterType}']")).Click();
        public string FirstItemName() => _firstItem.Text;

        public void AddToBasket(string item)
        {
            IWebElement itemToAdd = _seleniumDriver.FindElement(By.Id($"add-to-cart-sauce-labs-{item}"));
            itemToAdd.Click();
        }

        public void RemoveFromBasket(string item)
        {
            IWebElement itemToRemove = _seleniumDriver.FindElement(By.Id($"remove-sauce-labs-{item}"));
            itemToRemove.Click();
        }
        public IWebElement GetShoppingCart => _shoppingCart;
        public IReadOnlyList<IWebElement> CartItems => _items;
        public void ClickBasketLink() => _shoppingCartLink.Click();
        public void AddItemToCart(string item)
        {
            string itemID = $"add-to-cart-sauce-labs-{item}";
            IWebElement itemToAdd = _seleniumDriver.FindElement(By.Id(itemID));
            itemToAdd.Click();
        }
    }
}
