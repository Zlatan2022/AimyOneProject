using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aimy_testing_automation.Pages;

namespace aimy_testing_automation.Utilities
{
    [TestFixture]
    public class CommonDriver
    {

        public static IWebDriver driver;
       

        public CommonDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
        }
        [BeforeScenario]
        public void goTo()
        {
            
            // If there isn't already an active driver session, create a new one
            if (driver == null || ((IJavaScriptExecutor)driver).ExecuteScript("return window.closed").ToString() == "true")
            {
                driver = new ChromeDriver();

            }

            // Navigate to the desired URL
            driver.Navigate().GoToUrl("https://uat-app.aimyone.com");
            driver.Manage().Window.Maximize();

           

        }
            
        [AfterScenario]
        public void CleanUp()
        {
            
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred while closing the browser: '{ex.Message}'");
            }
        }
      

    }


}



