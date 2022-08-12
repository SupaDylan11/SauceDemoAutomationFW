using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework.tests
{
    public class SD_Products_Tests
    {
        private SD_Website<ChromeDriver> SD_Website = new();

        [Test]
        public void GivenIAmOnTheProductsPage_WhenIClickTheBackpackItem_ThenIShouldLandOnTheBackpackProductPage()
        {
            //Sign In
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();

            //Click Backpack Link
            SD_Website.SD_ProductsPage.ClickBackpackLink();

            //Check title is backpack page title
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory-item.html?id=4"));
        }

        [Test]
        public void GivenIAmOnTheProductsPage_WhenISelectTheFilterDropdown_AndISelectTheZAFilter_ThenTheFirstItemShouldBeTshirtred()
        {
            //Sign In
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();

            //Click Filter link and filter ZA
            SD_Website.SD_ProductsPage.ClickFilterLink();
            Thread.Sleep(3000);
            SD_Website.SD_ProductsPage.ClickFilterZA();

            //Check first item includes (red)
            Assert.That(SD_Website.SD_ProductsPage.FirstItemName(), Does.Contain("(red)").IgnoreCase);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
        }

        [Test]
        public void GivenIAmOnTheBasketsPage_WhenICLickTheAddToCartButton_TheItemShouldBeAdded()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();

            IReadOnlyList<IWebElement> cartItemsB4 = SD_Website.SD_BasketPage.CartItems;
            int countB4 = cartItemsB4.Count;

            SD_Website.SD_BasketPage.AddToBasket.Click();

            IReadOnlyList<IWebElement> cartItemsAfter = SD_Website.SD_BasketPage.CartItems;
            int countAfter = cartItemsAfter.Count;

            Assert.That(countB4 < countAfter, Is.True);
        }

        [Test]
        public void GivenIAmOnTheBasketsPage_WhenICLickTheRemoveButton_TheItemShouldBeRemovedFromCart()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();

            SD_Website.SD_BasketPage.AddToBasket.Click();

            IReadOnlyList<IWebElement> cartItemsB4 = SD_Website.SD_BasketPage.CartItems;
            int countB4 = cartItemsB4.Count;

            SD_Website.SD_BasketPage.RemoveFromBasket.Click();

            IReadOnlyList<IWebElement> cartItemsAfter = SD_Website.SD_BasketPage.CartItems;
            int countAfter = cartItemsAfter.Count;

            Assert.That(countB4 > countAfter, Is.True);
        }
    }
}
