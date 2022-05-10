using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenLoginTest : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.ClickLoginButton();
            _obdelevenStage.EnterEmail("testtest321@gmail.com");
            _obdelevenStage.EnterPass("testinu321");
            _obdelevenStage.InitiateLogin();
            _obdelevenStage.ConfirmLogin("Sign out");

        }
    }
}
