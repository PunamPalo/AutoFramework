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
    public class DynamicControl_CheckBox 
    {

        IAlert alert;

        public DynamicControl_CheckBox()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            DynamicControlsActions.InitializeDriver();
        }

        [Test]
        public void AddRemove_Chkbox()
        {
            Thread.Sleep(1000);
            DynamicControlsActions.checkBoxActions();
            Thread.Sleep(3000);

            Assert.AreEqual(Config.AlertsTexts.RemoveCheckBoxText, DynamicControlsActions.getcheckBoxText());
            Thread.Sleep(3000);

            DynamicControlsActions.checkBoxActions();
            Thread.Sleep(3000);


            Assert.AreEqual(true, DynamicControlsActions.IschkBoxDisplaytrue());
            Thread.Sleep(3000);
        }


        //[Test]
        //public void Add_Chkbox()
        //{
        //    Thread.Sleep(1000);
        //    DynamicControlsActions.checkBoxActions();
        //    Thread.Sleep(3000);

        //  //  CheckBoxActions.IschkBoxDisplaytrue();


        //    Assert.AreEqual(true, DynamicControlsActions.IschkBoxDisplaytrue());
        //    Thread.Sleep(3000);

        //}

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }


}
