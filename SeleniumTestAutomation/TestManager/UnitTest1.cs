using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[assembly: Parallelize(Workers =4, Scope =ExecutionScope.MethodLevel)]

namespace SeleniumTestAutomation
{
    [TestClass]
    public class UnitTest1:BaseUnitTest
    {
        public TestContext testContext;
        public ExtentReports getrep;
        /// <summary>
        /// Test Product Search in Automation Page.
        /// </summary>
        [TestMethod]
        public void TestProducts()
        { 
            getrep= ExtentReportInitialize(testContext);
            test = getrep.CreateTest("Test Product Search in Automation Page.");
            Products products = new Products(ChromeDriver,test);
            products.ClickProducts();
            Assert.IsTrue(products.ConfirmTitleofProductsTab());
            test.Log(Status.Pass, "Heading matched successfully.");
            products.EnterTextToSearch("Weidmuller");
            products.HitSearchButton();
            Assert.IsTrue(products.CheckIfSearchResultsHaveSearchKey("Weidmuller"));
        }
        /// <summary>
        /// Test InTech Magazine and Digital Issue Pages.
        /// </summary>
        [TestMethod]
        public void TestInTechMagazine()
        {
            getrep = ExtentReportInitialize(testContext);
            test = getrep.CreateTest("Test InTech Magazine and Digital Issue Pages.");
            InTechMagazinePage inTechMagazine = new InTechMagazinePage(ChromeDriver,test);
            inTechMagazine.ClickInTechMagazineLink();
            inTechMagazine.AcceptCookiesOfInTechMagazinePage();
            inTechMagazine.ReadDigitalIssue();
            Assert.IsTrue(inTechMagazine.SkipTutorial());

        }
        

    }
}
