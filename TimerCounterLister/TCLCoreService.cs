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
using System.ComponentModel.Composition;
using ManagedUI;

namespace TimerCounterLister
{
    [Export(typeof(IService))]
    [Export(typeof(TCLCoreService))]
    [ServiceInfo("Timer Counter Lister Core Service", "tcl.core", "Core service of Timer Counter Lister.", true)]
    class TCLCoreService : IService
    {
        public override void Initialize()
        {
            base.Initialize();
            // Load settings
            Properties.Settings.Default.Reload();

            if (Properties.Settings.Default.RecentProfiles == null)
                Properties.Settings.Default.RecentProfiles = new System.Collections.Specialized.StringCollection();

            RecentProfiles = new List<string>();
            foreach (string ss in Properties.Settings.Default.RecentProfiles)
                RecentProfiles.Add(ss);
            //Load settings of tab controls
            GUIService.GUI.LoadTabControlsSettings();

            RecentProfilesUpdated?.Invoke(null, new EventArgs());

            // Execute commands
            //CommandsManager.CMD.Execute("tcl.new.profile");

            MUI.ApplicationExitting += MUI_ApplicationExitting;
        }

        public override void Close()
        {
            base.Close();

            Properties.Settings.Default.RecentProfiles = new System.Collections.Specialized.StringCollection();

            foreach (string ss in RecentProfiles)
                Properties.Settings.Default.RecentProfiles.Add(ss);


            Properties.Settings.Default.Save();
        }
        internal void SetMainWindowTitle()
        {
            if (CurrentProfile == null)
                return;
            if (save_bending)
            {
                GUIService.GUI.UpdateMainWindowTitle(CurrentProfile.Name + "* - Timer Counter Lister");
            }
            else
                GUIService.GUI.UpdateMainWindowTitle(CurrentProfile.Name + " - Timer Counter Lister");

        }
        internal void SetRecentProject(string fileName)
        {
            if (RecentProfiles == null)
                RecentProfiles = new List<string>();
            if (RecentProfiles.Contains(fileName))
                RecentProfiles.Remove(fileName);
            RecentProfiles.Insert(0, fileName);
            if (RecentProfiles.Count == 10)
                RecentProfiles.RemoveAt(9);
            RecentProfilesUpdated?.Invoke(null, new EventArgs());
        }

        private bool save_bending;
        private int selected_timer_index;
        /// <summary>
        /// Get or set if the current profile needs to be saved.
        /// </summary>
        public bool SaveBending
        {
            get { return save_bending; }
            set
            {
                save_bending = value;
                SetMainWindowTitle();
                SaveBendingChanged?.Invoke(null, new EventArgs());
            }
        }
        // Properties
        public Profile CurrentProfile { get; set; }
        public string CurrentProfilePath { get; set; }
        public int SelectedTimerCounterIndex
        {
            get
            {
                return selected_timer_index;
            }
            set
            {
                selected_timer_index = value;
                SelectedTimerCounterIndexChanged?.Invoke(null, new EventArgs());
            }
        }
        /// <summary>
        /// Get list of recent opened/saved projects
        /// </summary>
        public List<string> RecentProfiles { get; private set; }

        // Events
        /*PROFILES*/
        /// <summary>
        /// Raised when current profile name changes.
        /// </summary>
        public event EventHandler ProfileNameChanged;
        /// <summary>
        /// Raised when current profile description changed.
        /// </summary>
        public event EventHandler ProfileDescriptionChanged;

        public event EventHandler ProfileIsPasswordProtectedChanged;
        public event EventHandler ProfileAskForPasswordOnEachActivityChanged;
        public event EventHandler ProfilePasswordChanged;

        /// <summary>
        /// Raised when the SaveBending value changes.
        /// </summary>
        public event EventHandler SaveBendingChanged;
        /// <summary>
        /// Raised when project about to be saved.
        /// </summary>
        public event EventHandler<CancableEventArgs> BeforeProfileSave;
        /// <summary>
        /// Raised when project save (after project file written)
        /// </summary>
        public event EventHandler ProfileSaved;
        /// <summary>
        /// Raised when the project cannot be saved for whatever reason. Also, raised to cancel the BeforeProjectSave event when the project didn't save.
        /// </summary>
        public event EventHandler ProfileCannotBeSaved;
        /// <summary>
        /// Raised when new project is being created (before created)
        /// </summary>
        public event EventHandler<CancableEventArgs> BeforeNewProfile;
        /// <summary>
        /// Raised after a new project is started
        /// </summary>
        public event EventHandler NewProfileStarted;
        /// <summary>
        /// Raised when project about to be opened.
        /// </summary>
        public event EventHandler<CancableEventArgs> BeforeProfileOpen;
        /// <summary>
        /// Raised when project opens (after project changes)
        /// </summary>
        public event EventHandler ProfileOpened;
        /// <summary>
        /// Raised when the project cannot be opened for whatever reason. Also, raised to cancel the BeforeProjectOpen event when no project opens.
        /// </summary>
        public event EventHandler ProfileCannotBeOpened;
        /// <summary>
        /// Raised when the recent projects list get updated
        /// </summary>
        public event EventHandler RecentProfilesUpdated;
        public event EventHandler ProfileAskForPasswordOnApplicationCloseChanged;



        /*TIMER COUNTERS*/
        /// <summary>
        /// Raised after a timer counter name change. The sender object is the timer counter itself.
        /// </summary>
        public event EventHandler TimerCounterNameChanged;
        /// <summary>
        /// Raised after a timer counter description change. The sender object is the timer counter itself.
        /// </summary>
        public event EventHandler TimerCounterDescriptionChanged;
        /// <summary>
        /// Raised when a timer counter start time change. The sender object is the timer counter itself.
        /// </summary>
        public event EventHandler TimerCounterStartTimeChanged;
        public event EventHandler TimerCounterCurrencyChanged;
        public event EventHandler TimerCounterCostPerMinuteChanged;
        public event EventHandler TimerCounterBalanceChanged;
        public event EventHandler TimerCounterEventAdded;
        public event EventHandler TimerCounterEventRemoved;
        public event EventHandler TimerCounterTimePassedInSecondsChanged;
        /// <summary>
        /// Raised after adding new timer counter, the sender object is the timer itself "TimerCounterLister.TimerCounter".
        /// </summary>
        public event EventHandler TimerCounterAdded;
        public event EventHandler SelectedTimerCounterIndexChanged;
        public event EventHandler TimerCounterRemoved;
        public event EventHandler TimerCounterCostSoFarChanged;
        public event EventHandler TimerCounterFontChanged;
        public event EventHandler TimerCounterTextColorChanged;
        public event EventHandler TimerCounterBackgroundColorChanged;
        public event EventHandler TimerBlockResumeWithAddChanged;
        public event EventHandler TimerCounterAlarmAdded;
        public event EventHandler TimerCounterAlarmRemoved;
        public event EventHandler<TimerCounterAlarmTriggerEventArgs> TimerCounterAlarmTrigger;

        // Event Handlers
        internal void OnProfileNameChanged()
        {
            ProfileNameChanged?.Invoke(null, new EventArgs());
        }
        internal void OnProfileIsPasswordProtectedChanged()
        {
            ProfileIsPasswordProtectedChanged?.Invoke(null, new EventArgs());
        }
        internal void OnProfileAskForPasswordOnApplicationCloseChanged()
        {
            ProfileAskForPasswordOnApplicationCloseChanged?.Invoke(null, new EventArgs());
        }
        internal void OnProfileAskForPasswordOnEachActivityChanged()
        {
            ProfileAskForPasswordOnEachActivityChanged?.Invoke(null, new EventArgs());
        }
        internal void OnProfilePasswordChanged()
        {
            ProfilePasswordChanged?.Invoke(null, new EventArgs());
        }
        internal void OnProfileDescriptionChanged()
        {
            ProfileDescriptionChanged?.Invoke(null, new EventArgs());
        }
        internal void OnBeforeNewProfile(ref CancableEventArgs args)
        {
            BeforeNewProfile?.Invoke(null, args);
        }
        internal void OnNewProfileStarted()
        {
            NewProfileStarted?.Invoke(null, new EventArgs());
            SaveBending = false;
            SelectedTimerCounterIndex = -1;
        }
        internal void OnBeforeProfileOpen(ref CancableEventArgs args)
        {
            BeforeProfileOpen?.Invoke(null, args);
        }
        internal void OnProfileOpened()
        {
            ProfileOpened?.Invoke(null, new EventArgs());
            SaveBending = false;
            SetRecentProject(CurrentProfilePath);
            SelectedTimerCounterIndex = -1;
        }
        internal void OnProfileCannotBeOpened()
        {
            ProfileCannotBeOpened?.Invoke(null, new EventArgs());
            SetMainWindowTitle();
        }
        internal void OnBeforeProfileSave(ref CancableEventArgs args)
        {
            BeforeProfileSave?.Invoke(null, args);
        }
        internal void OnProfileSaved()
        {
            SaveBending = false;
            SetRecentProject(CurrentProfilePath);

            ProfileSaved?.Invoke(null, new EventArgs());
        }
        internal void OnProfileCannotBeSaved()
        {
            ProfileCannotBeSaved?.Invoke(null, new EventArgs());
            SetMainWindowTitle();
        }
        internal void OnRecentProfilesUpdated()
        {
            RecentProfilesUpdated?.Invoke(null, new EventArgs());
        }
        internal void OnTimerCounterNameChanged(object sender)
        {
            SaveBending = true;
            TimerCounterNameChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterDescriptionChanged(object sender)
        {
            SaveBending = true;
            TimerCounterDescriptionChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterStartTimeChanged(object sender)
        {
            SaveBending = true;
            TimerCounterStartTimeChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterCurrencyChanged(object sender)
        {
            SaveBending = true;
            TimerCounterCurrencyChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterCostPerMinuteChanged(object sender)
        {
            SaveBending = true;
            TimerCounterCostPerMinuteChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterBalanceChanged(object sender)
        {
            SaveBending = true;
            TimerCounterBalanceChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterEventAdded(object sender)
        {
            SaveBending = true;
            TimerCounterEventAdded?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterEventRemoved(object sender)
        {
            SaveBending = true;
            TimerCounterEventRemoved?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterAlarmAdded(object sender)
        {
            SaveBending = true;
            TimerCounterAlarmAdded?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterAlarmRemoved(object sender)
        {
            SaveBending = true;
            TimerCounterAlarmRemoved?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterTimePassedInSecondsChanged(object sender)
        {
            //SaveBending = true;
            TimerCounterTimePassedInSecondsChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerBlockResumeWithAddChanged(object sender)
        {
            //SaveBending = true;
            TimerBlockResumeWithAddChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterTextColorChanged(object sender)
        {
            TimerCounterTextColorChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterBackgroundColorChanged(object sender)
        {
            TimerCounterBackgroundColorChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterFontChanged(object sender)
        {
            //SaveBending = true;
            TimerCounterFontChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterCostSoFarChanged(object sender)
        {
            //SaveBending = true;
            TimerCounterCostSoFarChanged?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterAdded(object sender)
        {
            SaveBending = true;
            TimerCounterAdded?.Invoke(sender, new EventArgs());
        }
        internal void OnTimerCounterRemoved()
        {
            SaveBending = true;
            TimerCounterRemoved?.Invoke(null, new EventArgs());
            SelectedTimerCounterIndex = -1;
        }
        internal void OnTimerCounterAlarmTrigger(ref TimerCounterAlarmTriggerEventArgs args)
        {
            TimerCounterAlarmTrigger?.Invoke(this, args);

            /*ManagedMessageBox.ShowMessage(Properties.Resources.Message_AlarmTrigger + "\n" + Properties.Resources.Word_TimerCounter + ": " + args.ParentTimerCounter.Name + "\n" + Properties.Resources.Word_AlarmName + ": " + args.TimerCounterAlarm.Name + "\n" + Properties.Resources.Word_AlarmDescription + ": " + args.TimerCounterAlarm.Description, Properties.Resources.MessageCaption_AlarmTrigger);*/

            FormAlarmTrigger frm = new FormAlarmTrigger(Properties.Resources.Message_AlarmTrigger + "\n\n" + Properties.Resources.Word_TimerCounter + ": " + args.ParentTimerCounter.Name + "\n\n" + Properties.Resources.Word_AlarmName + ": " + args.TimerCounterAlarm.Name + "\n\n" + Properties.Resources.Word_AlarmDescription + ": " + args.TimerCounterAlarm.Description, args.TimerCounterAlarm.AlarmSoundFilePath);
            frm.Show();
            frm.BringToFront();
        }
        private void MUI_ApplicationExitting(object sender, ApplicationExittingArgs e)
        {
            if (CurrentProfile != null)
            {
                // Check timers
                object[] res0 = new object[1];
                CommandsManager.CMD.Execute("tcl.profile.check.profile.close.ability", new object[] { }, out res0);
                if (!(bool)res0[0])
                {
                    ManagedMessageBox.ShowMessage(Properties.Resources.Message_CannotCloseAppTimersStillRunning);
                    e.Cancel = true;
                    return;
                }
                // Check for save
                object[] res = new object[1];
                CommandsManager.CMD.Execute("tcl.check.for.save", new object[] { }, out res);
                if (!(bool)res[0])
                {
                    ManagedMessageBox.ShowMessage(Properties.Resources.Message_CannotCloseAppProfileNotSaved);
                    e.Cancel = true;
                    return;
                }
                // Check password
                if (CurrentProfile.AskForPasswordOnApplicationClose)
                {
                    object[] res1 = new object[1];
                    CommandsManager.CMD.Execute("tcl.profile.check.password", new object[] { }, out res1);
                    if (!(bool)res1[0])
                    {
                        ManagedMessageBox.ShowMessage(Properties.Resources.Message_CannotCloseAppProfileIsPasswordProtectedWrongPassworf);
                        e.Cancel = true;
                        return;
                    }
                }

            }
            // Save settings
            GUIService.GUI.SaveTabControlsSettings();
        }

        #region STATIC
        private static TCLCoreService tclcService;

        /// <summary>
        /// Get this service loaded from the core and ready to go.
        /// </summary>
        public static TCLCoreService TCLC
        {
            get
            {
                if (tclcService == null)
                {
                    Lazy<IService, IServiceInfo> ser = MUI.GetServiceByID("tcl.core");
                    if (ser != null)
                        tclcService = (TCLCoreService)ser.Value;
                }
                return tclcService;
            }
        }
        #endregion
    }
}
