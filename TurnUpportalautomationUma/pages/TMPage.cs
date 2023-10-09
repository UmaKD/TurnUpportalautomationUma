using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUpportalautomationUma.pages
{
    public class TMPage
    {
        public void ClickOnCreateNew(IWebDriver driver)
        {
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));

            createnewButton.Click();
        }
        public void CodeTextBoxActions(String codeValue, IWebDriver driver)
        {
            // Identify the code textbox and enter a valid code

            IWebElement codeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextbox.Clear();
            codeTextbox.SendKeys(codeValue);
        }
        public void DescriptionTextBoxActions(IWebDriver driver)
        { // Identify the description textbox and enter a valid description

            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descriptionTextbox.SendKeys("This is a test case for time.");
        }
        public void EnterAValidPrice(IWebDriver driver)
        {
            // Identify the price per unit and enter a valid price

            IWebElement priceperunitTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceperunitTextbox.SendKeys("115");

        }
        public void ClickOnSaveButton(IWebDriver driver)
        {
            //Identify the save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));

            saveButton.Click();

            Thread.Sleep(2000);

        }
        public void VerifyTimeRecord(String codeValue, IWebDriver driver)
        {
            // Check time record 
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == codeValue)
            {
                Console.WriteLine("Time Record verified successfully.");
            }
            else
            {
                Console.WriteLine("New time could not be verified");
            }

            Thread.Sleep(5000);
        }

        public void CreateNewRecord(IWebDriver driver)
        {
            ClickOnCreateNew(driver);
            CodeTextBoxActions("abc2323", driver);
            DescriptionTextBoxActions(driver);
            EnterAValidPrice(driver);
            ClickOnSaveButton(driver);
            VerifyTimeRecord("abc2323", driver);
        }
        public void EditTheNewRecordInTM(IWebDriver driver)
        {
            // Identify the Edit button corresponding to the new entry and click

            IWebElement lastEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            lastEditButton.Click();

            //Identify the code textbox and enter the new code


            CodeTextBoxActions("abc232345", driver);


            ClickOnSaveButton(driver);

            Thread.Sleep(2000);

            VerifyTimeRecord("abc232345", driver);




            Thread.Sleep(2000);
        }
        public void DeleteTheEntryInTM(IWebDriver driver)
        {
            //Identify the delete button corresponding to the last edited entry and click.
            IWebElement lastDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastDeleteButton.Click();
            Thread.Sleep(3000);

            // Confirm that you want to delete the record.
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);
            // Check if the new record has been deleted
            IWebElement goToLastPageButtonAgainDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgainDelete.Click();


            IWebElement newLastCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newLastCode.Text != "abc232345")
            {
                Console.WriteLine(" The edited time record has been deleted successfully.");
            }
            else
            {
                Console.WriteLine("The edited time record hasn't been deleted");
            }
        }
    }
}