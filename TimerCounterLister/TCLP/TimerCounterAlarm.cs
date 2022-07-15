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

namespace TimerCounterLister
{
    [Serializable]
    class TimerCounterAlarm
    {
        public TimerCounterAlarm(string name, string desc, double time_to_trigger, bool pause_timer_on_trigger, string alarm_sound_file_path)
        {
            Name = name;
            Description = desc;
            TriggerTime = TriggerTimeLeft = time_to_trigger;
            PauseTimerCounterOnTrigger = pause_timer_on_trigger;
            AlarmSoundFilePath = alarm_sound_file_path;
            TimerTriggered = false;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AlarmSoundFilePath { get; set; }
        /// <summary>
        /// How many seconds left to trigger
        /// </summary>
        public double TriggerTimeLeft { get; set; }
        /// <summary>
        /// How many seconds trigger time at start 
        /// </summary>
        public double TriggerTime { get; set; }
        public bool PauseTimerCounterOnTrigger { get; set; }

        public bool TimerTriggered { get; set; }
    }
}
