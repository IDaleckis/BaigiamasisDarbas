using NUnit.Framework;

namespace IgnasBaigiamasis.Test
{
    class OBDelevenPurchaseTest : BaseTest
    {
        [Test]
        public void PurchaseTest()
        {
            _obdelevenVehicles.NavigateToDefaultPage();
            _obdelevenCookie.ClickCookieAcceptButton();
            _obdelevenPurchase.SelectProducts();
            _obdelevenPurchase.SelectProduct();
            _obdelevenPurchase.AddProductToCart();
            _obdelevenPurchase.ProceedToCheckout();
            _obdelevenPurchase.ConfirmPrice("€49.58");

        }
    }
}
