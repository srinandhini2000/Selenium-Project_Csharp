using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace Selenium_Project_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test case started ");
           


            //Creatae Reference of the Browser  
            IWebDriver driver = new FirefoxDriver();

           


            //Navigate to the URL
            driver.Navigate().GoToUrl("http://ec2-54-81-218-118.compute-1.amazonaws.com/");


           
            

            //Identify the Login button in Fast Class
            IWebElement btn = driver.FindElement(By.Id("login_001"));
            
            //Click on the Login Button
            btn.Click();
            
            //Idnetify the menubtn
            IWebElement menubtn = driver.FindElement(By.Id("menu_button"));

            //Click on the Menu Button
            menubtn.Click();

            //Identify the User Icon
            IWebElement userbtn = driver.FindElement(By.Id("Layer_1"));

            //Click on User Icon Button
            userbtn.Click();

            //Identify the search boxs
            IWebElement Search = driver.FindElement(By.Id("txtSearch"));

            Search.SendKeys("");
            Search.Click();
            IWebElement article=driver.FindElement(By.Id("1"));
            article.Click();
            
            IWebElement searchbtn = driver.FindElement(By.Id("btnSearch1"));
           searchbtn.Click();



            IWebElement usersearch = driver.FindElement(By.Id("txtSearch"));
            usersearch.SendKeys("120");

            driver.FindElement(By.Id("btnSearch")).Click();
            //Close the Browser
            driver.Close();

            Console.WriteLine("Test Case Ended");
        }
    }
}
