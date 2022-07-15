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
    * Save profile as, open dialog for browsing file where to save profile then save.
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * bool Success: true: profile saved successfully, false: project didn't save.
    */
    [Export(typeof(ICommand))]
    [CommandInfo("Save Profile As", "tcl.save.profile.as", "tcl.core")]
    class SaveProfileAsCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[1];
            responses[0] = false;

            // Check for password first
            object[] res = new object[1];
            CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
            if (!(bool)res[0])
            {
                Trace.TraceError(Properties.Resources.Error_CannotSaveProfileIncorrectPassword);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotSaveProfileIncorrectPassword);
                return;
            }

            string filePath = "";
            if (TCLCoreService.TCLC.CurrentProfilePath == "")
                filePath = TCLCoreService.TCLC.CurrentProfile.Name + ".tclp";
            else
                filePath = TCLCoreService.TCLC.CurrentProfilePath;
            bool ok = false;
            Utilities.ShowOpenSaveDialog(true, Properties.Resources.Title_SaveProfile, Properties.Resources.Filter_TCLP, ref filePath, out ok);
            if (ok)
            {
                CancableEventArgs args = new CancableEventArgs();
                TCLCoreService.TCLC.OnBeforeProfileSave(ref args);

                if (args.Cancel)
                {
                    TCLCoreService.TCLC.OnProfileCannotBeSaved();
                    Trace.TraceError(Properties.Resources.Error_SaveProfileCanceled);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_SaveProfileCanceled);
                    return;
                }

                if (TCLPFile.SaveProfileFile(filePath, TCLCoreService.TCLC.CurrentProfile, (TCLPSavingMethod)Properties.Settings.Default.ProfileSavingMethod, Properties.Settings.Default.ProfileUseCompressInSaving))
                {
                    TCLCoreService.TCLC.CurrentProfilePath = filePath;
                    TCLCoreService.TCLC.OnProfileSaved();

                    Trace.WriteLine(Properties.Resources.Status_ProfileSavedSuccessfully);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Status_ProfileSavedSuccessfully);
                    responses[0] = true;
                }
                else
                {
                    TCLCoreService.TCLC.OnProfileCannotBeSaved();
                }
            }
        }
    }
}
