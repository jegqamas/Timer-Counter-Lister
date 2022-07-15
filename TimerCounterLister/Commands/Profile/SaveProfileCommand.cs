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
using System;
using System.IO;
using System.Diagnostics;
using ManagedUI;
using System.ComponentModel.Composition;

namespace TimerCounterLister
{
    /*
    * Save profile into file, it will check for current profile file path, if it is exist, it will use it first.
    * If current profile file path is not set, it will execute "Save profile As [asm.save.profile.as]" command.
    * 
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * bool Success: true: profile saved successfully, false: profile didn't save.
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Save Profile", "tcl.save.profile", "tcl.core")]
    class SaveProfileCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[1];
            if (TCLCoreService.TCLC.CurrentProfilePath == null)
            {
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.save.profile.as", new object[] { }, out res);
                responses[0] = res[0];
                return;
            }
            if (TCLCoreService.TCLC.CurrentProfilePath == "")
            {
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.save.profile.as", new object[] { }, out res);
                responses[0] = res[0];
                return;
            }
            /*if (!File.Exists(TCLCoreService.TCLC.CurrentProfilePath))
            {
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.save.profile.as", new object[] { }, out res);
                responses[0] = res[0];
                return;
            }*/

            // Check for password first
            object[] res11 = new object[1];
            CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res11);
            if (!(bool)res11[0])
            {
                Trace.TraceError(Properties.Resources.Error_CannotSaveProfileIncorrectPassword);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotSaveProfileIncorrectPassword);
                return;
            }

            CancableEventArgs args = new CancableEventArgs();
            TCLCoreService.TCLC.OnBeforeProfileSave(ref args);

            if (args.Cancel)
            {
                TCLCoreService.TCLC.OnProfileCannotBeSaved();
                Trace.TraceError(Properties.Resources.Error_CannotSaveProfileItHasCanceledInternally);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotSaveProfileItHasCanceledInternally);

                responses[0] = false;
                return;
            }

            if (TCLPFile.SaveProfileFile(TCLCoreService.TCLC.CurrentProfilePath, TCLCoreService.TCLC.CurrentProfile, (TCLPSavingMethod)Properties.Settings.Default.ProfileSavingMethod, Properties.Settings.Default.ProfileUseCompressInSaving))
            {
                TCLCoreService.TCLC.OnProfileSaved();

                Trace.WriteLine(Properties.Resources.Status_ProfileSavedSuccessfully);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Status_ProfileSavedSuccessfully);

                responses[0] = true;
            }
            else
            {
                TCLCoreService.TCLC.OnProfileCannotBeSaved();
                responses[0] = false;
            }
        }
    }
}
