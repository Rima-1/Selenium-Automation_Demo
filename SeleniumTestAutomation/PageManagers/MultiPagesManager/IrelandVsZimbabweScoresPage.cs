using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class IrelandVsZimbabweScoresPage : BaseDriver
    {
        public IrelandVsZimbabweScoresPage(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }
        private By _irelandVsZimbabweScores = By.XPath("//span[contains(text(),'Ireland vs Zimbabwe, 1st T20I')]");
        public void OpenIrelandVsZimbabweScoresPage()
        {
            ClickElement(ChromeDriver, _irelandVsZimbabweScores);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[5]);
            test.Log(Status.Pass, "Ireland Vs Zimbabwe Scores option is clicked and scores are viewed successfully.");
        }
    }
}
