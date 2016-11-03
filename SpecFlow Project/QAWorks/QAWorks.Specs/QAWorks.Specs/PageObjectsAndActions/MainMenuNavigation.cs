using OpenQA.Selenium;
using QAWorks.Specs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWorks.Specs.PageObjectsAndActions
{
    class MainMenuNavigation
    {
        public enum Menu
        {
            Home,
            Services,
            Works,
            Technology,
            Prices,
            News,
            About,
            Careers,
            Contact
        }

        public static void NavigateTo(Menu section)
        {
            GlobalSettings.driver.FindElement(By.LinkText(section.ToString())).Click();
            BrowserOperations.WaittillBrowserLoads();
        }
    }
}
