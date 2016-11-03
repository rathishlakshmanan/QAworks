using QAWorks.Specs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QAWorks.Specs.Step_Definitions
{
    [Binding]
    public class BaseDefinition
    {

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Driver.LoadChrome("http://www.qaworks.com");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.QuitDriver();
        }
    }
}
