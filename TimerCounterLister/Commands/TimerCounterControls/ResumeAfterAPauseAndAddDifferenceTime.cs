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
    * Resume Selected Timer Counter, add difference time between last pause and the moment of the resume.
    * 
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Resume Selected Timer Counter And Add Difference", "tcl.tcc.resume.with.difference", "tcl.core")]
    class ResumeAfterAPauseAndAddDifferenceTime : ICommand
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
            if (!tc.IsTimerPaused)
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_SelectedTimerCounterAlreadyRunning);
                return;
            }
            if (tc.BlockResumeWithAdd)
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_CannotResumeWithAddNotAllowed);
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
            // Before the resume, we need to update timer with details. First, check the events looking for the last one of pause
            DateTime date_of_event = DateTime.Now;
            for (int i = tc.Events.Length - 1; i >= 0; i--)
            {
                if (tc.Events[i].TimerEventType == TimerCounterEventType.TimerCounterPause)
                {
                    date_of_event = tc.Events[i].DateOfEvent;
                    break;
                }
            }
            // See the diffence between 2 dates, now and event
            TimeSpan diff = DateTime.Now.Subtract(date_of_event);

            // Add this to the time passed in seconds
            tc.TimePassedInSeconds += diff.TotalSeconds;
            tc.CostSoFar += diff.TotalSeconds * (tc.CostPerMinute / 60);
            tc.StartTimer(true, tc.GetTimePassedAs_TimeSpan_Milli(diff.TotalSeconds) + " (" + tc.GetTimePassedAsDetails1(diff.TotalSeconds) + ")");
        }

    }
}
