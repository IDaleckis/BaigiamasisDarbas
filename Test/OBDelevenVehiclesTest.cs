using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenVehiclesTest : BaseTest
    {
        [Test]
        public void SupportedVehiclesTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenVehicles.SelectSupported();
            _obdelevenVehicles.SelectCar();
            _obdelevenVehicles.SelectModel();
            _obdelevenVehicles.SelectYear();
            _obdelevenVehicles.SelectBody();
            _obdelevenVehicles.SelectType();
            _obdelevenVehicles.OpenDiagnostics();
        }
    }
}