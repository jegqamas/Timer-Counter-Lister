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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Windows.Forms;
using ManagedUI;

namespace TimerCounterLister
{
    public partial class FormAddNewTimerCounterAlarm : Form
    {
        SoundPlayer player;
        public FormAddNewTimerCounterAlarm()
        {
            InitializeComponent();

            sound_files = Directory.GetFiles(Path.Combine(MUI.StartupFolder, "alarms"), "*.wav");

            foreach (string file in sound_files)
            {
                comboBox_alarm_files.Items.Add(Path.GetFileName(file));
            }
            if (comboBox_alarm_files.Items.Count > 0)
                comboBox_alarm_files.SelectedIndex = 0;
            current_sound = -1;
            player = new SoundPlayer();
        }
        string[] sound_files;
        int current_sound;
        bool is_playing;

        public string EnteredSoundFile
        {
            get
            {
                if (comboBox_alarm_files.SelectedIndex >= 0 && comboBox_alarm_files.SelectedIndex < sound_files.Length)
                    return sound_files[comboBox_alarm_files.SelectedIndex];
                return "";
            }
        }
        public string EnteredName
        {
            get { return textBox_name.Text; }
        }
        public string EnteredDescription
        {
            get { return richTextBox_desc.Text; }
        }
        public double TimeToTriggerAfterInSeconds
        {
            get
            {
                return GetTimeEntered();
            }
        }
        public bool EnteredPauseTimerCounterOnTrigger
        {
            get { return checkBox_pause_timer_on_trigger.Checked; }
        }
        public bool EnteredSetAlarmAsTriggered
        {
            get { return checkBox_set_as_triggered.Checked; }
        }
        private double GetTimeEntered()
        {
            double milli = (int)numericUpDown1.Value;
            milli /= 1000;
            double seconds = (int)numericUpDown_seconds.Value;
            double minutes = (int)numericUpDown_minutes.Value;
            double hours = (int)numericUpDown_hours.Value;
            double days = (int)numericUpDown_days.Value;

            return milli + seconds + (minutes * 60) + (hours * 3600) + (days * 86400);
        }
        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            // Check name
            if (textBox_name.Text == "")
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseEnterTimerCounterAlarmNameFirst, Properties.Resources.MessageCaption_AddTimerCounterAlarm);
                return;
            }
            TimerCounter tc = TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex];
            if (tc.IsAlarmExist(textBox_name.Text))
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_EnteredNameAlreadyTakenByAnotherTimerAlarm, Properties.Resources.MessageCaption_AddTimerCounterAlarm);
                return;
            }

            if (GetTimeEntered() == 0)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_PleaseEnterTimerCounterAlarmTime, Properties.Resources.MessageCaption_AddTimerCounterAlarm);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        // Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox_alarm_files.SelectedIndex >= 0 && current_sound != comboBox_alarm_files.SelectedIndex)
            {
                player.SoundLocation = sound_files[comboBox_alarm_files.SelectedIndex];
                player.Load();
                current_sound = comboBox_alarm_files.SelectedIndex;
            }

            if (is_playing)
            {
                is_playing = false;
                player.Stop();
            }
            else
            {
                is_playing = true;
                player.Play();
            }
        }

        private void FormAddNewTimerCounterAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_playing)
            {
                is_playing = false;
                player.Stop();
            }
        }
    }
}
