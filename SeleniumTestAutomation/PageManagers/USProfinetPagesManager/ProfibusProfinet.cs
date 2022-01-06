using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace SeleniumTestAutomation
{
    public class ProfibusProfinet:BaseDriver
    {
        public ProfibusProfinet(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _resources = By.Id("menu-item-20004");
        private By _whitepapers = By.Id("menu-item-256");
        private String _actualHeading = "WHITE PAPERS";
        private By _changingTitle = By.ClassName("fl-heading-text");
        private By _categories = By.Id("resource_cat");
        private By _categoriesDropdown = By.XPath("//select[@name='resource_cat']");
        public void HoveringOverResources() => HoverOverElement(ChromeDriver, _resources);
        public void ClickelementfromResourcesDropdown() => ClickElement(ChromeDriver, _whitepapers);
        public bool ConfirmTitleOfSelectedElement()
        {
           return ConfirmTitle(ChromeDriver, _changingTitle, _actualHeading);
        }

        public void GetTextfromCategoriesDropdown(string searchCategory)
        {
                ClickElement(ChromeDriver, _categories);
                SelectElemntFromdropdown(ChromeDriver, _categoriesDropdown, searchCategory);
        }
        public bool ConfirmIfTitleChanges(string searchCategory)
        {
            return ConfirmTitle(ChromeDriver, _changingTitle, searchCategory);
        }
    }
}
