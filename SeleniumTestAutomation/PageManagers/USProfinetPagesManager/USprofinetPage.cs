using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;

namespace SeleniumTestAutomation
{
    public class USprofinetPage:BaseDriver
    {
        public USprofinetPage(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }
        private By _usProfinetIcon = By.ClassName("headerMain-searchSponsorImage");
        private String _actualHeading = "WHITE PAPERS";
        public void ClickUSprofinetIcon()
        {
            ClickElement(ChromeDriver, _usProfinetIcon);
            test.Log(Status.Pass, "Profinet Icon is clicked successfully.");
        }

        public void WhitepapersResources()
        {
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[1]);
            test.Log(Status.Info, "Switching to window to hover over Resources. Dropdown pops up.");
            new ProfibusProfinet(ChromeDriver,test).HoveringOverResources();
            new ProfibusProfinet(ChromeDriver,test).ClickelementfromResourcesDropdown();
            test.Log(Status.Pass, _actualHeading+ " selected successfully from the dropdown.");
        }

        public bool ConfirmTitleofPage()
        {
            test.Log(Status.Info, "Check if Heading matches with selected option from Resource Dropdown");
            bool checkTitle= new ProfibusProfinet(ChromeDriver,test).ConfirmTitleOfSelectedElement();
            string screenshotPath = ScreenshotTaker.Capture(ChromeDriver, "ConfirmTitle");
            test.AddScreenCaptureFromPath(screenshotPath);
            return checkTitle;
        }

        public void GetTextFromCategories(string searchcategory)
        {
            new ProfibusProfinet(ChromeDriver,test).GetTextfromCategoriesDropdown(searchcategory);
            test.Log(Status.Pass, searchcategory + " selected successfully.");
        }
        
        public bool CheckIfTitleChanges(String searchcategory)
        {
            test.Log(Status.Info, "Check if Title changes with given SearchCategory");
            bool confirmTitle = new ProfibusProfinet(ChromeDriver,test).ConfirmIfTitleChanges(searchcategory);
            string screenshotPath = ScreenshotTaker.Capture(ChromeDriver, "checkIfTitleChanges");
            test.AddScreenCaptureFromPath(screenshotPath);
            return confirmTitle;
            }
    }
}

