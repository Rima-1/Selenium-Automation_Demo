using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestAutomation
{
    public class ScreenshotTaker
    {
        public static string Capture(IWebDriver chromeDriver, string screenshotName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)chromeDriver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Screenshots\\" + screenshotName + ".png";
            screenshot.SaveAsFile(reportPath, ScreenshotImageFormat.Png);
            return reportPath;
        }
    }
}
