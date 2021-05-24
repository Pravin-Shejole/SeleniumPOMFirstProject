using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
            
           
            
        }
        [SetUp] 
        public void Intialized()
        {//Refrence the browser
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open Url");
        }

        [Test, Order(1)]
        public void Testexecute()
        {
            LoginPageObject Pagelogin = new LoginPageObject();

            EAPageObject EPage = Pagelogin.Login("Execute", "Automation");
            Task.Delay(3000);
            EPage.filluserform("Pravin", "Sanjay", "Automation");
            EAPageObject EAP = new EAPageObject();
            EAP.txtInitial.SendKeys("Execute Automation");
            EAP.btnsave.Click();











            //////Find the test box
            ////driver.FindElement(By.Name("q"));
            ////Task.Delay(500);
            //////send the data to the test box

            ////driver.FindElement(By.Name("q")).SendKeys("Automation Testing");
            ////Task.Delay(5000);

            ////Console.WriteLine("Execute the test");

            ////title

            //Setmethod.SelectDropdownlist("TitleId", "Mr.", "Id");
            
            ////Initial
            //Setmethod.Entertext( "Initial", "Execute Automation", "Name");
            //Console.WriteLine("My Value from title Is:" + GetMethod.GetTextFromDDl("TitleId", "Id"));
            //Console.WriteLine("Value From My Initial Is:" + GetMethod.GetText("Initial", "Name"));
            ////click
            //Setmethod.Click( "Save", "Name");
        }

        [Test, Order(2)]
        public void checkhtmlpopup()
        {

            LoginPageObject Pagelogin = new LoginPageObject();
            Console.WriteLine("Login page available");
            EAPageObject EPage = Pagelogin.Login("Execute", "Automation");
            Task.Delay(3000);
            Console.WriteLine("user login and deafult page open");
         
            HTMlpopup htmlpopu = new HTMlpopup();
            HTMlpopup htmlp = new HTMlpopup();
            htmlp.HTmlpopuplinkclick.Click();
            Console.WriteLine("Htmplpopup open");

         
           

        }

       
       

        [Test]
        public void nexttest()
        {  //Find the test box
            PropertiesCollection.driver.FindElement(By.Name("q"));
            Task.Delay(500);
            //send the data to the test box

            PropertiesCollection.driver.FindElement(By.Name("q")).SendKeys("Automation Testing");
            Task.Delay(5000);

            Console.WriteLine("Execute the test");

            PropertiesCollection.driver.FindElement(By.Name("q")).Click();
            Console.WriteLine("Next Test");
                
                }
        [TearDown]
        public void stopexecute()
        {

            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the execution");
        }
    }
}
