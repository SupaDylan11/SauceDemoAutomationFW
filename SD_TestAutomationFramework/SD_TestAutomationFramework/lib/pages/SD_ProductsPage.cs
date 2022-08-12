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
        private IWebElement _firstItem => _seleniumDriver.FindElement(By.ClassName("inventory_list")).FindElement(By.XPath("/*[1]"));
        private IWebElement _itemList => _seleniumDriver.FindElement(By.ClassName("inventory_list"));

        public SD_ProductsPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickBackpackLink() => _backpackLink.Click();
        public void SelectItem(int itemNo) => _itemList.FindElement(By.XPath($"//div[{itemNo}]/div/a/img")).Click();
        public void ClickFilterLink() => _filterLink.Click();
        public void ClickFilterZA() => _filterZA.Click();
        public string FirstItemName() => _firstItem.Text;
    }
}
