using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenPasswordChangeTest : BaseTest
    {
        [Test]
        public void PasswordChangeTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.ClickLoginButton();
            _obdelevenStage.EnterEmail("testtest321@gmail.com");
            _obdelevenStage.EnterPass("testinu321");
            _obdelevenStage.InitiateLogin();
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.MyAccount();
            _obdelevenStage.MyInfo();
            _obdelevenStage.EnterOldPass("testinu321");
            _obdelevenStage.EnterNewPass("naujaspass");
            _obdelevenStage.AcceptTerms();
            _obdelevenStage.ClickSave();
            _obdelevenStage.ConfirmChange("Information successfully updated.");
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.LogOut();
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.ClickLoginButton();
            _obdelevenStage.EnterEmail("testtest321@gmail.com");
            _obdelevenStage.EnterPass("naujaspass");
            _obdelevenStage.InitiateLogin();
            _obdelevenStage.ClickUserButton();
            _obdelevenStage.MyAccount();
            _obdelevenStage.MyInfo();
            _obdelevenStage.EnterOldPass("naujaspass");
            _obdelevenStage.EnterNewPass("testinu321");
            _obdelevenStage.AcceptTerms();
            _obdelevenStage.ClickSave();
            _obdelevenStage.ConfirmChange("Information successfully updated.");
        }
    }
}
