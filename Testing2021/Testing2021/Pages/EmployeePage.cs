using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing2021.Utilities;

namespace Testing2021.Pages
{
    class EmployeePage

    {
        public void CreateEmp(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Tester2021");


            IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
            usernameTextBox.SendKeys("Tester2021");

            IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextBox.SendKeys("abcdefg");

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("testing2021");

            IWebElement retypepasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypepasswordTextbox.SendKeys("testing2021");

            IWebElement adminCheckbox = driver.FindElement(By.Id("IsAdmin"));
            adminCheckbox.Click();

            IWebElement vehicleTextbox = driver.FindElement(By.Id("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("car");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            //Wait.WaitToBeClickable(driver, Id, "SaveButton", 3);


            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

        }
        public void EditEmp(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            goToLastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "Tester2021")
            {
                // click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }


        }

        public void DeleteEmp(IWebDriver driver)
        {

        }
    }
}
