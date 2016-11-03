using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAWorks.Specs.Utility
{
    class BrowserOperations
    {

        public static void WaittillBrowserLoads()
        {
            Thread.Sleep(500);
            int i = 30;
            do{
                IWebElement body = GlobalSettings.driver.FindElement(By.TagName("body"));
                if(body.Enabled)
                {
                    return;
                }
                Thread.Sleep(100);
                i--;
            }while(i!=0);

        
        }
    }
}
