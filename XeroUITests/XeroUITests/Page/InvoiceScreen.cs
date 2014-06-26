using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace XeroUITests.Page
{
    public class InvoiceScreen
    {
        public bool IsAt
        {
            get
            {
                var screen = Driver.Instance.FindElement(By.ClassName("w"));
                var h1 = screen.FindElement(By.TagName("h1"));
                return h1.Text == "New Repeating Invoice";
            }
        }
    }
}
