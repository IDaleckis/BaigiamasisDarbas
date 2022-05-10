using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenCookieTest : BaseTest
    {
        [Test]
        public void CookieAccept()
        {
            _obdelevenCookie.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
        }
    }
}