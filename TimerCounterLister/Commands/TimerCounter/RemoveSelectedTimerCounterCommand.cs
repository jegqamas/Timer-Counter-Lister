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
    * Remove selected Timer Counter, it will ask to confirm first.
    * 
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Remove Selected Timer Counter", "tcl.timercounter.remove", "tcl.core")]
    class RemoveSelectedTimerCounterCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];

            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
                return;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
                return;

            // Check for password first
            if (TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity)
            {
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    Trace.TraceError(Properties.Resources.Error_CannotRemoveSelectedTimerCounterIncorrectPassword);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotRemoveSelectedTimerCounterIncorrectPassword);
                    return;
                }
            }
            // Ask to confirm
            ManagedMessageBoxResult result = ManagedMessageBox.ShowQuestionMessage(Properties.Resources.Message_AreYouSureToRemoveTimerCounter, Properties.Resources.MessageCaption_RemoveTimerCounter);
            if (result.ClickedButtonIndex == 0)
            {
                TCLCoreService.TCLC.CurrentProfile.RemoveTimerCounter(TCLCoreService.TCLC.SelectedTimerCounterIndex);
            }
        }
    }
}
