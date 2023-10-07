
// Open chrome browser 

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();

// Launch turnup portal and navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login"); 

//Identify username textbox and enter a valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter a valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify the login button and click on the button.
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// Maximize the window
driver.Manage().Window.Maximize();

Thread.Sleep(10000);

//Check if the user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));



if (helloHari.Text == "Hello hari!")
{

    Console.WriteLine("User has logged in successfully");
}
else
{ 
    Console.WriteLine("User has not logged in");

}



// Test case - Create a new Time record

// Identify the Administration button and click

IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationButton.Click();

//Identify Time and Materials and click.

IWebElement tandmButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tandmButton.Click();

//Click on the create new button.

IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));

createnewButton.Click();

// Identify the TypeCode dropdown button and click
IWebElement typecodeDropdownButton = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typecodeDropdownButton.Click();


// Identify the code textbox and enter a valid code

IWebElement codeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
codeTextbox.SendKeys("abc2323");

// Identify the description textbox and enter a valid description

IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
descriptionTextbox.SendKeys("This is a test case for time.");

// Identify the price per unit and enter a valid price

IWebElement priceperunitTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceperunitTextbox.SendKeys("115");

//Identify the save button and click
IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));

saveButton.Click();

Thread.Sleep(2000);


// Check if the new time record has been added successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); 
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newCode.Text == "abc2323")
    { Console.WriteLine("New time record has been created successfully.");
}
else
{
    Console.WriteLine("New time record hasn't been created");
}

Thread.Sleep(5000);

// Edit the new record in time and materials

// Identify the Edit button corresponding to the new entry and click

IWebElement lastEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
lastEditButton.Click();

//Identify the code textbox and enter the new code
IWebElement editCodeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
editCodeTextbox.Clear();
editCodeTextbox.SendKeys("abc232345");


//Identify the save button and click
IWebElement newSaveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
newSaveButton.Click();

Thread.Sleep(2000);

// Check if the new time record has been added successfully
IWebElement goToLastPageButtonAgain = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButtonAgain.Click();



IWebElement newCodeEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newCodeEdited.Text == "abc232345")
{
    Console.WriteLine("New time record has been edited successfully.");
}
else
{
    Console.WriteLine("New time record hasn't been edited");
}
Thread.Sleep(2000);

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








