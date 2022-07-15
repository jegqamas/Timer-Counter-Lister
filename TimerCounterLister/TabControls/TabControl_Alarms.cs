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
using System.Windows.Forms;

namespace TimerCounterLister
{
    [Export(typeof(ITabControl))]
    [ControlInfo("Alarms", "tcl.tc.alarms")]
    [TabControlResourceInfo("TC_Name_Alarms", "timeline_marker")]
    class TabControl_Alarms : ITabControl
    {
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl_Alarms));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TimerCounterLister.Properties.Resources.add;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TimerCounterLister.Properties.Resources.cross;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TimerCounterLister.Properties.Resources.arrow_rotate_clockwise;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // TabControl_Alarms
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabControl_Alarms";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public override void Initialize()
        {
            base.Initialize();
            TCLCoreService.TCLC.NewProfileStarted += TCLC_NewProfileStarted;
            TCLCoreService.TCLC.ProfileOpened += TCLC_ProfileOpened;
            TCLCoreService.TCLC.SelectedTimerCounterIndexChanged += TCLC_SelectedTimerCounterIndexChanged;
            TCLCoreService.TCLC.TimerCounterAlarmAdded += TCLC_TimerCounterAlarmAdded;
            TCLCoreService.TCLC.TimerCounterAlarmRemoved += TCLC_TimerCounterAlarmRemoved;
            TCLCoreService.TCLC.TimerCounterTimePassedInSecondsChanged += TCLC_TimerCounterTimePassedInSecondsChanged;
            TCLCoreService.TCLC.TimerCounterAlarmTrigger += TCLC_TimerCounterAlarmTrigger;
        }
        public override void LoadSettings()
        {
            listView1.Columns[0].Width = Properties.Settings.Default.TimerCounterAlarm_Column0;
            listView1.Columns[1].Width = Properties.Settings.Default.TimerCounterAlarm_Column1;
            listView1.Columns[2].Width = Properties.Settings.Default.TimerCounterAlarm_Column2;
            listView1.Columns[3].Width = Properties.Settings.Default.TimerCounterAlarm_Column3;
            listView1.Columns[4].Width = Properties.Settings.Default.TimerCounterAlarm_Column4;
            listView1.Columns[5].Width = Properties.Settings.Default.TimerCounterAlarm_Column5;
        }
        public override void SaveSettings()
        {
            Properties.Settings.Default.TimerCounterAlarm_Column0 = listView1.Columns[0].Width;
            Properties.Settings.Default.TimerCounterAlarm_Column1 = listView1.Columns[1].Width;
            Properties.Settings.Default.TimerCounterAlarm_Column2 = listView1.Columns[2].Width;
            Properties.Settings.Default.TimerCounterAlarm_Column3 = listView1.Columns[3].Width;
            Properties.Settings.Default.TimerCounterAlarm_Column4 = listView1.Columns[4].Width;
            Properties.Settings.Default.TimerCounterAlarm_Column5 = listView1.Columns[5].Width;
        }
        private TimerCounter tc;
        private void RefreshTimers()
        {
            listView1.Items.Clear();
            tc = null;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
                return;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
                return;

            tc = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];

            foreach (TimerCounterAlarm alarm in tc.Alarms)
            {
                ListViewItem it = new ListViewItem();
                it.Text = alarm.Name;
                it.SubItems.Add(alarm.Description);
                it.SubItems.Add(tc.GetTimePassedAsDetails(alarm.TriggerTimeLeft));
                it.SubItems.Add(tc.GetTimePassedAsDetails(alarm.TriggerTime));
                it.SubItems.Add(alarm.PauseTimerCounterOnTrigger ? Properties.Resources.Word_Yes : Properties.Resources.Word_No);
                it.SubItems.Add(alarm.TimerTriggered ? Properties.Resources.Word_Yes : Properties.Resources.Word_No);

                listView1.Items.Add(it);
            }
        }

        public int SelectedAlarmIndex
        {
            get
            {
                if (listView1.SelectedItems.Count != 1)
                    return -1;
                return listView1.SelectedItems[0].Index;
            }
        }
        // Add alarm
        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.alarm.add");
        }
        // Remove selected alarm
        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.alarm.remove");
        }
        private void TCLC_TimerCounterAlarmRemoved(object sender, System.EventArgs e)
        {
            RefreshTimers();
        }
        private void TCLC_TimerCounterAlarmAdded(object sender, System.EventArgs e)
        {
            RefreshTimers();
        }
        private void TCLC_SelectedTimerCounterIndexChanged(object sender, System.EventArgs e)
        {
            RefreshTimers();
        }
        private void TCLC_ProfileOpened(object sender, System.EventArgs e)
        {
            RefreshTimers();
        }
        private void TCLC_NewProfileStarted(object sender, System.EventArgs e)
        {
            RefreshTimers();
        }
        // On tick
        private void TCLC_TimerCounterTimePassedInSecondsChanged(object sender, System.EventArgs e)
        {
            if (tc == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name != tc.Name)
                    return;
                for (int i = 0; i < tc.Alarms.Length; i++)
                {
                    for (int j = 0; j < listView1.Items.Count; j++)
                    {
                        if (listView1.Items[j].Text == tc.Alarms[i].Name)
                        {
                            listView1.Items[j].SubItems[2].Text = tc.GetTimePassedAsDetails(tt.Alarms[i].TriggerTimeLeft);
                            break;
                        }
                    }
                }
            }
        }
        private void TCLC_TimerCounterAlarmTrigger(object sender, TimerCounterAlarmTriggerEventArgs e)
        {
            if (tc == null)
                return;
            if (e.ParentTimerCounter.Name != tc.Name)
                return;

            for (int j = 0; j < listView1.Items.Count; j++)
            {
                if (listView1.Items[j].Text == e.TimerCounterAlarm.Name)
                {
                    listView1.Items[j].SubItems[5].Text = e.TimerCounterAlarm.TimerTriggered ? Properties.Resources.Word_Yes : Properties.Resources.Word_No;
                    break;
                }
            }
        }
        // Reset selected timer
        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;

            CommandsManager.CMD.Execute("tcl.timercounter.alarm.reset");

            for (int i = 0; i < tc.Alarms.Length; i++)
            {
                if (tc.Alarms[i].Name == listView1.SelectedItems[0].Text)
                {
                    listView1.SelectedItems[0].SubItems[5].Text = tc.Alarms[i].TimerTriggered ? Properties.Resources.Word_Yes : Properties.Resources.Word_No;
                    break;
                }
            }
        }
    }
}
