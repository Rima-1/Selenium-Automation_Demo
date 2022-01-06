using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class TeamIndiaResultsPage:BaseDriver
    {
        public TeamIndiaResultsPage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _teamIndiaResults = By.LinkText("India");
        public void OpenTeamIndiaResultsPage()
        {
            test.Log(Status.Info, "Check if India tab is clickable.");
            ClickElement(ChromeDriver, _teamIndiaResults);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[7]);
        }
        public bool IsTeamIndiaResultsPageOpened()
        {
            return ChromeDriver.FindElement(By.LinkText("Home")).Displayed;
        }
    }
}
