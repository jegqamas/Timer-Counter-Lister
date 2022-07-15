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
    * Add New Timer Counter, show a dialog that allows to enter new timer counter details.
    * 
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Add New Timer Counter", "tcl.timercounter.add", "tcl.core")]
    class AddNewTimerCounterCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];

            // Check for password first
            if (TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity)
            {
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    Trace.TraceError(Properties.Resources.Error_CannotAddNewTimerCounterIncorrectPassword);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotAddNewTimerCounterIncorrectPassword);
                    return;
                }
            }
            // Add new timer
            FormAddTimerCounter frm = new FormAddTimerCounter();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TimerCounter tt = new TimerCounter(frm.EnteredName, frm.EnteredDescription, DateTime.Now, frm.EnteredCurrency, frm.EnteredCostPerMinute, 0, frm.EnteredBalance, frm.EnteredAllowResumeTimerWithDifferenceAdd, frm.EnteredTimerClockRate);
                tt.CounterFont = frm.EnteredCounterFont;
                tt.CounterTextColor = frm.EnteredCounterTextColor;
                tt.CounterBackgroundColor = frm.EnteredCounterBackgroundColor;
                tt.TimerIntervalInMilliseconds = frm.EnteredTimerClockRate;
                // Add it
                TCLCoreService.TCLC.CurrentProfile.AddTimerCounter(tt);

                // Add events
                // 1 timer add
                tt.AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterAdd, Properties.Resources.TimerEvent_TimerAdd, Properties.Resources.TimerEventDesc_TimerAdd, DateTime.Now, tt.CostSoFar, tt.Balance, tt.TimePassedInSeconds, tt.Currency));
                // 2 timer start ?
                if (frm.EnteredStartTimerAfterAdd)
                {
                    tt.StartTimer();
                }
            }
        }
    }
}
