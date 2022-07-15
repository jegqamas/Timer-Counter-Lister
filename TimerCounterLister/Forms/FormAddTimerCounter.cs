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
using System.Drawing;
using System.Windows.Forms;
using ManagedUI;

namespace TimerCounterLister
{
    public partial class FormAddTimerCounter : Form
    {
        public FormAddTimerCounter()
        {
            InitializeComponent();

            timeEdit_cost_per_minute.SetTime(1, false);
            timeEdit_start_balance.SetTime(0, false);

            //trackBar1.Value = Properties.Settings.Default.TimerIntervalInMilliseconds;
        }
        public string EnteredName { get { return textBox_timer_name.Text; } }
        public string EnteredDescription { get { return richTextBox_timer_description.Text; } }
        public double EnteredCostPerMinute { get { return timeEdit_cost_per_minute.GetSeconds(); } }
        public double EnteredBalance { get { return timeEdit_start_balance.GetSeconds(); } }
        public string EnteredCurrency { get { return textBox_currency.Text; } }
        public bool EnteredStartTimerAfterAdd { get { return checkBox_start_timer_instantly.Checked; } }
        public bool EnteredAllowResumeTimerWithDifferenceAdd { get { return checkBox_allow_resume_timer_with_difference_add.Checked; } }
        public Font EnteredCounterFont { get { return textBox_preview.Font; } }
        public Color EnteredCounterTextColor { get { return textBox_preview.ForeColor; } }
        public Color EnteredCounterBackgroundColor { get { return textBox_preview.BackColor; } }
        public int EnteredTimerClockRate { get { return trackBar1.Value; } }
        // Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            // Check name
            if (textBox_timer_name.Text == "")
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseEnterTimerCounterNameFirst, Properties.Resources.MessageCaption_AddTimerCounter);
                return;
            }
            if (TCLCoreService.TCLC.CurrentProfile.IsTimerCounterExist(textBox_timer_name.Text))
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_EnteredNameAlreadyTakenByAnotherTimer, Properties.Resources.MessageCaption_AddTimerCounter);
                return;
            }
            // Check currency
            if (textBox_currency.Text == "")
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseEnterCurrencyFirst, Properties.Resources.MessageCaption_AddTimerCounter);
                return;
            }
            Properties.Settings.Default.TimerIntervalInMilliseconds = trackBar1.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
        // Change font
        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = textBox_preview.Font;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textBox_preview.Font = dialog.Font;
            }
        }
        // Change Text Color
        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = textBox_preview.ForeColor;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textBox_preview.ForeColor = dialog.Color;
            }
        }
        // Change Background Color
        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = textBox_preview.BackColor;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textBox_preview.BackColor = dialog.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_timer_rate.Text = Properties.Resources.Word_ClockRate + ": " + trackBar1.Value + " " + Properties.Resources.Word_Milliseconds;
        }
    }
}
