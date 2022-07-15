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
using System.Media;
using System.Windows.Forms;

namespace TimerCounterLister
{
    public partial class FormAlarmTrigger : Form
    {
        private SoundPlayer player;
        private bool is_alarming;
        private bool is_playing;
        public FormAlarmTrigger(string details, string alarm_sound_file)
        {
            InitializeComponent();
            richTextBox_details.Text = details;

            if (System.IO.File.Exists(alarm_sound_file))
            {
                player = new SoundPlayer();
                player.SoundLocation = alarm_sound_file;
                player.Load();

                player.PlayLooping();
                is_playing = true;
                is_alarming = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (is_alarming)
            {
                if (is_playing)
                {
                    player.Stop();
                    is_playing = false;
                }
                else
                {
                    player.PlayLooping();
                    is_playing = true;
                }

            }
        }
        private void FormAlarmTrigger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_playing)
            {
                is_playing = false;
                player.Stop();
            }
        }
    }
}
