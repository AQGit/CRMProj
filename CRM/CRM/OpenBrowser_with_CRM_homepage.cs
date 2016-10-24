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
    ///The OpenBrowser_with_CRM_homepage recording.
    /// </summary>
    [TestModule("58a9c566-ac66-4f48-a194-5ca18d7dccbc", ModuleType.Recording, 1)]
    public partial class OpenBrowser_with_CRM_homepage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRMRepository repository.
        /// </summary>
        public static CRMRepository repo = CRMRepository.Instance;

        static OpenBrowser_with_CRM_homepage instance = new OpenBrowser_with_CRM_homepage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser_with_CRM_homepage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser_with_CRM_homepage Instance
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

            // Pre-requisite - 1. Appropriate CRM AD login session active in the Chrome browser 2. No browser window opren  .
            Report.Log(ReportLevel.Info, "Website", "Pre-requisite - 1. Appropriate CRM AD login session active in the Chrome browser 2. No browser window opren  .\r\nOpening web site 'https://asurequalitytest.crm6.dynamics.com/main.aspx' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://asurequalitytest.crm6.dynamics.com/main.aspx", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
