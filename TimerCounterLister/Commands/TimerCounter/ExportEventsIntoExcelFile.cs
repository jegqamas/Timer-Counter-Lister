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

/* This file which part of Timer Counter Lister uses ClosedXML, licensed under the MIT License.

MIT License

Copyright (c) 2016 ClosedXML

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/
using System;
using System.IO;
using System.Data;
using System.Diagnostics;
using ManagedUI;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.Data.OleDb;

namespace TimerCounterLister
{

    [Export(typeof(ICommand))]
    [CommandInfo("Export Timer Counter Events Into Excel File", "tcl.timercounter.events.export.excel", "tcl.core")]
    class ExportEventsIntoExcelFile : ICommand
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

            string logFileName = string.Format("{0}-{1}-events.xlsx", DateTime.Now.ToLocalTime().ToString(), tc.Name);
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

                // 1 Create a data set
                DataSet ds = new DataSet();
                ds.Tables.Add(Properties.Resources.Word_Events);

                // 2 Add the columns

                ds.Tables[0].Columns.Add(Properties.Resources.Word_DateOfEvent);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_EventName);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_EventDescription);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_TimePassed);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_CostAfterEvent);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_BalanceAfterEvent);
                ds.Tables[0].Columns.Add(Properties.Resources.Word_CurrencyAfterEvent);

                // 3 Add the row of the columns !
                ds.Tables[0].Rows.Add(Properties.Resources.Word_DateOfEvent, Properties.Resources.Word_EventName, Properties.Resources.Word_EventDescription, Properties.Resources.Word_TimePassed, Properties.Resources.Word_CostAfterEvent, Properties.Resources.Word_BalanceAfterEvent, Properties.Resources.Word_CurrencyAfterEvent);
                // 4 Add the data ...
                int j = 0;
                foreach (TimerCounterEvent ev in tc.Events)
                {
                    ds.Tables[0].Rows.Add();

                    ds.Tables[0].Rows[j][0] = ev.DateOfEvent.ToLocalTime().ToString();
                    ds.Tables[0].Rows[j][1] = ev.Name;
                    ds.Tables[0].Rows[j][2] = ev.Description;
                    ds.Tables[0].Rows[j][3] = tc.GetTimePassedAsDetails(ev.Status_TimePassedInSeconds);
                    ds.Tables[0].Rows[j][4] = ev.Status_CostSoFar;
                    ds.Tables[0].Rows[j][5] = ev.Status_Balance;
                    ds.Tables[0].Rows[j][6] = ev.Status_Currency;
                    j++;
                }

                var wb = new XLWorkbook();

                // Add all DataTables in the DataSet as a worksheets
                wb.Worksheets.Add(ds);

                wb.SaveAs(logFileName);
                wb.Dispose();

                try
                {
                    System.Diagnostics.Process.Start(logFileName);
                }
                catch { }

                tc.AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterEventsExportToExcelFile, Properties.Resources.TimerEvent_ExportEventsIntoExcel, Properties.Resources.TimerDescDesc_ExportEventsIntoExcel, DateTime.Now, tc.CostSoFar, tc.Balance, tc.TimePassedInSeconds, tc.Currency));
            }
        }
    }
}
