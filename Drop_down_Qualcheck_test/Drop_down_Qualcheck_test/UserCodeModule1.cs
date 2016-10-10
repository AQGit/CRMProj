/*
 * Created by Ranorex
 * User: Sunjeet.Khokhar
 * Date: 30/09/2016
 * Time: 12:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace Drop_down_Qualcheck_test
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("794B2223-04F5-4690-86C7-2DA6F8438F46", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            string clipboardtext = System.Windows.Forms.Clipboard.GetText(); 
            Console.Write(clipboardtext);
        }
    }
}
