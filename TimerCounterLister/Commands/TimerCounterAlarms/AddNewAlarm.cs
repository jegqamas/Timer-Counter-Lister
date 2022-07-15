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
    [Export(typeof(ICommand))]
    [CommandInfo("Add New Timer Counter Alarm", "tcl.timercounter.alarm.add", "tcl.core")]
    class AddNewTimerCounterAlarm : ICommand
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
            if (TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity)
            {
                // Check for password first
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    Trace.TraceError(Properties.Resources.Error_CannotTimerCounteralarmAddIncorrectPassword);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotTimerCounteralarmAddIncorrectPassword);
                    return;
                }
            }

            // Get the timer
            TimerCounter tc = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];

            FormAddNewTimerCounterAlarm frm = new FormAddNewTimerCounterAlarm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TimerCounterAlarm alarm = new TimerCounterAlarm(frm.EnteredName, frm.EnteredDescription, frm.TimeToTriggerAfterInSeconds, frm.EnteredPauseTimerCounterOnTrigger, frm.EnteredSoundFile);
                alarm.TimerTriggered = frm.EnteredSetAlarmAsTriggered;
                tc.AddAlarm(alarm);

                tc.AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterAlarmAdd, Properties.Resources.TimerEvent_AlarmAdd, Properties.Resources.TimerEventDesc_TimerDesc + " " + alarm.TriggerTimeLeft + " " + Properties.Resources.Word_Seconds, DateTime.Now, tc.CostSoFar, tc.Balance, tc.TimePassedInSeconds, tc.Currency));
            }
        }
    }
}
