using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Setmethod
    {

        public static void Entertext(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element) => element.Click();

        public static void SelectDropdownlist( this IWebElement element, string value)
        {

            new SelectElement(element).SelectByText(value);
            
        }
    }
}
