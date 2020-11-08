using AutoFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework
{
    public class DataTableActions
    {
        public static IWebDriver driver { get; set; }

        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL_DataTable);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }


        public static List<string> OriginalList()
        {


            DataTableElements dtPage = new DataTableElements();

            IList<IWebElement> tableDataElements= dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr[1]/td[1]"));

           var rowCount = dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr")).Count;

            for (int i = 0; i <= rowCount; i++) {
                tableDataElements = dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr['"+i+"']/td[1]")).ToList();
            }

            var originalreults = new List<string>();


            foreach (IWebElement tableDataElement in tableDataElements)
            {
                var tableData = tableDataElement.Text;
                originalreults.Add(tableData);
            }

            return originalreults;



        }

        public static List<string> SortedList()
        {
            DataTableElements dtPage = new DataTableElements();

            dtPage.LastNameHesder.Click();

            var rowCount = dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr")).Count;

            IList<IWebElement> tableDataElements = dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr[1]/td[1]")); ;
            for (int i = 0; i <= rowCount; i++)
            {
                tableDataElements = dtPage.Table1.FindElements(By.XPath("//*[@id='table1']/tbody/tr['" + i + "']/td[1]")).ToList();
            }

            var sortedreults = new List<string>();


            foreach (IWebElement tableDataElement in tableDataElements)
            {
                var tableData = tableDataElement.Text;
                sortedreults.Add(tableData);
            }

            return sortedreults;

            


        }
    }
}
