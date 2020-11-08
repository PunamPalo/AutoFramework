using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.Pages
{
    public class DynamicControls
    {
        public DynamicControls()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "checkbox")]
        public IWebElement CheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#checkbox-example > button")]
        public IWebElement RemoveButton { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement checkboxMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#input-example > button")]
        public IWebElement EnableDisableButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#input-example > input[type=text]")]
        public IWebElement EnableDisableTextBox { get; set; }
    }
}
