using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GetMethod
    { 
        public static string GetText(string element, string elementtype)
            {
            if (elementtype == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("Value");
            if (elementtype == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("Value");
            else return string.Empty;

        }
        public static string GetTextFromDDl( string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;

        }
    }
}
