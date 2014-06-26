using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XeroUITests
{
    public class Driver
    {
        public static IWebDriver Instance;
        public static void Init()
        {
            var driverPath = System.IO.Directory.GetCurrentDirectory();
            Instance = new ChromeDriver(driverPath);
            //Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
        }

        public static void Close()
        {
           Driver.Instance.Close();
           Driver.Instance.Quit();
        }
    }
}
