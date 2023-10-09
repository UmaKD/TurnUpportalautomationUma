using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUpportalautomationUma.pages
{
    public class LoginPage
      
    {
        public void LoginAction(IWebDriver driver)
        {
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
        }
    }
}
