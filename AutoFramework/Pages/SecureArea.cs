using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.Pages
{
    public class SecureArea
    {
        public SecureArea()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "flash-messages")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.ClassName, Using = "radius")]
        public IWebElement LogOutButton { get; set; }
      
    }
}
