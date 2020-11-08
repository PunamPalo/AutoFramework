using AutoFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework
{
    public class DynamicControlsActions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL_DynamicControl);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }


        public static void checkBoxActions()
        {
            DynamicControls dcPage = new DynamicControls();

            dcPage.RemoveButton.Click();

        }

        public static bool IschkBoxDisplaytrue()
        {
            DynamicControls dcPage = new DynamicControls();
            if (dcPage.CheckBox.Displayed == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string getcheckBoxText()
        {
            DynamicControls dcPage = new DynamicControls();

            String SuccessmsgText = dcPage.checkboxMessage.Text.TrimEnd();
            //securearea.LogOutButton.Click();
            return SuccessmsgText;
        }

        public static void ClickOnEnableDisableButton()
        {
            DynamicControls dcPage = new DynamicControls();

            dcPage.EnableDisableButton.Click();

        }

        public static bool IsEnableTextBoxtrue()
        {
            DynamicControls dcPage = new DynamicControls();
            if (dcPage.EnableDisableTextBox.Enabled == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
