using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class CricketArchivesPage:BaseDriver
    {
        public CricketArchivesPage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _archives = By.LinkText("Archives");
        public void OpenCricketArchivesPage()
        {
            ClickElement(ChromeDriver, _archives);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[3]);
            test.Log(Status.Pass, "Archives tab is clicked and Cricket Archives Page is opened successfully.");
        }
    }
}
