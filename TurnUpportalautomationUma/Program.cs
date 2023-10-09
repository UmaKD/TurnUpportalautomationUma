
// Open chrome browser 

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpportalautomationUma.pages;

public class Program
{
    private static void Main(string[] args)
    {


        IWebDriver driver = new ChromeDriver();
        // LoginPage page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAction(driver);

        //HomePage page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.ClickONAdministrationButton(driver);
        homePageObj.ClickOnTimeAndMaterials(driver);

        //TMPage page object initialization and definition
        TMPage tMPageObj= new TMPage();
        tMPageObj.CreateNewRecord(driver);
        tMPageObj.EditTheNewRecordInTM(driver);
        tMPageObj.DeleteTheEntryInTM(driver);
        




    }

}