using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using QAWorks.Specs.Utility;

namespace QAWorks.Specs.PageObjectsAndActions
{
    class ContactUsPage
    {
           private static By nameTextObject = By.XPath("//input[contains(@name,'NameBox')]");
           private static By emailTextObject = By.XPath("//input[contains(@name,'EmailBox')]");
           private static By mesageTextObject = By.XPath("//textarea[contains(@name,'MessageBox')]"); 
           private static By sendButtonObject = By.XPath("//input[contains(@name,'SendButton')]"); 

        public static void entercontactDetails(String name,String email,String message)
        {
            GlobalSettings.driver.FindElement(nameTextObject).SendKeys(name);
            GlobalSettings.driver.FindElement(emailTextObject).SendKeys(email);
            GlobalSettings.driver.FindElement(mesageTextObject).SendKeys(message);
        }


        public static void sendContactInfo()
        {
            GlobalSettings.driver.FindElement(sendButtonObject).Click();
            BrowserOperations.WaittillBrowserLoads();
        }

        public static Boolean verifysubmission()
        {
            if (GlobalSettings.driver.FindElements(nameTextObject).Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
