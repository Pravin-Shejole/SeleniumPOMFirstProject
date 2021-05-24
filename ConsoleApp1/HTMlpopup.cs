using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HTMlpopup
    {

        public HTMlpopup() {
            PageFactory.InitElements(PropertiesCollection.driver, this);
                
                }

        
        [FindsBy(How = How.LinkText, Using = "HtmlPopup")]
        public IWebElement HTmlpopuplinkclick{ get; set; }

        public IWebElement switchtoalertpopup { get; set; }

        public void Clickopup()
        {

            HTmlpopuplinkclick.Clicks();
            switchtoalertpopup.Clicks();

        }
    }
}
