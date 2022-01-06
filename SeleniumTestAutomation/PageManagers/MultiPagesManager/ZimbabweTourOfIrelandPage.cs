using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace SeleniumTestAutomation
{
    public class ZimbabweTourOfIrelandPage : BaseDriver
    {
        public ZimbabweTourOfIrelandPage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _zimbabweTourOfIreland = By.XPath("//span[contains(@class,'text-black text-bold')][contains(text(),'Zimbabwe tour of Ireland, 2021')]");
        public void OpenzimbabweTourOfIrelandPage()
        {
            ClickElement(ChromeDriver, _zimbabweTourOfIreland);
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[4]);
            test.Log(Status.Pass, "Zimbabwe Tour Of Ireland 2021 tab is clicked and Zimbabwe Tour Of Ireland Page is opened successfully.");
        }
    }
}
