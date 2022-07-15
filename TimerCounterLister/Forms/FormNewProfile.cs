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
using System.IO;
using System.Windows.Forms;
using ManagedUI;

namespace TimerCounterLister
{
    public partial class FormNewProfile : Form
    {
        public FormNewProfile()
        {
            InitializeComponent();

            string dic = Path.Combine(MUI.Documentsfolder, "Profiles");
            Directory.CreateDirectory(dic);

            string pa = Path.Combine(dic, Properties.Resources.Title_Untitled + ".tclp");

            int i = 1;
            while (File.Exists(pa))
            {
                pa = Path.Combine(dic, Properties.Resources.Title_Untitled + "_" + i + ".tclp");
                i++;
            }
            textBox_profile_path.Text = pa;
            textBox_profile_name.Text = Properties.Resources.Title_Untitled;
        }

        public string EnteredName
        {
            get { return textBox_profile_name.Text; }
        }
        public string EnteredDescription
        {
            get { return richTextBox_profile_description.Text; }
        }
        public bool EnteredIsProfilePasswordProtected
        {
            get { return checkBox_is_password_protected.Checked; }
        }
        public string EnteredProfileFilePath
        {
            get { return textBox_profile_path.Text; }
        }
        public bool EnteredAskForPasswordEachTimeDoAnActivity
        {
            get { return checkBox_ask_for_password_on_each_activity.Checked; }
        }
        public bool EnteredAskForPasswordOnAppClose
        {
            get { return checkBox_ask_password_on_app_close.Checked; }
        }
        public string EnteredPassword
        {
            get { return textBox_password.Text; }
        }

        private void checkBox_show_hide_password_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !checkBox_show_hide_password.Checked;
        }
        // Browse
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox_profile_path.Text;
            bool ok = false;
            Utilities.ShowOpenSaveDialog(true, Properties.Resources.Title_SaveProfile, Properties.Resources.Filter_TCLP, ref filePath, out ok);
            if (ok)
            {
                textBox_profile_path.Text = filePath;
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            // Check name
            if (textBox_profile_name.Text == "")
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_PleaseEnterProfileNameFirst);
                textBox_profile_name.Select();
                return;
            }
            // Check password
            if (checkBox_is_password_protected.Checked)
            {
                if (textBox_password.Text == "")
                {
                    ManagedMessageBox.ShowMessage(Properties.Resources.Message_PleaseEnterProfilePasswordFirst);
                    textBox_password.Select();
                    return;
                }
            }
            // Check path
            if (textBox_profile_path.Text == "")
            {
                ManagedMessageBox.ShowMessage(Properties.Resources.Message_PleaseEnterProfilePathFirst);
                textBox_profile_path.Select();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
