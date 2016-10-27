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
    ///The CRM_login_non_AD recording.
    /// </summary>
    [TestModule("a94240ab-6fc7-4b04-bcf1-f9d05d104038", ModuleType.Recording, 1)]
    public partial class CRM_login_non_AD : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRMRepository repository.
        /// </summary>
        public static CRMRepository repo = CRMRepository.Instance;

        static CRM_login_non_AD instance = new CRM_login_non_AD();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CRM_login_non_AD()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CRM_login_non_AD Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://asurequalitytest.crm6.dynamics.com/main.aspx' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://asurequalitytest.crm6.dynamics.com/main.aspx", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignInToYourAccount.UseAnotherAccount' at 18;25.", repo.SignInToYourAccount.UseAnotherAccountInfo, new RecordItemIndex(1));
            repo.SignInToYourAccount.UseAnotherAccount.Click("18;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignInToYourAccount.CredUseridInputtext' at 26;17.", repo.SignInToYourAccount.CredUseridInputtextInfo, new RecordItemIndex(2));
            repo.SignInToYourAccount.CredUseridInputtext.Click("26;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'assurity.role1{LShiftKey down}@{LShiftKey up}' with focus on 'SignInToYourAccount.CredUseridInputtext'.", repo.SignInToYourAccount.CredUseridInputtextInfo, new RecordItemIndex(3));
            repo.SignInToYourAccount.CredUseridInputtext.PressKeys("assurity.role1{LShiftKey down}@{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'asurequality' with focus on 'SignInToYourAccount.CredUseridInputtext'.", repo.SignInToYourAccount.CredUseridInputtextInfo, new RecordItemIndex(4));
            repo.SignInToYourAccount.CredUseridInputtext.PressKeys("asurequality");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1.om{Back}n' with focus on 'SignInToYourAccount.CredUseridInputtext'.", repo.SignInToYourAccount.CredUseridInputtextInfo, new RecordItemIndex(5));
            repo.SignInToYourAccount.CredUseridInputtext.PressKeys("1.om{Back}n");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'microsoft.com' with focus on 'SignInToYourAccount.CredUseridInputtext'.", repo.SignInToYourAccount.CredUseridInputtextInfo, new RecordItemIndex(6));
            repo.SignInToYourAccount.CredUseridInputtext.PressKeys("microsoft.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignInToYourAccount.CredPasswordInputtext' at 21;9.", repo.SignInToYourAccount.CredPasswordInputtextInfo, new RecordItemIndex(7));
            repo.SignInToYourAccount.CredPasswordInputtext.Click("21;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}T{LShiftKey up}uesday' with focus on 'SignInToYourAccount.CredPasswordInputtext'.", repo.SignInToYourAccount.CredPasswordInputtextInfo, new RecordItemIndex(8));
            repo.SignInToYourAccount.CredPasswordInputtext.PressKeys("{LShiftKey down}T{LShiftKey up}uesday");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{LShiftKey down}!{LShiftKey up}' with focus on 'SignInToYourAccount.CredPasswordInputtext'.", repo.SignInToYourAccount.CredPasswordInputtextInfo, new RecordItemIndex(9));
            repo.SignInToYourAccount.CredPasswordInputtext.PressKeys("1{LShiftKey down}!{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SignInToYourAccount.CredSignInButton' at 36;14.", repo.SignInToYourAccount.CredSignInButtonInfo, new RecordItemIndex(10));
            repo.SignInToYourAccount.CredSignInButton.Click("36;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
