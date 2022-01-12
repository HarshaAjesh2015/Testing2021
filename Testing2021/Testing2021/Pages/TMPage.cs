using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Testing2021.Utilities;

namespace Testing2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialOption.Click();

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Testing2021");

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("New Entry Testing2021");


            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();


            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));


            Assert.That(actualCode.Text == "Testing2021", "Creating record failed,test failed.");
            Assert.That(actualTypeCode.Text == "Material", "Actual typecode and expected typecode do not match.");
            Assert.That(actualDescription.Text == "New Entry Testing2021", "Actual description and expected description do not match.");
            Assert.That(actualPrice.Text == "$20.00", "Actual price and expected price do not match.");

            //if (actualCode.Text == "Testing2021")
            //{
            //    Console.WriteLine("Time record created successfully, test passed.");
            //}
            //else
            //{
            //    Console.WriteLine("Creating record failed,test failed.");
            //}


        }
        public void EditTM(IWebDriver driver)
        {
            
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "Testing2021")
            {
                // click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("EditedTesting2021");

            IWebElement descriptionEdit = driver.FindElement(By.Id("Description"));
            descriptionEdit.Clear();
            descriptionEdit.SendKeys("Edited Entry Testing2021");

            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceInputTag.Click();
            priceTextbox.Clear();
            priceInputTag.Click();
            priceTextbox.SendKeys("100");

            IWebElement saveEditbutton = driver.FindElement(By.Id("SaveButton"));
            saveEditbutton.Click();
            Thread.Sleep(3000);

            // check if record created is present in the table and has expected value
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editCode.Text == "EditedTesting2021", "Actual code and expected code do not match.");
            Assert.That(editTypeCode.Text == "Material", "Actual typecode and expected typecode do not match.");
            Assert.That(editDescription.Text == "Edited Entry Testing2021", "Actual description and expected description do not match.");
            Assert.That(editPrice.Text == "$100.00", "Actual price and expected price do not match.");


            //if (editCode.Text == "Edit New Entry Testing2021")
            //{
            //    Console.WriteLine("Edit record created successfully, test passed.");
            //}
            //else
            //{
            //    Console.WriteLine("Editing record failed,test failed.");

            //}


        }
        public void DeleteTM(IWebDriver driver)
        {


            
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "EditedTesting2021")
            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }

            // Assert that material record has been deleted.
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedCode.Text != "EditedTesting2021", "Code record hasn't been deleted.");
            Assert.That(editedDescription.Text != "Edited Entry Testing2021", "Description record hasn't been deleted.");
            Assert.That(editedPrice.Text != "$100.00", "Price record hasn't been deleted.");


        }

    } 
}
