using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenSupportedLanguageTest : BaseTest
    {
        [Test]
        public void LanguageTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenVehicles.SelectSupported();
            _obdelevenVehicles.OpenLanguage();
            _obdelevenVehicles.SelectLanguage();
            _obdelevenVehicles.ConfirmLanguage("UNTERSTÜTZTE MODELLE");
        }
    }
}
