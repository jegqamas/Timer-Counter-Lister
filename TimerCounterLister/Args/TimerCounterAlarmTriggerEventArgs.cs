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
    class TimerCounterAlarmTriggerEventArgs : EventArgs
    {
        public TimerCounterAlarmTriggerEventArgs(TimerCounter tc, TimerCounterAlarm alarm)
        {
            ParentTimerCounter = tc;
            TimerCounterAlarm = alarm;
        }
        /// <summary>
        /// 
        /// </summary>
        public TimerCounter ParentTimerCounter { get; private set; }
        public TimerCounterAlarm TimerCounterAlarm { get; private set; }
    }
}
