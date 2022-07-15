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
    [CommandInfo("Reset Timer Counter Alarm", "tcl.timercounter.alarm.reset", "tcl.core")]
    class ResetAlarm : ICommand
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
            Lazy<ITabControl, IControlInfo> tab_control = GUIService.GUI.GetTabControl("tcl.tc.alarms");
            if (tab_control == null)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_CannotRemoveAlarmPleaseSelectAlarm);
                return;
            }
            int index = ((TabControl_Alarms)tab_control.Value).SelectedAlarmIndex;

            if (index < 0)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_CannotResetAlarmPleaseSelectAlarm);
                return;
            }
            // Get the timer
            TimerCounter tc = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];
            if (index >= tc.Alarms.Length)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_CannotResetAlarmPleaseSelectAlarm);
                return;
            }

            if (TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity)
            {
                // Check for password first
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    Trace.TraceError(Properties.Resources.Error_CannotTimerCounterPayIncorrectPassword);
                    GUIService.GUI.OnProgressFinished(Properties.Resources.Error_CannotTimerCounterPayIncorrectPassword);
                    return;
                }
            }


            tc.Alarms[index].TriggerTimeLeft = tc.Alarms[index].TriggerTime;
            tc.Alarms[index].TimerTriggered = false;

            tc.AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterAlarmReset, Properties.Resources.TimerEvent_AlarmReset, Properties.Resources.TimerEventDesc_AlarmReset + " '" + tc.Alarms[index].Name + "' ", DateTime.Now, tc.CostSoFar, tc.Balance, tc.TimePassedInSeconds, tc.Currency));
        }

    }
}
