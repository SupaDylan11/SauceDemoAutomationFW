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
    public class SD_BasketPage_Tests
    {
        //private SD_Website<ChromeDriver> SD_Website = new();

        //private string user = AppConfigReader.User;
        //private string passwd = AppConfigReader.Password;

        //[Test]
        //public void GivenIAmOnTheBasketsPage_WhenIClickContinueShopping_IShouldGoToProductsPage()
        //{
        //    SD_Website.SD_SignInPage.VisitSignInPage();
        //    SD_Website.SD_SignInPage.InputUserName(user);
        //    SD_Website.SD_SignInPage.InputPassword(passwd);
        //    SD_Website.SD_SignInPage.clickSignIn();
        //    //Thread.Sleep(3000);
        //    SD_Website.SD_ProductsPage.ClickBasketLink();
        //    //Thread.Sleep(3000);

        //    Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));

        //    SD_Website.SD_BasketPage.ContinueShopping();

        //    Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        //}

        //[Test]
        //public void GivenIAmOnTheBasketsPage_WhenIClickCheckout_IShouldGoToCheckoutPage()
        //{
        //    SD_Website.SD_SignInPage.VisitSignInPage();
        //    SD_Website.SD_SignInPage.InputUserName(user);
        //    SD_Website.SD_SignInPage.InputPassword(passwd);
        //    SD_Website.SD_SignInPage.clickSignIn();
        //    //Thread.Sleep(3000);
        //    SD_Website.SD_ProductsPage.ClickBasketLink();

        //    SD_Website.SD_BasketPage.GoToCheckout();

        //    Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        //}

        //[Test]
        //public void GivenIAmOnTheBasketsPage_WhenIRemoveAnItem_ItShouldBeRemovedFromBasket()
        //{
        //    string product = "sauce-labs-onesie";

        //    SD_Website.SD_SignInPage.VisitSignInPage();
        //    SD_Website.SD_SignInPage.InputUserName(user);
        //    SD_Website.SD_SignInPage.InputPassword(passwd);
        //    SD_Website.SD_SignInPage.clickSignIn();
        //    Thread.Sleep(3000);

        //    SD_Website.SD_ProductsPage.AddItemToCart(product);
        //    SD_Website.SD_ProductsPage.ClickBasketLink();
        //    Thread.Sleep(3000);
            
        //    IWebElement itemInBasket = SD_Website.SD_BasketPage.ItemInBasket(product);
        //    Assert.That(itemInBasket, Is.Not.Null);

        //    SD_Website.SD_BasketPage.RemoveItemFromCart(product);

        //    IWebElement itemInBasket2 = SD_Website.SD_BasketPage.ItemInBasket(product);
        //    Assert.That(itemInBasket2, Is.Null);
        //}

        //[OneTimeTearDown]
        //public void CleanUp()
        //{
        //    SD_Website.SeleniumDriver.Quit();
        //}
    }
}
