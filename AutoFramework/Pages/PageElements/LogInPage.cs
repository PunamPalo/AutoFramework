using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.Pages.PageElements
{
    public class LogInPage
    {
        public LogInPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = "flash-messages")]
        public IWebElement LogOutScsMsg { get; set; }
    }
}
