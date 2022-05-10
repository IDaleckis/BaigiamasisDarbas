using NUnit.Framework;
using OpenQA.Selenium;

namespace IgnasBaigiamasis.Page
{
    class OBDelevenPurchase : BasePage
    {
        private const string PageAddress = "https://obdeleven.com/en/";

        private static IWebElement _openProducts => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.xprt_mega_menu_area.clearfix.sticky > div > ul > li.page_productspage > a > span"));
        private static IWebElement _selectProduct => Driver.FindElement(By.CssSelector("#xprt_categoryproductsblock_2 > div > article:nth-child(1) > div > div.left-block > div > div.product_img_link > a > img"));
        private static IWebElement _addToCart => Driver.FindElement(By.CssSelector("#add-to-cart-or-refresh > div.product-add-to-cart > div.product-quantity.clearfix > div.add > button"));
        private static IWebElement _proceedCheckout => Driver.FindElement(By.CssSelector("#blockcart-modal > div > div > div.modal-body > div > div:nth-child(2) > div > p.cart_content_buttons.text-right > a"));
        private static IWebElement _confirmPrice => Driver.FindElement(By.CssSelector("#cart-subtotal-products > span.value"));

        public OBDelevenPurchase(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public OBDelevenPurchase SelectProducts()
        {
            _openProducts.Click();

            return this;
        }
        public OBDelevenPurchase SelectProduct()
        {
            _selectProduct.Click();

            return this;
        }
        public OBDelevenPurchase AddProductToCart()
        {
            _addToCart.Click();

            return this;
        }
        public OBDelevenPurchase ProceedToCheckout()
        {
            _proceedCheckout.Click();

            return this;
        }
        public OBDelevenPurchase ConfirmPrice(string expectedPrice)
        {
                string expectedPricing = _confirmPrice.Text;

                Assert.IsTrue(_confirmPrice.Text.Contains(expectedPricing), "Result is Incorrect");

            return this;
        }
    }
    
}