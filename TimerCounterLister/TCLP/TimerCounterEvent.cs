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
    class TimerCounterEvent
    {
        public TimerCounterEvent(TimerCounterEventType t, string name, string desc, DateTime date, double status_cost_so_far, double status_balance, double status_time_passed_in_seconds, string status_currency)
        {
            Name = name;
            Description = desc;
            DateOfEvent = date;
            Status_CostSoFar = status_cost_so_far;
            Status_Balance = status_balance;
            Status_TimePassedInSeconds = status_time_passed_in_seconds;
            Status_Currency = status_currency;
            TimerEventType = t;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfEvent { get; set; }
        public TimerCounterEventType TimerEventType { get; set; }

        public double Status_CostSoFar { get; set; }
        public double Status_Balance { get; set; }
        public double Status_TimePassedInSeconds { get; set; }
        public string Status_Currency { get; set; }
    }
}
