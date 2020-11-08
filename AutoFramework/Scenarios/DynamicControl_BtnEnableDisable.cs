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
    public class DynamicControl_BtnEnableDisable
    {
        public DynamicControl_BtnEnableDisable()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            DynamicControlsActions.InitializeDriver();
        }

        [Test]
        public void EnableButton()
        {
            Thread.Sleep(1000);
            DynamicControlsActions.ClickOnEnableDisableButton();
            Thread.Sleep(3000);


            Assert.AreEqual(true, DynamicControlsActions.IsEnableTextBoxtrue());
            Thread.Sleep(3000);

            DynamicControlsActions.ClickOnEnableDisableButton();
            Thread.Sleep(3000);
            Assert.AreEqual(false, DynamicControlsActions.IsEnableTextBoxtrue());
            Thread.Sleep(3000);
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }


}
