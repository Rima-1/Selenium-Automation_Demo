using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumTestAutomation
{
    public class YahooPage:BaseDriver
    {
        public YahooPage(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }
        public void OpenYahooPage()
        {
            Actions action = new Actions(ChromeDriver); action.KeyDown(Keys.Control).SendKeys("t").Build().Perform(); 
            ChromeDriver.Navigate().GoToUrl("https://in.yahoo.com/?p=us");
        }
        public bool IsYahooPageOpened()
        {
            return ChromeDriver.FindElement(By.XPath("//span[contains(@class,'icon cricket')]")).Displayed;
        }
    }
}
