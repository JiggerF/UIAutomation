using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeroUITests;
using XeroUITests.Page;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Init();
        }

        [TestMethod]
        public void CreateRepeatingInvoice()
        {
            //Login Flow
            LoginPage.Goto();
            LoginPage.EmailAddress("jiggerfantonial@yahoo.com");
            LoginPage.Password("p@ssword1");
            LoginPage.Login();

            //Check if we arrived at the Dashboard page
            Assert.IsTrue(DashboardPage.IsAt, "Error finding the Dashboard page!");

            //Navigate to Sales Page
            DashboardPage.GotoSalesPage();
            Assert.IsTrue(Accounts.SalesPage.IsAt, "Error finding the Sales page!");

            //Navigate to the Repeating Invoice Page
            Accounts.SalesPage.CreateRepeatingInvoice();
            Assert.IsTrue(Accounts.SalesPage.InvoiceScreen.IsAt, "Error finding the New Repeating invoice page!");
        }


        [TestCleanup]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
