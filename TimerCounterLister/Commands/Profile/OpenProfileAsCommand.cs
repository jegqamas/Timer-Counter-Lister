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
    * Open Project As, open dialog for browsing file for profile then execute "Open profile [tcl.open.profile]" command.
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */
    [Export(typeof(ICommand))]
    [CommandInfo("Open Profile As", "tcl.open.profile.as", "tcl.core")]
    class OpenProfileAsCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];
            // Check timers
            object[] res0 = new object[1];
            CommandsManager.CMD.Execute("tcl.profile.check.profile.close.ability", new object[] { }, out res0);
            if (!(bool)res0[0])
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_TimersNeedToPauseToOpenProfile);
                return;
            }
            string filePath = "";
            if (TCLCoreService.TCLC.CurrentProfilePath == "")
                filePath = TCLCoreService.TCLC.CurrentProfile.Name + ".tclp";
            else
                filePath = TCLCoreService.TCLC.CurrentProfilePath;
            bool ok = false;
            Utilities.ShowOpenSaveDialog(false, Properties.Resources.Title_OpenProfile, Properties.Resources.Filter_TCLP, ref filePath, out ok);
            if (ok)
            {
                //OpenProjectAs(filePath);
                CommandsManager.CMD.Execute("tcl.open.profile", new object[] { filePath });
            }
            else
                TCLCoreService.TCLC.OnProfileCannotBeOpened();
        }
    }
}
