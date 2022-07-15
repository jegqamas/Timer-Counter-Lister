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
using System.Windows.Forms;
using ManagedUI;
using System.ComponentModel.Composition;

namespace TimerCounterLister
{
    [Export(typeof(ITabControl))]
    [ControlInfo("Timer Counter Events", "tcl.tc.timercounterevents")]
    [TabControlResourceInfo("TC_Name_TimerCounterEvents", "comments")]
    class TabControl_TimerCounterEvents : ITabControl
    {
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListView listView1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl_TimerCounterEvents));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
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
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TimerCounterLister.Properties.Resources.page_white_edit;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TimerCounterLister.Properties.Resources.page_white_excel;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // TabControl_TimerCounterEvents
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabControl_TimerCounterEvents";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public override void Initialize()
        {
            base.Initialize();

            TCLCoreService.TCLC.SelectedTimerCounterIndexChanged += TCLC_SelectedTimerCounterIndexChanged;

            TCLCoreService.TCLC.TimerCounterEventAdded += TCLC_TimerCounterEventAdded;
            TCLCoreService.TCLC.TimerCounterEventRemoved += TCLC_TimerCounterEventRemoved;
        }
        public override void LoadSettings()
        {
            listView1.Columns[0].Width = Properties.Settings.Default.TimerCounterEvents_Column0;
            listView1.Columns[1].Width = Properties.Settings.Default.TimerCounterEvents_Column1;
            listView1.Columns[2].Width = Properties.Settings.Default.TimerCounterEvents_Column2;
            listView1.Columns[3].Width = Properties.Settings.Default.TimerCounterEvents_Column3;
            listView1.Columns[4].Width = Properties.Settings.Default.TimerCounterEvents_Column4;
            listView1.Columns[5].Width = Properties.Settings.Default.TimerCounterEvents_Column5;
            listView1.Columns[6].Width = Properties.Settings.Default.TimerCounterEvents_Column6;
        }
        public override void SaveSettings()
        {
            // Save settings
            Properties.Settings.Default.TimerCounterEvents_Column0 = listView1.Columns[0].Width;
            Properties.Settings.Default.TimerCounterEvents_Column1 = listView1.Columns[1].Width;
            Properties.Settings.Default.TimerCounterEvents_Column2 = listView1.Columns[2].Width;
            Properties.Settings.Default.TimerCounterEvents_Column3 = listView1.Columns[3].Width;
            Properties.Settings.Default.TimerCounterEvents_Column4 = listView1.Columns[4].Width;
            Properties.Settings.Default.TimerCounterEvents_Column5 = listView1.Columns[5].Width;
            Properties.Settings.Default.TimerCounterEvents_Column6 = listView1.Columns[6].Width;
        }

        private void RefreshEvents()
        {
            listView1.Items.Clear();
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
                return;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
            {
                TimerCounter tt = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];

                foreach (TimerCounterEvent ev in tt.Events)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ev.Name;
                    item.SubItems.Add(ev.Description);
                    item.SubItems.Add(ev.DateOfEvent.ToLocalTime().ToString());
                    // Status
                    item.SubItems.Add(tt.GetTimePassedAs_TimeSpan_Milli(ev.Status_TimePassedInSeconds) + " (" + tt.GetTimePassedAsDetails1(ev.Status_TimePassedInSeconds) + ")");
                    item.SubItems.Add(ev.Status_CostSoFar.ToString());
                    item.SubItems.Add(ev.Status_Balance.ToString());
                    item.SubItems.Add(ev.Status_Currency.ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        private void TCLC_TimerCounterEventRemoved(object sender, EventArgs e)
        {
            RefreshEvents();
        }
        private void TCLC_TimerCounterEventAdded(object sender, EventArgs e)
        {
            RefreshEvents();
        }
        private void TCLC_SelectedTimerCounterIndexChanged(object sender, System.EventArgs e)
        {
            RefreshEvents();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.events.export.text");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.events.export.excel");
        }
    }
}
