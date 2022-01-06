using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class CricketPage:BaseDriver
    {
        public CricketPage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _cricketTab = By.XPath("//span[contains(@class,'icon cricket')]");
        private By _crickbuzzLink = By.LinkText("IPL 2021 Cricket Score, Schedule, Latest News, Stats & Videos ...");
        public void OpenCricketPage()
        {
            ClickElement(ChromeDriver, _cricketTab);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[1]);
            test.Log(Status.Pass, "Cricket tab is clicked and Cricket Page is opened successfully.");
        }
        public void ClickOnLink()
        {
            ClickElement(ChromeDriver, _crickbuzzLink);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[2]);
            test.Log(Status.Pass, "CrickBuzz link is clicked and IPL Cricket Score Page is opened successfully.");
        }
    }
}
