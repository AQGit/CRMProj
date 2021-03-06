﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CRM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Logoff_and_close_browser recording.
    /// </summary>
    [TestModule("e61ab408-970f-416e-8c3c-05be08e13868", ModuleType.Recording, 1)]
    public partial class Logoff_and_close_browser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRMRepository repository.
        /// </summary>
        public static CRMRepository repo = CRMRepository.Instance;

        static Logoff_and_close_browser instance = new Logoff_and_close_browser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logoff_and_close_browser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Logoff_and_close_browser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.AsureQualityTest' at 55;8.", repo.DashboardsAQCustomerServicesDashboa.AsureQualityTestInfo, new RecordItemIndex(0));
            repo.DashboardsAQCustomerServicesDashboa.AsureQualityTest.Click("55;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.NavTabButtonUserInfoSignOutId' at 62;14.", repo.DashboardsAQCustomerServicesDashboa.NavTabButtonUserInfoSignOutIdInfo, new RecordItemIndex(1));
            repo.DashboardsAQCustomerServicesDashboa.NavTabButtonUserInfoSignOutId.Click("62;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for item 'SignInToYourAccount.LoginWorkloadLogoText' to exist.", repo.SignInToYourAccount.LoginWorkloadLogoTextInfo, new ActionTimeout(10000), new RecordItemIndex(2));
            repo.SignInToYourAccount.LoginWorkloadLogoTextInfo.WaitForExists(10000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignInToYourAccount.LoginWorkloadLogoText' at 94;20.", repo.SignInToYourAccount.LoginWorkloadLogoTextInfo, new RecordItemIndex(3));
            //repo.SignInToYourAccount.LoginWorkloadLogoText.Click("94;20");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignOutGoogleChrome.Client' at 1578;6.", repo.SignOutGoogleChrome.ClientInfo, new RecordItemIndex(4));
            repo.SignOutGoogleChrome.Client.Click("1578;6");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
