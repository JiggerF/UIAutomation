using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace XeroUITests.Page
{
    public class SalesPage
    {
        private InvoiceScreen _is = new InvoiceScreen();
        
        public InvoiceScreen InvoiceScreen
        {
            get
            {
                return _is;
            }
        }

        public void CreateRepeatingInvoice()
        {
            //var dropdownNew = Driver.Instance.FindElement(By.Id("ext-gen1076"));
            Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            var dropdownNew = Driver.Instance.FindElement(By.CssSelector("#ext-gen1037 > span"));
            dropdownNew.Click();

            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            //wait for the email inputfield to be in focused before we start typing
            wait.Until(d => d.SwitchTo().ActiveElement().FindElement(By.LinkText("Repeating invoice")));
            var repeatInvoiceLink = Driver.Instance.FindElement(By.LinkText("Repeating invoice"));
            repeatInvoiceLink.Click(); 
        }

        public bool IsAt 
        {
            get
            {
                var salesText = Driver.Instance.FindElement(By.Id("page_title"));
                return salesText.Text == "Sales";
            }
        }
    }
}
