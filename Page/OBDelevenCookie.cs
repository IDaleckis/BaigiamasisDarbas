using OpenQA.Selenium;

namespace IgnasBaigiamasis.Page
{
    class OBDelevenCookie : BasePage
    {
        private const string PageAddress = "https://obdeleven.com/";

        private IWebElement _cookieAcceptButton => Driver.FindElement(By.ClassName("hi-cookie-btn"));


        public OBDelevenCookie(IWebDriver webDriver) : base(webDriver) { }

        public OBDelevenCookie NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;

            return this;
        }

        public OBDelevenCookie ClickCookieAcceptButton()
        {
            _cookieAcceptButton.Click();

            return this;
        }
    }
}