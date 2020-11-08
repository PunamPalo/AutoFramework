using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.Pages
{
    public class DataTableElements
    {
        public DataTableElements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "table1")]
        public IWebElement Table1 { get; set; }

        

        [FindsBy(How = How.CssSelector, Using = "#table1 > thead > tr > th:nth-child(1) > span")]
        public IWebElement LastNameHesder { get; set; }
        //#table1 > tbody > tr:nth-child(1) > td:nth-child(1)
        //#table1 > tbody > tr:nth-child(2) > td:nth-child(1)
    }
}
