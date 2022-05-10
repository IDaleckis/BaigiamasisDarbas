using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class EmailSubscriptionTest : BaseTest
    {
        [Test]
        public void TestEmailSubscription()
            {
                _obdelevenCookie.NavigateToDefaultPage();
                _obdelevenCookie.ClickCookieAcceptButton();
                _obdelevenStage.InsertEmail("ignasdaleckis@gmail.com");
                _obdelevenStage.ClickSubscribeButton();
                _obdelevenStage.CheckIfSuccess("A verification email has been sent. Please check your inbox.");
            }
        }
    }