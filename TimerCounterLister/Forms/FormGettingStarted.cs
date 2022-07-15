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
using System.Windows.Forms;
using ManagedUI;

namespace TimerCounterLister
{
    public partial class FormGettingStarted : Form
    {
        public FormGettingStarted()
        {
            InitializeComponent();

            TCLCoreService.TCLC.NewProfileStarted += TCLC_NewProfileStarted;
            TCLCoreService.TCLC.ProfileOpened += TCLC_NewProfileStarted;

            foreach (string rec in TCLCoreService.TCLC.RecentProfiles)
                comboBox_recent_profiles.Items.Add(System.IO.Path.GetFileName(rec));

            if (comboBox_recent_profiles.Items.Count > 0)
                comboBox_recent_profiles.SelectedIndex = 0;
        }
        private void TCLC_NewProfileStarted(object sender, EventArgs e)
        {
            TCLCoreService.TCLC.NewProfileStarted -= TCLC_NewProfileStarted;
            TCLCoreService.TCLC.ProfileOpened -= TCLC_NewProfileStarted;
            Close();
        }

        // Start new
        private void button1_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.new.profile");
        }
        // Open profile as
        private void button2_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.open.profile.as");
        }
        // Open recent from combo box
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox_recent_profiles.SelectedIndex >= 0)
                CommandsManager.CMD.Execute("tcl.open.profile", new object[] { TCLCoreService.TCLC.RecentProfiles[comboBox_recent_profiles.SelectedIndex] });
        }
        // Exit
        private void button4_Click(object sender, EventArgs e)
        {
            CommandsManager.CMD.Execute("exit");
        }
    }
}
