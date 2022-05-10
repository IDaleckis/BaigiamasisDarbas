using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class LivechatTest : BaseTest
    {
        [Test]
        public void LiveChatTest()
        {
            _obdelevenCookie.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenStage.OpenLiveChat();
            _obdelevenStage.NewChat();
            _obdelevenStage.EnterText("Testinimas");
            _obdelevenStage.SendText();
            _obdelevenStage.ConfirmIfTextSent("Testinimas");
            _obdelevenStage.CloseLiveChat();

        }
    }
}