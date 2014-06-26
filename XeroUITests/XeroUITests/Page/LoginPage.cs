using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace XeroUITests
{
    public class LoginPage
    {
        private static string _emailAddress;
        private static string _password;

        public static void EmailAddress(string email)
        {
            _emailAddress = email;
        }

        public static void Password(string password)
        {
            _password = password;
        }

        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl("https://login.xero.com/");
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));  
            //wait for the email inputfield to be in focused before we start typing
            wait.Until(d => d.SwitchTo().ActiveElement().FindElement(By.Id("email")));
        }
   
        public static void Login()
        {
            var inputEmail = Driver.Instance.FindElement(By.Id("email"));
            inputEmail.SendKeys(_emailAddress);

            //Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            var inputPassword = Driver.Instance.FindElement(By.Id("password"));
            inputPassword.Click();
            //slows down the password inputkeys
            if (inputPassword.Displayed)
            {
                foreach (char str in _password)
                {
                    inputPassword.SendKeys(Convert.ToString(str));
                    System.Threading.Thread.Sleep(200);
                }
            }
           
            var submitButton = Driver.Instance.FindElement(By.Id("submitButton"));
            submitButton.Submit();
        }

       
    }
}
