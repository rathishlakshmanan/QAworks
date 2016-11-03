using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;


namespace QAWorks.Specs.Utility
{
    class Driver
    {
    
        public static void LoadIE(String URL)
        {
            var options = new InternetExplorerOptions()
            {
                InitialBrowserUrl = URL,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            var loc = Util.getlocation("iedriverlocation");
            var driver = new InternetExplorerDriver(@loc, options);
            driver.Navigate();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
            GlobalSettings.driver = driver;
        }


        public static void LoadChrome(String URL)
        {
            var loc = Util.getlocation("chromedriverlocation");
            IWebDriver driver = new ChromeDriver(@loc);
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
            GlobalSettings.driver = driver;
        }



        public static void QuitDriver()
        {
           //GlobalSettings.driver.Close();
           GlobalSettings.driver.Quit();
        }


    }
}
