using AventStack.ExtentReports;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumTestAutomation
{
    public class AutomationHomePage:BaseDriver
    {
        public AutomationHomePage(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }


        public void OpenURL()
        {
            ChromeDriver.Navigate().GoToUrl("https://www.automation.com/");
        }

        public void AcceptCookies()
        {
            ChromeDriver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            ChromeDriver.FindElement(By.CssSelector("input[name=allow]")).Click();
        }
    }
}
