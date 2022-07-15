// This file is part of Timer Counter Lister
// A program that list and manage timers.
// 
// Copyright © Alaa Ibrahim Hadid 2021 - 2022
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation; either version 3 of the License, 
// or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.See the GNU Lesser General Public 
// License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
using ManagedUI;
using System.ComponentModel.Composition;
using System.Diagnostics;

namespace TimerCounterLister
{
    /*
    * Make new profile.
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("New Profile", "tcl.new.profile", "tcl.core")]
    class NewProfileCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];

            // Check timers
            object[] res0 = new object[1];
            CommandsManager.CMD.Execute("tcl.profile.check.profile.close.ability", new object[] { }, out res0);
            if (!(bool)res0[0])
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_TimersNeedToPauseToMakeNewProfile);
                return;
            }

            // Check for save
            object[] res = new object[1];
            CommandsManager.CMD.Execute("tcl.check.for.save", new object[] { }, out res);
            if (!(bool)res[0])
            {
                Trace.TraceError(Properties.Resources.Status_CannotExecuteCommandNewProfile0);
                return;
            }
            // Show new profile dialog
            FormNewProfile frm = new FormNewProfile();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Trace.WriteLine(Properties.Resources.Status_StartingNewProfile + " ...");

                CancableEventArgs args = new CancableEventArgs();
                TCLCoreService.TCLC.OnBeforeNewProfile(ref args);
                if (args.Cancel)
                {
                    Trace.TraceError(Properties.Resources.Error_NewProfileStartCanceled);
                    return;
                }
                TCLCoreService.TCLC.CurrentProfile = new Profile(frm.EnteredName, frm.EnteredDescription, frm.EnteredIsProfilePasswordProtected, frm.EnteredPassword, frm.EnteredAskForPasswordEachTimeDoAnActivity, frm.EnteredAskForPasswordOnAppClose);
                TCLCoreService.TCLC.CurrentProfile.Initialize(true);
                TCLCoreService.TCLC.CurrentProfilePath = frm.EnteredProfileFilePath;

                // Apply the new project here
                TCLCoreService.TCLC.OnNewProfileStarted();

                Trace.TraceInformation(Properties.Resources.Status_NewProfileStartedSuccessfully);

                // Save it !!
                CommandsManager.CMD.Execute("tcl.save.profile");
            }
            else
            {
                Trace.WriteLine(Properties.Resources.Error_NewProfileStartCanceled);
            }
        }
    }
}
