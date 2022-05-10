using NUnit.Framework;
using OpenQA.Selenium;

namespace IgnasBaigiamasis.Page
{
    class OBDelevenVehicles : BasePage
    {
        public OBDelevenVehicles(IWebDriver webDriver) : base(webDriver) { }
        private const string PageAddress = "https://obdeleven.com/en/";

        private IWebElement _openSupported => Driver.FindElement(By.ClassName("module_supportedvehicles-main"));
        private IWebElement _selectMake => Driver.FindElement(By.CssSelector("#filterBlock1 > span:nth-child(1)"));
        private IWebElement _selectModel => Driver.FindElement(By.CssSelector("#filterBlock2 > div > div.select > ul:nth-child(5) > span"));
        private IWebElement _selectYear => Driver.FindElement(By.CssSelector("#filterBlock2 > div > div.select > ul:nth-child(5) > li:nth-child(2)"));
        private IWebElement _selectBody => Driver.FindElement(By.CssSelector("#filterBlock3 > div:nth-child(1)"));
        private IWebElement _selectType => Driver.FindElement(By.CssSelector("#filterBlock4 > span:nth-child(1)"));
        private IWebElement _openDiagnostics => Driver.FindElement(By.CssSelector("#contentBlock1 > div:nth-child(1) > div.features"));
        private IWebElement _confirmSelection => Driver.FindElement(By.CssSelector("#contentBlock1 > div:nth-child(1) > div.content > p"));
        private IWebElement _openLanguage => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.xprtblocklanguagesselector.header_block.languages_block > div"));
        private IWebElement _selectLanguage => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.xprtblocklanguagesselector.header_block.languages_block > ul > li:nth-child(4) > a"));
        private IWebElement _confirmLanguage => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.xprt_mega_menu_area.clearfix.sticky > div > ul > li.module_supportedvehicles-main > a"));


        public OBDelevenVehicles NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;

            return this;
        }

        public OBDelevenVehicles SelectSupported()
        {
            _openSupported.Click();

            return this;
        }

        public OBDelevenVehicles SelectCar()
        {
            _selectMake.Click();
            GetWait(5).Until(d => _selectMake.Displayed);

            return this;
        }
        public OBDelevenVehicles SelectModel()
        {
            _selectModel.Click();

            return this;
        }
        public OBDelevenVehicles SelectYear()
        {
            _selectYear.Click();

            return this;
        }
        public OBDelevenVehicles SelectBody()
        {
            _selectBody.Click();

            return this;
        }
        public OBDelevenVehicles SelectType()
        {
            _selectType.Click();

            return this;
        }

        public OBDelevenVehicles OpenDiagnostics()
        {
            _openDiagnostics.Click();

            return this;
        }
        public OBDelevenVehicles OpenLanguage()
        {
            _openLanguage.Click();

            return this;
        }
        public OBDelevenVehicles SelectLanguage()
        {
            _selectLanguage.Click();

            return this;
        }
        public OBDelevenVehicles ConfirmLanguage(string deutch)
        {
            Assert.AreEqual(deutch, _confirmLanguage.Text, "Text incorrect or was not sent");

            return this;
        }
    }
}
