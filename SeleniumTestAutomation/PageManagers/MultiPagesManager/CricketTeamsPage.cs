using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class CricketTeamsPage:BaseDriver
    {
        public CricketTeamsPage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _cricketTeams = By.LinkText("Teams");
        public void OpenCricketTeamsPage()
        {
            ClickElement(ChromeDriver, _cricketTeams);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[6]);
            test.Log(Status.Pass, "Teams tab is clicked and Cricket Teams Page is opened successfully.");
        }
    }
}
