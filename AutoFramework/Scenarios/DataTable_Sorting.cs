using AutoFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoFramework.Scenarios
{
    
    public class DataTable_Sorting
    {

        public DataTable_Sorting()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            DataTableActions.InitializeDriver();
        }

        [Test]
        public void EnableButton()
        {
            Assert.AreNotEqual(DataTableActions.OriginalList(), DataTableActions.SortedList());
         
            Thread.Sleep(2000);
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }


}
