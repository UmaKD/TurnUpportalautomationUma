using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUpportalautomationUma.pages
{
    public class HomePage

    {
        public void ClickONAdministrationButton(IWebDriver driver)
        {// Identify the Administration button and click

            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

        }
        public void ClickOnTimeAndMaterials(IWebDriver driver)
        {
            //Identify Time and Materials and click.

            IWebElement tandmButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tandmButton.Click();
            
        }
        
    }
}

