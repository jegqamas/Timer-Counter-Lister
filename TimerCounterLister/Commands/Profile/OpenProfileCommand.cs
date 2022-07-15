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
    * Open profile, check if there is any changes in the profile that require save first. 
    * 
    * 
    * Parameters:
    * string FilePath: the profile file path. Cannot be empty or null. It must be exist as well.
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Open Profile", "tcl.open.profile", "tcl.core")]
    class OpenProfileCommand : ICommand
    {
        private string current_password;
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];
            string filePath = "";
            if (parameters != null)
                if (parameters.Length > 0)
                    filePath = (string)parameters[0];
            if (filePath == null || filePath == "")
            {
                Utilities.ShowError(new Exception(Properties.Resources.Error_CannotOpenProfilePathIsEmpty), Properties.Resources.Error_CannotOpenProfilePathIsEmpty, Properties.Resources.Title_OpenProfile);
                Trace.TraceError(Properties.Resources.Error_CannotOpenProfilePathIsEmpty);

                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotOpenProfilePathIsEmpty);
                if (TCLCoreService.TCLC.RecentProfiles.Contains(filePath))
                {
                    TCLCoreService.TCLC.RecentProfiles.Remove(filePath);
                    TCLCoreService.TCLC.OnRecentProfilesUpdated();
                }
                return;
            }
            if (!File.Exists(filePath))
            {
                Utilities.ShowError(new Exception(Properties.Resources.Error_CannotOpenProfilePathNotExist), Properties.Resources.Error_CannotOpenProfilePathNotExist, Properties.Resources.Title_OpenProfile);
                Trace.TraceError(Properties.Resources.Error_CannotOpenProfilePathNotExist);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotOpenProfilePathNotExist);
                if (TCLCoreService.TCLC.RecentProfiles.Contains(filePath))
                {
                    TCLCoreService.TCLC.RecentProfiles.Remove(filePath);
                    TCLCoreService.TCLC.OnRecentProfilesUpdated();
                }
                return;
            }
            // Check timers
            object[] res0 = new object[1];
            CommandsManager.CMD.Execute("tcl.profile.check.profile.close.ability", new object[] { }, out res0);
            if (!(bool)res0[0])
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_TimersNeedToPauseToOpenProfile);
                return;
            }

            object[] res = new object[1];
            CommandsManager.CMD.Execute("tcl.check.for.save", new object[] { }, out res);
            if (!(bool)res[0])
            {
                Trace.TraceError(Properties.Resources.Status_CannotExecuteCommandNewProfile0);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Status_CannotExecuteCommandNewProfile0);
                return;
            }

            Profile pro = null;

            CancableEventArgs args = new CancableEventArgs();
            TCLCoreService.TCLC.OnBeforeProfileOpen(ref args);

            if (args.Cancel)
            {
                TCLCoreService.TCLC.OnProfileCannotBeOpened();
                Trace.TraceError(Properties.Resources.Error_OpenProfileCanceled);
                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_OpenProfileCanceled);
                return;
            }
            if (TCLPFile.OpenProfileFile(filePath, out pro))
            {
                if (pro != null)
                {
                    if (pro.IsPasswordProtected)
                    {
                        current_password = pro.Password;

                        FormEnterName frm = new FormEnterName(Properties.Resources.Title_EnterProfilePassword, "", true, true);
                        frm.OkPressed += Frm_OkPressed;

                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            // Check password
                            if (frm.EnteredName != current_password)
                            {
                                Utilities.ShowError(new Exception(Properties.Resources.Error_CannotOpenProfileIncorrectPassword), Properties.Resources.Error_CannotOpenProfileIncorrectPassword, Properties.Resources.Title_OpenProfile);
                                Trace.TraceError(Properties.Resources.Error_CannotOpenProfileIncorrectPassword);
                                GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotOpenProfileIncorrectPassword);
                                TCLCoreService.TCLC.OnProfileCannotBeOpened();
                                return;
                            }
                        }
                        else
                        {
                            TCLCoreService.TCLC.OnProfileCannotBeOpened();
                            Trace.TraceError(Properties.Resources.Error_OpenProfileCanceled);
                            GUIService.GUI.OnProgressFinished(Properties.Resources.Error_OpenProfileCanceled);
                            return;
                        }
                    }
                    pro.Initialize(false);
                    TCLCoreService.TCLC.CurrentProfile = pro;
                    TCLCoreService.TCLC.CurrentProfilePath = filePath;
                    TCLCoreService.TCLC.OnProfileOpened();

                    Trace.TraceInformation(Properties.Resources.Status_ProfileOpenedSuccessfully);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Status_ProfileOpenedSuccessfully);
                }
                else
                {
                    Utilities.ShowError(new Exception(Properties.Resources.Error_UnableToOpenProfileUnknownReason), Properties.Resources.Error_UnableToOpenProfileUnknownReason, Properties.Resources.Title_OpenProfile);
                    Trace.TraceError(Properties.Resources.Error_UnableToOpenProfileUnknownReason);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_UnableToOpenProfileUnknownReason);
                    TCLCoreService.TCLC.OnProfileCannotBeOpened();
                }
            }
            else
                TCLCoreService.TCLC.OnProfileCannotBeOpened();
        }

        private void Frm_OkPressed(object sender, EnterNameFormOkPressedArgs e)
        {
            if (e.NameEntered != current_password)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_IncorrectPassword, Properties.Resources.Title_OpenProfile);
                e.Cancel = true;
            }
        }
    }
}
