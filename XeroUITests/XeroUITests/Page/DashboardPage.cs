using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace XeroUITests
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                try
                {
                    var checkTitle = Driver.Instance.FindElement(By.Id("title"));
                    return checkTitle.Text == "Demo NZ";
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public static void GotoSalesPage()
        {
            var clickSalesLink = Driver.Instance.FindElement(By.LinkText("Go to Sales ›"));
            clickSalesLink.Click();
        }
    }
}
