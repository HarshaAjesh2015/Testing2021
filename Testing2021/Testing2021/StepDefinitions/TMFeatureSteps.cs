using System;
using TechTalk.SpecFlow;
using Testing2021.Pages;
using Testing2021.Utilities;

namespace Testing2021.StepDefinitions
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        LoginPage loginPage = new LoginPage();
        HomePage homePage = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"logged successfully into the homepage")]
        public void GivenLoggedSuccessfullyIntoTheHomepage()
        {
            driver = new ChromeDriver();
            loginPageObj.LogininSteps(driver);


        }
        
        [Given(@"I logged successfully into  the TM page")]
        public void GivenILoggedSuccessfullyIntoTheTMPage()
        {
           
        }
        
        [Given(@"navigate successfully into the TM Page")]
        public void GivenNavigateSuccessfullyIntoTheTMPage()
        {
            
        }
        
        [When(@"details for create new record are added")]
        public void WhenDetailsForCreateNewRecordAreAdded()
        {
            
        }
        
        [When(@"data to edit the last create record are provided")]
        public void WhenDataToEditTheLastCreateRecordAreProvided()
        {
            
        }
        
        [When(@"find the last created data")]
        public void WhenFindTheLastCreatedData()
        {
            
        }
        
        [Then(@"the result should be create new data")]
        public void ThenTheResultShouldBeCreateNewData()
        {
            
        }
        
        [Then(@"the result should be the edited entries")]
        public void ThenTheResultShouldBeTheEditedEntries()
        {
           
        }
        
        [Then(@"the last created data must be deleted")]
        public void ThenTheLastCreatedDataMustBeDeleted()
        {
           
        }
    }
}
