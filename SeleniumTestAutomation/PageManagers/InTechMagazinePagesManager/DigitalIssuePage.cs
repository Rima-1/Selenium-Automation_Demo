using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumTestAutomation
{
    public class DigitalIssuePage:BaseDriver
    {
        public DigitalIssuePage(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }
        private By _frameInPage = By.XPath("/html/body/iframe");
        private By _tutorialSkip = By.Id("tutorialButtonSkip");

        public void SwitchToframeInPage() => ChromeDriver.SwitchTo().Frame(ChromeDriver.FindElement(_frameInPage));
        public void SkipTutorial() => ClickElement(ChromeDriver, _tutorialSkip);
    }
}
