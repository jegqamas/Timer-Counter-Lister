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
using System.Collections.Generic;

namespace TimerCounterLister
{

    [Export(typeof(ICommand))]
    [CommandInfo("Export Timer Counter Events Into Text File", "tcl.timercounter.events.export.text", "tcl.core")]
    class ExportEventsIntoTextFileCommand : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];

            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseSelectTimerCounter);
                return;
            }
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseSelectTimerCounter);
                return;
            }

            // Get the timer
            TimerCounter tc = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];

            string logFileName = string.Format("{0}-{1}-events.txt", DateTime.Now.ToLocalTime().ToString(), tc.Name);
            logFileName = logFileName.Replace(":", "");
            logFileName = logFileName.Replace("/", "-");
           
            bool ok = false;
            Utilities.ShowOpenSaveDialog(true, Properties.Resources.Title_ExportTimerCounterEventsIntoText, Properties.Resources.Filter_Text, ref logFileName, out ok);
            if (ok)
            {
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



                List<string> lines = new List<string>();

                foreach (TimerCounterEvent ev in tc.Events)
                {
                    lines.Add(string.Format("{0} [{1}]: {2}, " + Properties.Resources.Word_TimePassed + ": {3}, " + Properties.Resources.Word_CostAfterEvent + ": {4}, " + Properties.Resources.Word_BalanceAfterEvent + ": {5}, " + Properties.Resources.Word_CurrencyAfterEvent + " {6}",
                        ev.DateOfEvent.ToLocalTime().ToString(),
                        ev.Name,
                        ev.Description,
                        tc.GetTimePassedAsDetails(ev.Status_TimePassedInSeconds),
                        ev.Status_CostSoFar,
                        ev.Status_Balance,
                        ev.Status_Currency
                        ));
                }
                System.IO.File.WriteAllLines(logFileName, lines.ToArray());
                try
                {
                    System.Diagnostics.Process.Start(logFileName);
                }
                catch { }

                tc.AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterEventsExportToTextFile, Properties.Resources.TimerEvent_ExportEventsIntoText, Properties.Resources.TimerEventDesc_ExportEventsIntoText, DateTime.Now, tc.CostSoFar, tc.Balance, tc.TimePassedInSeconds, tc.Currency));
            }
        }
    }
}
