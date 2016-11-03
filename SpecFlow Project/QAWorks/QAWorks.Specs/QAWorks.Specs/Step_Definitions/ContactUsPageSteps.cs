using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAWorks.Specs.PageObjectsAndActions;
using QAWorks.Specs.Utility;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QAWorks.Specs.Step_Definitions
{
    public class ContactDetails
    {
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; } 
    }

   

    [Binding]
    public class ContactUsPageSteps : BaseDefinition
    {
        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            MainMenuNavigation.NavigateTo(MainMenuNavigation.Menu.Contact);
            
        }
        
        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            var contactdetails = table.CreateInstance<ContactDetails>();
            ContactUsPage.entercontactDetails(contactdetails.name, contactdetails.email, contactdetails.message);
            ContactUsPage.sendContactInfo();
            Assert.IsTrue(ContactUsPage.verifysubmission());
        }
    }
}
