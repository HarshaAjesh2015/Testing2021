using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Testing2021.Pages;
using Testing2021.Utilities;

namespace Testing2021
{
    [TestFixture]
    [Parallelizable]

    public class TMTests : CommonDriver
    {


        [Test, Order(1), Description("Check if user is able to create a material record with valid data")]


        public void CreateTM_Test()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }
        [Test, Order(2), Description("Check if user is able to edit a material record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }
        [Test, Order(3), Description("Check if user is able to delete a material record with valid data")]
        public void DeleteTM_Test()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }










    }


    
  
}









    

