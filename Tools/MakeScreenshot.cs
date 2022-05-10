using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IgnasBaigiamasis.Page;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.Extensions;

namespace IgnasBaigiamasis.Tools
{
    class MakeScreenshot
    {
        public static void TakeScreenshot(IWebDriver webDriver)
        {
            Screenshot screenshot = webDriver.TakeScreenshot();

            string screenshotDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            string screenshotFolder = Path.Combine(screenshotDirectory, "screenshot");
            Directory.CreateDirectory(screenshotFolder);

            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
            string screenshotPath = Path.Combine(screenshotFolder, screenshotName);

            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }
    }
}