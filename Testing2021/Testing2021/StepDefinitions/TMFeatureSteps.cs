using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
            loginPage.LoginSteps(driver);


        }

        [Given(@"I logged successfully into  the TM page")]
        public void GivenILoggedSuccessfullyIntoTheTMPage()
        {
            homePage.GoToTMPage(driver);

        }



        [When(@"details for create new record are added")]
        public void WhenDetailsForCreateNewRecordAreAdded()
        {
            tmPageObj.CreateTM(driver);
        }




        [Then(@"the result should be create new data")]
        public void ThenTheResultShouldBeCreateNewData()
        {
            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetDescription(driver);
            string actualPrice = tmPageObj.GetPrice(driver);

            Assert.That(actualCode == "Testing2021", "Creating record failed,test failed.");
            Assert.That(actualTypeCode == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(actualDescription == "New Entry Testing2021", "Actual description and expected description do not match.");
            Assert.That(actualPrice == "$20.00", "Actual price and expected price do not match.");
        }

        [Given(@"navigate successfully into the TM Page")]
        public void GivenNavigateSuccessfullyIntoTheTMPage()
        {
            homePage.GoToTMPage(driver);
        }
        //[When(@"When data to edit '(.*)' are provided")]
        //public void WhenDataToEditTheLastCreateRecordAreProvided(string p0, string p1)
        //{
        //    tmPageObj.EditTM(driver, p0);
        //}

        //[Then(@"Then the result should have updated <Description>")]
        //public void ThenTheResultShouldBeTheEditedEntries(string p0, string p1)
        //{
        //    string editCode = tmPageObj.GeteditCode(driver);
        //    string editedDescription = tmPageObj.GeteditedDescription(driver);
        //    string typeCode = tmPageObj.GeteditTypeCode(driver);
        //    string editedPrice = tmPageObj.GeteditedPrice(driver);


        //    Assert.That(editCode == "EditedTesting2021", "Actual code and expected code do not match.");
        //    Assert.That(typeCode == p1, "Actual typecode and expected typecode do not match.");
        //    Assert.That(editedDescription == , "Actual description and edited description do not match");
        //    Assert.That(editedPrice == "$100.00", "Actual price and expected price do not match.");
        //}

        //[When(@"data to edit (.*) are provided")]
        //public void WhenDataToEditAreProvided(string p0)
        //{

        //}

        //[Then(@"the result should have updated (.*)")]
        //public void ThenTheResultShouldHaveUpdated(string p0)
        //{

        //}
        [When(@"find the last created data")]
        public void WhenFindTheLastCreatedData()
        {
            tmPageObj.DeleteTM(driver);
        }

        [Then(@"the last created data must be deleted")]
        public void ThenTheLastCreatedDataMustBeDeleted()
        {

            string deletedCode = tmPageObj.GetdelCode(driver);
            string deletedDescription = tmPageObj.GetdelDescription(driver);
            string deletedPrice = tmPageObj.GetdelPrice(driver);



            Assert.That(deletedCode != "EditedTesting2021", "Code record hasn't been deleted.");
            Assert.That(deletedDescription != "Edited Entry Testing2021", "Description record hasn't been deleted.");
            Assert.That(deletedPrice != "$100.00", "Price record hasn't been deleted.");
        }



        [When(@"data to edit (.*) and (.*)are provided")]
        public void WhenDataToEditAndAreProvided(string p0, string p1)
        {
            tmPageObj.EditTM(driver, p0, p1);
        }

        [Then(@"the result should have updated (.*) and (.*)")]
        public void ThenTheResultShouldHaveUpdatedAnd(string p0, string p1)
        {
            string editCode = tmPageObj.GeteditCode(driver);
            string editedDescription = tmPageObj.GeteditedDescription(driver);
            string typeCode = tmPageObj.GeteditTypeCode(driver);
            string editedPrice = tmPageObj.GeteditedPrice(driver);


            Assert.That(editCode == p1, "Actual code and expected code do not match.");
            Assert.That(typeCode == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(editedDescription == p0, "Actual description and edited description do not match");
            Assert.That(editedPrice == "$100.00", "Actual price and expected price do not match.");
        }
    }
}