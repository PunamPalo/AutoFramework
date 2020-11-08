using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoFramework.Scenarios
{
    public class LogIn_InvalidCredentials
    {
        public LogIn_InvalidCredentials()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        // To check Login screen using empty username
        [Test]
        public void LogInInValidData_UsingEmptyUserName()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.EmptyUserName,
                Config.Credentials.Valid.Password);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        // To check Login screen using wrong username
        [Test]
        public void LogInInValidData_UsingWrongUserName()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.OtherthangivenValue,
                Config.Credentials.Valid.Password);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        // To check Login screen using empty password
        [Test]
        public void LogInInValidData_UsingEmptyPassword()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(
                Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.EmptyPassword);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage_Password, Actions.getText());
        }

        // To check Login screen using wrong password
        [Test]
        public void LogInInValidData_UsingWrongPassword()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(
                Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.OtherthangivenValue);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage_Password, Actions.getText());
        }

        // To check Login screen using empty username and empty password
        [Test]
        public void LogInInValidData_UsingEmptytValues()
        {
            Thread.Sleep(1000);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.EmptyUserName,
                Config.Credentials.Invalid.Password.EmptyPassword);
            Thread.Sleep(3000);
            Assert.AreEqual(Config.AlertsTexts.Errormessage, Actions.getText());
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
