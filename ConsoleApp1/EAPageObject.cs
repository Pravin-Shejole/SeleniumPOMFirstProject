
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleApp1
{
    class EAPageObject
    {
        public EAPageObject()
        { 
            PageFactory.InitElements(PropertiesCollection.driver, this); 
        }

        [FindsBy(How=How.Id,Using="TitleId")]
       public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial{ get; set; }
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtfirstname { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtmiddlename { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnsave { get; set; }

        public void filluserform(string Initial, string FirstName, string MiddleName) { 
            txtInitial.Entertext(Initial);

            txtfirstname.Entertext(FirstName);
            txtmiddlename.Entertext(MiddleName);
            btnsave.Clicks();

        
        }
    }
}
