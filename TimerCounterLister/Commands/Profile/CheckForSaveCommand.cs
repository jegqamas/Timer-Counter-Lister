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

namespace TimerCounterLister
{
    /*
    * Check For Save, check if there is any changes in the profile that require save.
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * bool Confirm: True: it is ok to proceed, there is not changes to save or changes are saved. 
    *               False: it is NOT ok to proceed, the save changes has been canceled or cannot be saved.
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Check For Save", "tcl.check.for.save", "tcl.core")]
    class CheckForSaveCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[1];
            responses[0] = false;

            if (TCLCoreService.TCLC.SaveBending)
            {
                ManagedMessageBoxResult mres = ManagedMessageBox.ShowMessage(Properties.Resources.Message_DoYouWantToSaveProfileFirst, Properties.Resources.MessageCaption_SaveChanges,
                    new string[] {
                        Properties.Resources.Button_Save,
                        Properties.Resources.Button_DontSave, Properties.Resources.Button_Cancel
                    }, 0, ManagedMessageBoxIcon.Save);

                if (mres.ClickedButtonIndex == 2)
                {
                    // Cancel any further operation
                    responses[0] = false;
                    return;
                }

                if (mres.ClickedButtonIndex == 0)
                {
                    // Save changes and return the save operation result to user
                    object[] res = new object[1];
                    CommandsManager.CMD.Execute("tcl.save.profile", new object[] { }, out res);
                    responses[0] = res[0];
                    return;
                }
                else
                {
                    responses[0] = true;
                    return;// Continue regardless of changes
                }
            }

            responses[0] = true;// No save required
        }
    }
}
