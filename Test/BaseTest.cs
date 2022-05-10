using NUnit.Framework;
using OpenQA.Selenium;
using IgnasBaigiamasis.Page;
using NUnit.Framework.Interfaces;
using IgnasBaigiamasis.Tools;
using IgnasBaigiamasis.Drivers;

namespace IgnasBaigiamasis.Test
{
    class BaseTest
    {
        //Kill all chrome instances using CMD: taskkill /F /IM chromedriver.exe /T

        protected static IWebDriver Driver;

        public static OBDelevenCookie _obdelevenCookie;
        public static OBDelevenStage _obdelevenStage;
        public static OBDelevenVehicles _obdelevenVehicles;
        public static OBDelevenPurchase _obdelevenPurchase;


        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
;
            _obdelevenCookie = new OBDelevenCookie(Driver);
            _obdelevenStage = new OBDelevenStage(Driver);
            _obdelevenVehicles = new OBDelevenVehicles(Driver);
            _obdelevenPurchase = new OBDelevenPurchase(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }

    }
}