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
using System.Linq;
using System.Text;

namespace TimerCounterLister
{
    [Serializable]
    class Profile
    {
        public Profile()
        {
            this.name = Properties.Resources.Title_Untitled;
            this.desc = "";
            is_password_protected = false;
            password = "";
            ask_for_password_on_each_activity = false;
            collection_timers = new List<TimerCounter>();
        }
        public Profile(string name)
        {
            this.name = name;
            this.desc = "";
            is_password_protected = false;
            password = "";
            ask_for_password_on_each_activity = false;
            collection_timers = new List<TimerCounter>();
        }
        public Profile(string name, string description, bool is_password_protected, string password, bool ask_for_password_on_each_activity, bool ask_for_password_on_application_close)
        {
            this.name = name;
            this.desc = description;
            this.is_password_protected = is_password_protected;
            this.password = password;
            this.ask_for_password_on_each_activity = ask_for_password_on_each_activity;
            this.ask_for_password_on_application_close = ask_for_password_on_application_close;
            collection_timers = new List<TimerCounter>();
        }
        public const byte VERSION = 1;
        private string name;
        private string desc;

        private bool is_password_protected;
        private bool ask_for_password_on_each_activity;
        private bool ask_for_password_on_application_close;
        private string password;


        internal List<TimerCounter> collection_timers;

        /// <summary>
        /// Get or set the name of this profile.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name && value != null && value != "")
                {
                    name = value;
                    TCLCoreService.TCLC.OnProfileNameChanged();
                }
            }
        }
        /// <summary>
        /// Get or set the profile description.
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
                    TCLCoreService.TCLC.OnProfileDescriptionChanged();
                }
            }
        }
        /// <summary>
        /// Get array of profile timer counters.
        /// </summary>
        public TimerCounter[] TimerCounters
        {
            get { return collection_timers.ToArray(); }
        }
        /// <summary>
        /// Get or set if this profile is password protected.
        /// </summary>
        public bool IsPasswordProtected
        {
            get { return is_password_protected; }
            set
            {
                if (value != is_password_protected)
                {
                    is_password_protected = value;
                    TCLCoreService.TCLC.OnProfileIsPasswordProtectedChanged();
                }
            }
        }
        /// <summary>
        /// Get or set if the program will ask for password each time user do an activity.
        /// </summary>
        public bool AskForPasswordOnEachActivity
        {
            get { return ask_for_password_on_each_activity; }
            set
            {
                if (value != ask_for_password_on_each_activity)
                {
                    ask_for_password_on_each_activity = value;
                    TCLCoreService.TCLC.OnProfileAskForPasswordOnEachActivityChanged();
                }
            }
        }
        public bool AskForPasswordOnApplicationClose
        {
            get { return ask_for_password_on_application_close; }
            set
            {
                if (value != ask_for_password_on_application_close)
                {
                    ask_for_password_on_application_close = value;
                    TCLCoreService.TCLC.OnProfileAskForPasswordOnApplicationCloseChanged();
                }
            }
        }
        /// <summary>
        /// Get or set the profile password
        /// </summary>
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value && value != "" && value != null)
                {
                    password = value;
                    TCLCoreService.TCLC.OnProfilePasswordChanged();
                }
            }
        }

        /// <summary>
        /// Initialize the profile
        /// </summary>
        /// <param name="newProfile">True: this initialize if for making new profile, False: this initialize is after opening this profile from file.</param>
        public void Initialize(bool newProfile)
        {
            if (!newProfile)
            {
                foreach (TimerCounter tt in collection_timers)
                    tt.AfterProfileOpen();
            }
        }

        /// <summary>
        /// Get if a timer counter exist using timer counter name
        /// </summary>
        /// <param name="name">Timer Counter name to look for</param>
        /// <returns>True: Timer Counter exist in this profile, False: Timer Counter does not exist in this profile.</returns>
        public bool IsTimerCounterExist(string name)
        {
            foreach (TimerCounter t in collection_timers)
            {
                if (t.Name == name)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Add new Timer Counter
        /// </summary>
        /// <param name="tc">Timer Counter</param>
        public void AddTimerCounter(TimerCounter tc)
        {
            collection_timers.Add(tc);
            TCLCoreService.TCLC.OnTimerCounterAdded(tc);
        }
        public void RemoveTimerCounter(int index)
        {
            if (index >= 0 && index < collection_timers.Count)
            {
                collection_timers[index].OnRemove();
                collection_timers.RemoveAt(index);
                TCLCoreService.TCLC.OnTimerCounterRemoved();
            }
        }
    }
}
