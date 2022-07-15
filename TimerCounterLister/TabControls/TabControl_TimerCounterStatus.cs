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

namespace TimerCounterLister
{
    [Export(typeof(ITabControl))]
    [ControlInfo("Timer Counter Status", "tcl.tc.timercounterstatus")]
    [TabControlResourceInfo("TC_Name_TimerCounterStatus", "time")]
    class TabControl_TimerCounterStatus : ITabControl
    {
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_description;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private System.Windows.Forms.TabPage tabPage_timer_counter;
        private System.Windows.Forms.TextBox textBox_Balance;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.TextBox textBox_cost_per_minute;
        private System.Windows.Forms.TextBox textBox_cost_so_far;
        private System.Windows.Forms.Label label_cost_so_far;
        private System.Windows.Forms.TextBox textBox_time_passed_seconds;
        private System.Windows.Forms.TextBox textBox_time_passed;
        private System.Windows.Forms.Label label_time_passed;
        private System.Windows.Forms.TextBox textBox_timercounter_name;
        private System.Windows.Forms.TextBox textBox_currency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl_TimerCounterStatus));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_timer_counter = new System.Windows.Forms.TabPage();
            this.textBox_currency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Balance = new System.Windows.Forms.TextBox();
            this.label_balance = new System.Windows.Forms.Label();
            this.textBox_cost_per_minute = new System.Windows.Forms.TextBox();
            this.textBox_cost_so_far = new System.Windows.Forms.TextBox();
            this.label_cost_so_far = new System.Windows.Forms.Label();
            this.textBox_time_passed_seconds = new System.Windows.Forms.TextBox();
            this.textBox_time_passed = new System.Windows.Forms.TextBox();
            this.label_time_passed = new System.Windows.Forms.Label();
            this.tabPage_description = new System.Windows.Forms.TabPage();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.textBox_timercounter_name = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_timer_counter.SuspendLayout();
            this.tabPage_description.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_timer_counter);
            this.tabControl1.Controls.Add(this.tabPage_description);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage_timer_counter
            // 
            resources.ApplyResources(this.tabPage_timer_counter, "tabPage_timer_counter");
            this.tabPage_timer_counter.Controls.Add(this.textBox_currency);
            this.tabPage_timer_counter.Controls.Add(this.label1);
            this.tabPage_timer_counter.Controls.Add(this.textBox_Balance);
            this.tabPage_timer_counter.Controls.Add(this.label_balance);
            this.tabPage_timer_counter.Controls.Add(this.textBox_cost_per_minute);
            this.tabPage_timer_counter.Controls.Add(this.textBox_cost_so_far);
            this.tabPage_timer_counter.Controls.Add(this.label_cost_so_far);
            this.tabPage_timer_counter.Controls.Add(this.textBox_time_passed_seconds);
            this.tabPage_timer_counter.Controls.Add(this.textBox_time_passed);
            this.tabPage_timer_counter.Controls.Add(this.label_time_passed);
            this.tabPage_timer_counter.Name = "tabPage_timer_counter";
            this.tabPage_timer_counter.UseVisualStyleBackColor = true;
            // 
            // textBox_currency
            // 
            this.textBox_currency.BackColor = System.Drawing.Color.White;
            this.textBox_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_currency, "textBox_currency");
            this.textBox_currency.Name = "textBox_currency";
            this.textBox_currency.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_Balance
            // 
            this.textBox_Balance.BackColor = System.Drawing.Color.White;
            this.textBox_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_Balance, "textBox_Balance");
            this.textBox_Balance.Name = "textBox_Balance";
            this.textBox_Balance.ReadOnly = true;
            // 
            // label_balance
            // 
            resources.ApplyResources(this.label_balance, "label_balance");
            this.label_balance.Name = "label_balance";
            // 
            // textBox_cost_per_minute
            // 
            this.textBox_cost_per_minute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_cost_per_minute, "textBox_cost_per_minute");
            this.textBox_cost_per_minute.Name = "textBox_cost_per_minute";
            this.textBox_cost_per_minute.ReadOnly = true;
            // 
            // textBox_cost_so_far
            // 
            this.textBox_cost_so_far.BackColor = System.Drawing.Color.White;
            this.textBox_cost_so_far.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_cost_so_far, "textBox_cost_so_far");
            this.textBox_cost_so_far.Name = "textBox_cost_so_far";
            this.textBox_cost_so_far.ReadOnly = true;
            // 
            // label_cost_so_far
            // 
            resources.ApplyResources(this.label_cost_so_far, "label_cost_so_far");
            this.label_cost_so_far.Name = "label_cost_so_far";
            // 
            // textBox_time_passed_seconds
            // 
            this.textBox_time_passed_seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_time_passed_seconds, "textBox_time_passed_seconds");
            this.textBox_time_passed_seconds.Name = "textBox_time_passed_seconds";
            this.textBox_time_passed_seconds.ReadOnly = true;
            // 
            // textBox_time_passed
            // 
            this.textBox_time_passed.BackColor = System.Drawing.Color.White;
            this.textBox_time_passed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_time_passed, "textBox_time_passed");
            this.textBox_time_passed.Name = "textBox_time_passed";
            this.textBox_time_passed.ReadOnly = true;
            // 
            // label_time_passed
            // 
            resources.ApplyResources(this.label_time_passed, "label_time_passed");
            this.label_time_passed.Name = "label_time_passed";
            // 
            // tabPage_description
            // 
            this.tabPage_description.Controls.Add(this.richTextBox_desc);
            resources.ApplyResources(this.tabPage_description, "tabPage_description");
            this.tabPage_description.Name = "tabPage_description";
            this.tabPage_description.UseVisualStyleBackColor = true;
            // 
            // richTextBox_desc
            // 
            this.richTextBox_desc.BackColor = System.Drawing.Color.White;
            this.richTextBox_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox_desc, "richTextBox_desc");
            this.richTextBox_desc.Name = "richTextBox_desc";
            this.richTextBox_desc.ReadOnly = true;
            // 
            // textBox_timercounter_name
            // 
            this.textBox_timercounter_name.BackColor = System.Drawing.Color.White;
            this.textBox_timercounter_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_timercounter_name, "textBox_timercounter_name");
            this.textBox_timercounter_name.Name = "textBox_timercounter_name";
            this.textBox_timercounter_name.ReadOnly = true;
            // 
            // TabControl_TimerCounterStatus
            // 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_timercounter_name);
            this.Name = "TabControl_TimerCounterStatus";
            resources.ApplyResources(this, "$this");
            this.tabControl1.ResumeLayout(false);
            this.tabPage_timer_counter.ResumeLayout(false);
            this.tabPage_timer_counter.PerformLayout();
            this.tabPage_description.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public override void Initialize()
        {
            base.Initialize();

            TCLCoreService.TCLC.SelectedTimerCounterIndexChanged += TCLC_SelectedTimerCounterIndexChanged;
            TCLCoreService.TCLC.TimerCounterBalanceChanged += TCLC_TimerCounterBalanceChanged;
            TCLCoreService.TCLC.TimerCounterCostPerMinuteChanged += TCLC_TimerCounterCostPerMinuteChanged;
            TCLCoreService.TCLC.TimerCounterCostSoFarChanged += TCLC_TimerCounterCostSoFarChanged;
            TCLCoreService.TCLC.TimerCounterCurrencyChanged += TCLC_TimerCounterCurrencyChanged;
            TCLCoreService.TCLC.TimerCounterDescriptionChanged += TCLC_TimerCounterDescriptionChanged;
            TCLCoreService.TCLC.TimerCounterNameChanged += TCLC_TimerCounterNameChanged;
            TCLCoreService.TCLC.TimerCounterTimePassedInSecondsChanged += TCLC_TimerCounterTimePassedInSecondsChanged;

            TCLCoreService.TCLC.TimerCounterBackgroundColorChanged += TCLC_TimerCounterBackgroundColorChanged;
            TCLCoreService.TCLC.TimerCounterFontChanged += TCLC_TimerCounterFontChanged;
            TCLCoreService.TCLC.TimerCounterTextColorChanged += TCLC_TimerCounterTextColorChanged;

            ClearAll();
        }

        private TimerCounter current_timer_counter;
        private bool is_timer_loaded;
        private void RefreshStatus()
        {
            is_timer_loaded = false;
            current_timer_counter = null;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
                return;
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
                return;

            current_timer_counter = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];

            textBox_timercounter_name.Text = current_timer_counter.Name;
            textBox_time_passed.Text = current_timer_counter.GetTimePassedAs_TimeSpan_Milli(current_timer_counter.TimePassedInSeconds);
            textBox_time_passed_seconds.Text = current_timer_counter.GetTimePassedAsDetails1(current_timer_counter.TimePassedInSeconds);
            textBox_cost_so_far.Text = current_timer_counter.CostSoFar.ToString();
            textBox_cost_per_minute.Text = current_timer_counter.CostPerMinute + " " + current_timer_counter.Currency + " " + Properties.Resources.Word_PerMinute;
            textBox_Balance.Text = current_timer_counter.Balance.ToString();
            textBox_currency.Text = current_timer_counter.Currency;
            richTextBox_desc.Text = current_timer_counter.Description;
            is_timer_loaded = true;
            ApplyFontColor();
        }
        private void ClearAll()
        {
            textBox_Balance.Text = "0.0";
            textBox_cost_per_minute.Text = "0.0 Per Minute";
            textBox_cost_so_far.Text = "0.0";
            textBox_timercounter_name.Text = "";
            textBox_time_passed.Text = "00:00:00.000";
            textBox_time_passed_seconds.Text = "0.0 Second";
            richTextBox_desc.Text = "";

            textBox_time_passed.Font =
    textBox_cost_so_far.Font = textBox_Balance.Font =
    textBox_currency.Font = new System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Regular);

            textBox_time_passed.ForeColor =
          textBox_cost_so_far.ForeColor = textBox_Balance.ForeColor =
          textBox_currency.ForeColor = System.Drawing.Color.Black;

            textBox_time_passed.BackColor =
     textBox_cost_so_far.BackColor = textBox_Balance.BackColor =
     textBox_currency.BackColor = System.Drawing.Color.White;
        }
        private void ApplyFontColor()
        {
            if (!is_timer_loaded)
                return;
            if (current_timer_counter == null)
                return;

            textBox_time_passed.Font =
                textBox_cost_so_far.Font = textBox_Balance.Font =
                textBox_currency.Font = current_timer_counter.CounterFont;

            textBox_time_passed.ForeColor =
          textBox_cost_so_far.ForeColor = textBox_Balance.ForeColor =
          textBox_currency.ForeColor = current_timer_counter.CounterTextColor;

            textBox_time_passed.BackColor =
     textBox_cost_so_far.BackColor = textBox_Balance.BackColor =
     textBox_currency.BackColor = current_timer_counter.CounterBackgroundColor;
        }
        private void TCLC_SelectedTimerCounterIndexChanged(object sender, System.EventArgs e)
        {
            ClearAll();
            RefreshStatus();
        }
        private void TCLC_TimerCounterNameChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_timercounter_name.Text = current_timer_counter.Name;
                }
            }
        }
        private void TCLC_TimerCounterDescriptionChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    richTextBox_desc.Text = current_timer_counter.Description;
                }
            }
        }
        private void TCLC_TimerCounterCurrencyChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_cost_per_minute.Text = current_timer_counter.CostPerMinute + " " + current_timer_counter.Currency;
                    textBox_currency.Text = current_timer_counter.Currency;
                }
            }
        }
        private void TCLC_TimerCounterCostSoFarChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_cost_so_far.Text = current_timer_counter.CostSoFar.ToString();
                }
            }
        }
        private void TCLC_TimerCounterCostPerMinuteChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_cost_per_minute.Text = current_timer_counter.CostPerMinute + " " + current_timer_counter.Currency + " " + Properties.Resources.Word_PerMinute;
                }
            }
        }
        private void TCLC_TimerCounterBalanceChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_Balance.Text = current_timer_counter.Balance + " " + current_timer_counter.Currency;
                }
            }
        }
        private void TCLC_TimerCounterTimePassedInSecondsChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    textBox_time_passed.Text = current_timer_counter.GetTimePassedAs_TimeSpan_Milli(current_timer_counter.TimePassedInSeconds);
                    textBox_time_passed_seconds.Text = current_timer_counter.GetTimePassedAsDetails1(current_timer_counter.TimePassedInSeconds);
                }
            }
        }
        private void TCLC_TimerCounterTextColorChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    ApplyFontColor();
                }
            }
        }
        private void TCLC_TimerCounterFontChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    ApplyFontColor();
                }
            }
        }
        private void TCLC_TimerCounterBackgroundColorChanged(object sender, System.EventArgs e)
        {
            if (!is_timer_loaded)
                return;
            if (sender == null)
                return;
            if (sender is TimerCounter)
            {
                TimerCounter tt = (TimerCounter)sender;
                if (tt.Name == current_timer_counter.Name)
                {
                    ApplyFontColor();
                }
            }
        }
    }
}
