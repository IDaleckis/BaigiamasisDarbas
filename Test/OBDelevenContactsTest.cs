using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenContactsTest : BaseTest
    {
        [Test]
        public void OBDelevenContactsMessageTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenStage.OpenContacts();
            _obdelevenStage.EnterContactsEmail("testinisemail@gmail.com");
            _obdelevenStage.EnterContactsText("testuoju 123");
            _obdelevenStage.SelectFromDropDownByText("Other");
            _obdelevenStage.ConfirmRobot();
            _obdelevenStage.ClickSendContacts();
            _obdelevenStage.ConfirmIfSentContacts("Your message has been successfully sent to our team.");

        }
    }
}
