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
    * Pause Selected Timer Counter.
    * 
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Start/Resume All Timer Counters", "tcl.tcc.startresume.all", "tcl.core")]
    class StartResumeAllTimersCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];

            if (TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length == 0)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_NoTimerCounterInProfile);
                return;
            }
            if (TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity)
            {
                // Check for password first
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    Trace.TraceError(Properties.Resources.Error_CannotPauseTimerCounterIncorrectPassword);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotPauseTimerCounterIncorrectPassword);
                    return;
                }
            }
            foreach (TimerCounter tc in TCLCoreService.TCLC.CurrentProfile.TimerCounters)
                tc.StartTimer();
        }
    }
}
