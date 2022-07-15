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
using System.Diagnostics;
using System.Text;
using System.Drawing;

namespace TimerCounterLister
{
    [Serializable]
    class TimerCounter
    {
        public TimerCounter(string name, string desc, DateTime start_time, string currency, double cost_per_minute, double time_passed_in_seconds, double balance, bool allow_resume_with_add, int timer_interval)
        {
            this.name = name;
            this.desc = desc;
            this.start_time = start_time;
            this.currency = currency;
            this.cost_per_minute = cost_per_minute;
            this.time_passed_in_seconds = time_passed_in_seconds;
            this.balance = balance;
            this.block_resume_with_add = !allow_resume_with_add;
            this.timer_interval = timer_interval;
            this.counter_font = new System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Regular);
            counter_text_color = Color.Black;
            counter_back_color = Color.White;

            events = new List<TimerCounterEvent>();
            alarms = new List<TimerCounterAlarm>();

            timer_started = false;

            InitializeTimer();
        }
        private string name;
        private string desc;
        private bool timer_started;
        private int timer_interval;
        private DateTime start_time;
        private DateTime pause_time;
        private DateTime halt_time;
        private string currency;
        private double cost_per_minute;
        private double balance;
        private double time_passed_in_seconds;
        private double cost_so_far;
        private bool block_resume_with_add;
        private Font counter_font;
        private Color counter_text_color;
        private Color counter_back_color;
        private List<TimerCounterEvent> events;
        private List<TimerCounterAlarm> alarms;
        [NonSerialized]
        private System.Windows.Forms.Timer timer;

        private bool timer_paused;

        private double timer_time_current;
        private double timer_time_token;

        /// <summary>
        /// Get or set the timer counter name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value && value != "" && value != null)
                {
                    name = value;
                    TCLCoreService.TCLC.OnTimerCounterNameChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set the timer counter description.
        /// </summary>
        public string Description
        {
            get
            {
                return desc;
            }
            set
            {
                if (desc != value && value != "" && value != null)
                {
                    desc = value;
                    TCLCoreService.TCLC.OnTimerCounterDescriptionChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set the timer counter currency.
        /// </summary>
        public double CostPerMinute
        {
            get
            {
                return cost_per_minute;
            }
            set
            {
                if (cost_per_minute != value && cost_per_minute >= 0)
                {
                    cost_per_minute = value;
                    TCLCoreService.TCLC.OnTimerCounterCostPerMinuteChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set cost so far
        /// </summary>
        public double CostSoFar
        {
            get
            {
                return cost_so_far;
            }
            set
            {
                if (cost_so_far != value)
                {
                    cost_so_far = value;
                    TCLCoreService.TCLC.OnTimerCounterCostSoFarChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set the timer counter currency.
        /// </summary>
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance != value && balance >= 0)
                {
                    balance = value;
                    TCLCoreService.TCLC.OnTimerCounterBalanceChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set time passed in seconds.
        /// </summary>
        public double TimePassedInSeconds
        {
            get
            {
                return time_passed_in_seconds;
            }
            set
            {
                if (time_passed_in_seconds != value && time_passed_in_seconds >= 0)
                {
                    time_passed_in_seconds = value;
                    TCLCoreService.TCLC.OnTimerCounterTimePassedInSecondsChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set the timer counter currency.
        /// </summary>
        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if (currency != value && value != "" && value != null)
                {
                    currency = value;
                    TCLCoreService.TCLC.OnTimerCounterCurrencyChanged(this);
                }
            }
        }
        public bool BlockResumeWithAdd
        {
            get { return block_resume_with_add; }
            set
            {
                if (block_resume_with_add != value)
                {
                    block_resume_with_add = value;
                    TCLCoreService.TCLC.OnTimerBlockResumeWithAddChanged(this);
                }
            }
        }
        /// <summary>
        /// Get or set the timer counter description.
        /// </summary>
        public DateTime StartTime
        {
            get
            {
                return start_time;
            }
            protected set
            {
                if (start_time != value && value != null)
                {
                    start_time = value;
                    TCLCoreService.TCLC.OnTimerCounterStartTimeChanged(this);
                }
            }
        }
        public Font CounterFont
        {
            get
            {
                return counter_font;
            }
            set
            {
                counter_font = value;
                TCLCoreService.TCLC.OnTimerCounterFontChanged(this);
            }
        }
        public Color CounterTextColor
        {
            get
            {
                return counter_text_color;
            }
            set
            {
                counter_text_color = value;
                TCLCoreService.TCLC.OnTimerCounterTextColorChanged(this);
            }
        }
        public Color CounterBackgroundColor
        {
            get
            {
                return counter_back_color;
            }
            set
            {
                counter_back_color = value;
                TCLCoreService.TCLC.OnTimerCounterBackgroundColorChanged(this);
            }
        }
        /// <summary>
        /// Get an array of timer events
        /// </summary>
        public TimerCounterEvent[] Events
        { get { return events.ToArray(); } }
        public TimerCounterAlarm[] Alarms
        { get { return alarms.ToArray(); } }
        public bool IsTimerPaused { get { return timer_paused; } }
        public bool IsTimerStarted { get { return timer_started; } }
        public DateTime PauseTime { get { return pause_time; } }
        public int TimerIntervalInMilliseconds
        {
            get
            {
                return timer.Interval;
            }
            set
            {
                timer.Interval = timer_interval = value;
            }
        }

        private void InitializeTimer()
        {
            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Stop();
                timer.Tick += Timer_Tick;
                timer.Interval = timer_interval;
            }
        }
        public void AfterProfileOpen()
        {
            if (events == null)
                events = new List<TimerCounterEvent>();
            if (alarms == null)
                alarms = new List<TimerCounterAlarm>();
            InitializeTimer();

            if (!timer_paused && timer_started)
            {
                // Calculate time passed since last save

                /* TimeSpan seconds_passed_since_last_save = DateTime.Now.TimeOfDay - halt_time.TimeOfDay;

                 int H = seconds_passed_since_last_save.Hours;
                 int M = seconds_passed_since_last_save.Minutes;
                 int S = seconds_passed_since_last_save.Seconds;
                 double mili = seconds_passed_since_last_save.Milliseconds;
                 mili /= 1000;

                 time_passed_in_seconds += (H * 3600) + (M * 60) + S + mili;*/

                timer_time_current = GetTime();
                timer.Start();
            }
        }
        public void OnRemove()
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
        }
        public void AddEvent(TimerCounterEvent eve)
        {
            if (eve == null)
                return;
            if (events == null)
                events = new List<TimerCounterEvent>();
            events.Add(eve);

            TCLCoreService.TCLC.OnTimerCounterEventAdded(this);
        }
        public void RemoveEvent(TimerCounterEvent eve)
        {
            if (eve == null)
                return;
            if (events == null)
                events = new List<TimerCounterEvent>();
            events.Remove(eve);

            TCLCoreService.TCLC.OnTimerCounterEventRemoved(this);
        }
        public void RemoveEvent(int eve_index)
        {
            if (eve_index < 0)
                return;
            if (events == null)
                events = new List<TimerCounterEvent>();
            if (eve_index < events.Count)
                events.RemoveAt(eve_index);

            TCLCoreService.TCLC.OnTimerCounterEventRemoved(this);
        }
        public void AddAlarm(TimerCounterAlarm ala)
        {
            if (ala == null)
                return;
            if (alarms == null)
                alarms = new List<TimerCounterAlarm>();
            alarms.Add(ala);

            TCLCoreService.TCLC.OnTimerCounterAlarmAdded(this);
        }
        public void RemoveAlarm(TimerCounterAlarm ala)
        {
            if (ala == null)
                return;
            if (alarms == null)
                alarms = new List<TimerCounterAlarm>();
            alarms.Remove(ala);

            TCLCoreService.TCLC.OnTimerCounterAlarmRemoved(this);
        }
        public void RemoveAlarm(int ala_index)
        {
            if (ala_index < 0)
                return;
            if (alarms == null)
                alarms = new List<TimerCounterAlarm>();
            if (ala_index < alarms.Count)
                alarms.RemoveAt(ala_index);

            TCLCoreService.TCLC.OnTimerCounterAlarmRemoved(this);
        }
        public bool IsAlarmExist(string name)
        {
            foreach (TimerCounterAlarm alarm in alarms)
            {
                if (alarm.Name.ToLower() == name.ToLower())
                    return true;
            }
            return false;
        }
        public void StartTimer(bool resume_with_difference = false, string difference_details = "")
        {
            if (timer_paused)
            {
                timer_paused = false;
                if (!resume_with_difference)
                {
                    AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterResume, Properties.Resources.TimerEvent_TimerResume, Properties.Resources.TimerEventDesc_TimerResume, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));
                }
                else
                {
                    AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterResumeWithDifference, Properties.Resources.TimerEvent_TimerCounterResumeWithDifference, Properties.Resources.TimerEventDesc_TimerResumeWithDifference + " " + difference_details, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));
                }
            }
            else
            {
                AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterStart, Properties.Resources.TimerEvent_TimerStart, Properties.Resources.TimerEventDesc_TimerStart, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));
                timer_started = true;
            }

            timer_time_current = GetTime();
            timer.Start();
        }
        public void PauseTimer()
        {
            if (timer_paused)
                return;

            timer_paused = true;
            timer.Stop();

            AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterPause, Properties.Resources.TimerEvent_TimerPause, Properties.Resources.TimerEventDesc_TimerPause, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));
        }
        public string GetTimePassedAs_TimeSpan_Milli(double time)
        {
            /*string returnValue = TimeSpan.FromSeconds(time).ToString().Substring(0, 8);
            int milli = TimeSpan.FromSeconds(time).Milliseconds;
            returnValue += "." + milli.ToString("D3").Substring(0, 3);*/

            int time_passed_days = (int)Math.Floor(time / 86400);
            int time_passed_hours = (int)Math.Floor((time - (int)(time_passed_days * 86400)) / 3600);
            int time_passed_minutes = (int)Math.Floor((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600)) / 60);
            int time_passed_seconds = (int)Math.Floor(time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60));
            int time_passed_milliseconds = (int)((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60) - time_passed_seconds) * 1000);

            return time_passed_days + "," + time_passed_hours.ToString("D2") + ":" + time_passed_minutes.ToString("D2") + ":" + time_passed_seconds.ToString("D2") + "," + time_passed_milliseconds.ToString("D3");
        }
        public string GetTimePassedAsDetails(double time)
        {
            /*double time_passed_minutes = time_passed_in_seconds / 60;
            double time_passed_hours = time_passed_minutes / 60;
            double time_passed_days = time_passed_hours / 24;

            return GetTimePassedAs_TimeSpan_Milli(time_passed_in_seconds) + " (" + time_passed_days.ToString("F0") + " " + Properties.Resources.Word_Days + " " + time_passed_hours.ToString("F0") + " " + Properties.Resources.Word_Hours + " " + ")";*/
            int time_passed_days = (int)Math.Floor(time / 86400);
            int time_passed_hours = (int)Math.Floor((time - (int)(time_passed_days * 86400)) / 3600);
            int time_passed_minutes = (int)Math.Floor((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600)) / 60);
            int time_passed_seconds = (int)Math.Floor(time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60));
            int time_passed_milliseconds = (int)((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60) - time_passed_seconds) * 1000);

            return time_passed_days + "," + time_passed_hours.ToString("D2") + ":" + time_passed_minutes.ToString("D2") + ":" + time_passed_seconds.ToString("D2") + "," + time_passed_milliseconds.ToString("D3") + " (" + time_passed_days + " " + Properties.Resources.Word_Days + " " + time_passed_hours.ToString("D2") + " " + Properties.Resources.Word_Hours + " " + time_passed_minutes.ToString("D2") + " " + Properties.Resources.Word_Minutes + " " + time_passed_seconds.ToString("D2") + " " + Properties.Resources.Word_Seconds + " " + time_passed_milliseconds.ToString("D3") + " " + Properties.Resources.Word_Milliseconds + ")";
        }
        public string GetTimePassedAsDetails1(double time)
        {
            int time_passed_days = (int)Math.Floor(time / 86400);
            int time_passed_hours = (int)Math.Floor((time - (int)(time_passed_days * 86400)) / 3600);
            int time_passed_minutes = (int)Math.Floor((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600)) / 60);
            int time_passed_seconds = (int)Math.Floor(time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60));
            int time_passed_milliseconds = (int)((time - (int)(time_passed_days * 86400) - (int)(time_passed_hours * 3600) - (int)(time_passed_minutes * 60) - time_passed_seconds) * 1000);

            return time_passed_days + " " + Properties.Resources.Word_Days + " " + time_passed_hours.ToString("D2") + " " + Properties.Resources.Word_Hours + " " + time_passed_minutes.ToString("D2") + " " + Properties.Resources.Word_Minutes + " " + time_passed_seconds.ToString("D2") + " " + Properties.Resources.Word_Seconds + " " + time_passed_milliseconds.ToString("D3") + " " + Properties.Resources.Word_Milliseconds;
        }
        /* public string GetCostSoFar()
         {
             double time_passed_minutes = time_passed_in_seconds / 60;

             return (time_passed_minutes * cost_per_minute).ToString();
         }*/
        // TIMER CLOCK
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timer_paused)
                return;

            timer_time_token = GetTime() - timer_time_current;

            TimePassedInSeconds += timer_time_token;
            CostSoFar += timer_time_token * (cost_per_minute / 60);

            foreach (TimerCounterAlarm alarm in alarms)
            {
                if (alarm.TimerTriggered)
                    continue;
                alarm.TriggerTimeLeft -= timer_time_token;
                if (alarm.TriggerTimeLeft <= 0)
                {
                    if (!alarm.TimerTriggered)
                    {
                        alarm.TimerTriggered = true;
                        alarm.TriggerTimeLeft = 0;

                        if (alarm.PauseTimerCounterOnTrigger)
                        {
                            timer_paused = true;
                            timer.Stop();

                            AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterPause, Properties.Resources.TimerEvent_TimerPause, Properties.Resources.TimerEventDesc_TimerPauseBecauseOfTimer, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));
                        }

                        AddEvent(new TimerCounterEvent(TimerCounterEventType.TimerCounterAlarmTrigger, Properties.Resources.TimerEvent_AlarmTrigger, Properties.Resources.Word_Alarm + " " + alarm.Name + " " + Properties.Resources.Word_Triggered, DateTime.Now, cost_so_far, balance, time_passed_in_seconds, currency));

                        // Trigger the alarm
                        TimerCounterAlarmTriggerEventArgs args = new TimerCounterAlarmTriggerEventArgs(this, alarm);
                        TCLCoreService.TCLC.OnTimerCounterAlarmTrigger(ref args);
                    }
                }
            }

            timer_time_current = GetTime();
        }

        private double GetTime()
        {
            return Stopwatch.GetTimestamp() / (double)Stopwatch.Frequency;
        }
    }
}
