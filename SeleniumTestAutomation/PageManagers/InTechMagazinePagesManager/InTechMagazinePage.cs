using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumTestAutomation
{
    public class InTechMagazinePage:BaseDriver
    {
        public InTechMagazinePage(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _inTechMagazineLink = By.LinkText("InTech Magazine");
        
        public void ClickInTechMagazineLink()
        {
            ClickElement(ChromeDriver, _inTechMagazineLink);
            test.Log(Status.Pass, "InTech Magazine link is clicked successfully.");       
        }
        public void AcceptCookiesOfInTechMagazinePage()
        {
            new InTechMagazine(ChromeDriver,test).AcceptCookies();
            test.Log(Status.Pass, "Cookies accepted successfully.");
        }
        public void ReadDigitalIssue()
        {
            test.Log(Status.Info, "Opening Digital Issue page");
            test.Log(Status.Info, "Press CTRL+DownArrowKey(from keyboard)+Click on link");
            //To click the link and open in a new tab/window
            new InTechMagazine(ChromeDriver,test).DigitalIssueOption();
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[2]);
            test.Log(Status.Pass, "Digital Issue Page opened successfully in a new window.");
        }
        public bool SkipTutorial()
        {
            test.Log(Status.Info, "Test to Skip Tutorial and read Digital Issue");
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            test.Log(Status.Info, "Switching to frame to skip tutorial");
            new DigitalIssuePage(ChromeDriver,test).SwitchToframeInPage();
            test.Log(Status.Info, "Click on skip button in frame to skip tutorial");
            new DigitalIssuePage(ChromeDriver,test).SkipTutorial();
            Thread.Sleep(9000);
            string screenshotPath = ScreenshotTaker.Capture(ChromeDriver, "SkipTutorial");
            test.Log(Status.Pass, "Tutorial is successfully skipped and Digital Issue is visible to read.");
            test.AddScreenCaptureFromPath(screenshotPath);
            return ChromeDriver.FindElement(By.XPath("/html/body/iframe")).Displayed;
        }
    }
}
