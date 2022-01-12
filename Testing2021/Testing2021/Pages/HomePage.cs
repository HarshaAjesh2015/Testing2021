using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing2021.Utilities;
using OpenQA.Selenium.Support.UI;

namespace Testing2021.Pages
{
     public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationDropdown.Click();
           Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",2);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        }
            
              
        public void GoToEmployeePage(IWebDriver driver)
        {
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/ html / body / div[3] / div / div / ul / li[5] / ul / li[2] / a", 3);

            IWebElement empOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            empOption.Click();

        }

            
            

    }
}
