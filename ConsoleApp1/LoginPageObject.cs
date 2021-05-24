using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#userName > p:nth-child(3) > input[type=submit]")]
        public IWebElement btnlogin { get; set; }
        public EAPageObject Login(string Username, string Password)
        {
            txtUserName.Entertext(Username);
            TxtPassword.Entertext(Password);
            btnlogin.Clicks();
            //Return the Page Object
            return new EAPageObject();

        }
    }
}
