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
using ManagedUI;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace TimerCounterLister
{
    [Export(typeof(ITabControl))]
    [ControlInfo("Timer Counters", "tcl.tc.timercounters")]
    [TabControlResourceInfo("TC_Name_TimerCounters", "application_view_list")]
    class TabControl_TimerCounters : ITabControl
    {
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton_resume_with_difference;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl_TimerCounters));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_resume_with_difference = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.toolStripButton3,
            this.toolStripButton_resume_with_difference,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TimerCounterLister.Properties.Resources.time_add;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TimerCounterLister.Properties.Resources.time_delete;
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
            this.toolStripButton3.Image = global::TimerCounterLister.Properties.Resources.control_play;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton_resume_with_difference
            // 
            resources.ApplyResources(this.toolStripButton_resume_with_difference, "toolStripButton_resume_with_difference");
            this.toolStripButton_resume_with_difference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_resume_with_difference.Image = global::TimerCounterLister.Properties.Resources.control_play_blue;
            this.toolStripButton_resume_with_difference.Name = "toolStripButton_resume_with_difference";
            this.toolStripButton_resume_with_difference.Click += new System.EventHandler(this.toolStripButton_resume_with_difference_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::TimerCounterLister.Properties.Resources.control_pause;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripButton5
            // 
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::TimerCounterLister.Properties.Resources.time_go;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            resources.ApplyResources(this.toolStripButton6, "toolStripButton6");
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::TimerCounterLister.Properties.Resources.control_pause_blue;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripButton7
            // 
            resources.ApplyResources(this.toolStripButton7, "toolStripButton7");
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::TimerCounterLister.Properties.Resources.money;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            resources.ApplyResources(this.toolStripButton8, "toolStripButton8");
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::TimerCounterLister.Properties.Resources.money_delete;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
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
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // TabControl_TimerCounters
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabControl_TimerCounters";
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
            TCLCoreService.TCLC.TimerCounterAdded += TCLC_TimerCounterAdded;
            TCLCoreService.TCLC.TimerCounterBalanceChanged += TCLC_TimerCounterBalanceChanged;
            TCLCoreService.TCLC.TimerCounterCostPerMinuteChanged += TCLC_TimerCounterCostPerMinuteChanged;
            TCLCoreService.TCLC.TimerCounterCurrencyChanged += TCLC_TimerCounterCurrencyChanged;
            TCLCoreService.TCLC.TimerCounterDescriptionChanged += TCLC_TimerCounterDescriptionChanged;
            TCLCoreService.TCLC.TimerCounterNameChanged += TCLC_TimerCounterNameChanged;
            TCLCoreService.TCLC.TimerCounterTimePassedInSecondsChanged += TCLC_TimerCounterTimePassedInSecondsChanged;
            TCLCoreService.TCLC.SelectedTimerCounterIndexChanged += TCLC_SelectedTimerCounterIndexChanged;
            TCLCoreService.TCLC.TimerCounterRemoved += TCLC_TimerCounterRemoved;
            TCLCoreService.TCLC.TimerCounterCostSoFarChanged += TCLC_TimerCounterCostSoFarChanged;
        }
        public override void LoadSettings()
        {
            listView1.Columns[0].Width = Properties.Settings.Default.TimerCounters_Column0;
            listView1.Columns[1].Width = Properties.Settings.Default.TimerCounters_Column1;
            listView1.Columns[2].Width = Properties.Settings.Default.TimerCounters_Column2;
            listView1.Columns[3].Width = Properties.Settings.Default.TimerCounters_Column3;
            listView1.Columns[4].Width = Properties.Settings.Default.TimerCounters_Column4;
            listView1.Columns[5].Width = Properties.Settings.Default.TimerCounters_Column5;
            listView1.Columns[6].Width = Properties.Settings.Default.TimerCounters_Column6;
            listView1.Columns[7].Width = Properties.Settings.Default.TimerCounters_Column7;
        }
        public override void SaveSettings()
        {
            Properties.Settings.Default.TimerCounters_Column0 = listView1.Columns[0].Width;
            Properties.Settings.Default.TimerCounters_Column1 = listView1.Columns[1].Width;
            Properties.Settings.Default.TimerCounters_Column2 = listView1.Columns[2].Width;
            Properties.Settings.Default.TimerCounters_Column3 = listView1.Columns[3].Width;
            Properties.Settings.Default.TimerCounters_Column4 = listView1.Columns[4].Width;
            Properties.Settings.Default.TimerCounters_Column5 = listView1.Columns[5].Width;
            Properties.Settings.Default.TimerCounters_Column6 = listView1.Columns[6].Width;
            Properties.Settings.Default.TimerCounters_Column7 = listView1.Columns[7].Width;
        }
        private void RefreshCounters()
        {
            listView1.Items.Clear();
            toolStripButton_resume_with_difference.Enabled = false;
            for (int i = 0; i < TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length; i++)
            {
                TimerCounter tt = TCLCoreService.TCLC.CurrentProfile.TimerCounters[i];
                ListViewItem item = new ListViewItem();
                item.Text = tt.Name;
                item.SubItems.Add(tt.Description.Replace("\n", "|"));
                item.SubItems.Add(tt.GetTimePassedAsDetails(tt.TimePassedInSeconds));
                item.SubItems.Add(tt.CostSoFar.ToString());
                item.SubItems.Add(tt.CostPerMinute.ToString());
                item.SubItems.Add(tt.Balance.ToString());
                item.SubItems.Add(tt.Currency);
                item.SubItems.Add(tt.StartTime.ToLocalTime().ToString());

                item.Tag = i;

                listView1.Items.Add(item);
            }
        }
        private void CheckResumeTimerWithAddEnable()
        {
            toolStripButton_resume_with_difference.Enabled = false;

            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
            {
                return;
            }
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
            {
                return;
            }
            toolStripButton_resume_with_difference.Enabled = !TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex].BlockResumeWithAdd;
        }

        private bool is_selecting;

        private void TCLC_TimerCounterTimePassedInSecondsChanged(object sender, System.EventArgs e)
        {
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[2].Text = tt.GetTimePassedAsDetails(tt.TimePassedInSeconds);
                        //listView1.Items[i].SubItems[3].Text = tt.GetCostSoFar();
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterCostSoFarChanged(object sender, EventArgs e)
        {
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[3].Text = tt.CostSoFar.ToString();
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterNameChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = TCLCoreService.TCLC.CurrentProfile.TimerCounters[i].Name;
            }
        }
        private void TCLC_TimerCounterDescriptionChanged(object sender, System.EventArgs e)
        {
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[1].Text = tt.Description;
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterCurrencyChanged(object sender, System.EventArgs e)
        {
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[6].Text = tt.Currency.ToString();
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterCostPerMinuteChanged(object sender, System.EventArgs e)
        {
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[4].Text = tt.CostPerMinute.ToString();
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterBalanceChanged(object sender, System.EventArgs e)
        {
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == tt.Name)
                    {
                        listView1.Items[i].SubItems[5].Text = tt.Balance.ToString();
                        break;
                    }
                }
            }
        }
        private void TCLC_TimerCounterAdded(object sender, System.EventArgs e)
        {
            RefreshCounters();
        }
        private void TCLC_NewProfileStarted(object sender, EventArgs e)
        {
            RefreshCounters();
        }
        private void TCLC_ProfileOpened(object sender, System.EventArgs e)
        {
            RefreshCounters();
        }
        private void TCLC_TimerCounterRemoved(object sender, EventArgs e)
        {
            RefreshCounters();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.add");
        }
        private void TCLC_SelectedTimerCounterIndexChanged(object sender, EventArgs e)
        {
            if (is_selecting)
                return;
            is_selecting = true;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Selected = i == TCLCoreService.TCLC.SelectedTimerCounterIndex;
            }
            CheckResumeTimerWithAddEnable();
            is_selecting = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (is_selecting)
                return;
            is_selecting = true;
            if (listView1.SelectedItems.Count == 1)
                TCLCoreService.TCLC.SelectedTimerCounterIndex = listView1.SelectedItems[0].Index;
            else
                TCLCoreService.TCLC.SelectedTimerCounterIndex = -1;

            CheckResumeTimerWithAddEnable();
            is_selecting = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.remove");
        }
        // start/resume
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.tcc.startresume");
        }
        // pause
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.tcc.pause");
        }
        // resume with add
        private void toolStripButton_resume_with_difference_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.tcc.resume.with.difference");
        }
        // Start/Resume all
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.tcc.startresume.all");
        }
        // Pause all timers
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.tcc.pause.all");
        }
        // Pay
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.pay");
        }
        // Balance Transaction
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.timercounter.balance.transaction");
        }
    }
}
