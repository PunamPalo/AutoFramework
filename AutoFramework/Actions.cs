namespace AutoFramework
{
    using AutoFramework.Pages.PageElements;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }


        public static void FillLoginForm(string username, string password)
        {
            LogInPage loginpaghe = new LogInPage();

            loginpaghe.UserName.Clear();
            loginpaghe.UserName.SendKeys(username);
            loginpaghe.Password.Clear();
            loginpaghe.Password.SendKeys(password);

            loginpaghe.LoginButton.Click();
        }

        public static void FillLoginFormUsingWrongCredentials(string username, string password)
        {
            LogInPage loginpaghe = new LogInPage();

            loginpaghe.UserName.Clear();
            loginpaghe.UserName.SendKeys(username);
            loginpaghe.Password.Clear();
            loginpaghe.Password.SendKeys(password);

            loginpaghe.LoginButton.Click();
        }


        public static void LogOutFromScreen()
        {
            SecureArea securearea = new SecureArea();
            securearea.LogOutButton.Click();
        }


        public static string getText()
        {
            SecureArea securearea = new SecureArea();

            String SuccessmsgText = securearea.SuccessMessage.Text.Replace(System.Environment.NewLine, "").Replace("×","");
            return SuccessmsgText;
        }

        public static string getLogOutText()
        {
            LogInPage loginpaghe = new LogInPage();

            String SuccessmsgTexts = loginpaghe.LogOutScsMsg.Text.Replace(System.Environment.NewLine, "").Replace("×", "");
            return SuccessmsgTexts;
        }

       
    }
}
