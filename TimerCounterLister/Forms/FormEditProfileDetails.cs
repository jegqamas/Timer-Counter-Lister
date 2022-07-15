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
    public partial class FormEditProfileDetails : Form
    {
        public FormEditProfileDetails()
        {
            InitializeComponent();

            textBox_profile_name.Text = TCLCoreService.TCLC.CurrentProfile.Name;
            richTextBox_profile_description.Text = TCLCoreService.TCLC.CurrentProfile.Description;

            bool is_there_apassword = TCLCoreService.TCLC.CurrentProfile.Password != "";

            textBox_password.ReadOnly = is_there_apassword;
            button1.Enabled = is_there_apassword;
            checkBox_show_password.Visible = !is_there_apassword;
            textBox_password.Text = TCLCoreService.TCLC.CurrentProfile.Password;

            checkBox_ask_for_password_on_each_activity.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity;
            checkBox_ask_password_on_app_close.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnApplicationClose;
            checkBox_is_password_protected.Checked = TCLCoreService.TCLC.CurrentProfile.IsPasswordProtected;
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
        public bool EnteredAskForPasswordEachTimeDoAnActivity
        {
            get { return checkBox_ask_for_password_on_each_activity.Checked; }
        }
        public string EnteredPassword
        {
            get { return textBox_password.Text; }
        }
        public bool EnteredAskForPasswordOnAppClose
        {
            get { return checkBox_ask_password_on_app_close.Checked; }
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

            DialogResult = DialogResult.OK;
            Close();
        }
        // Change password
        private void button1_Click(object sender, EventArgs e)
        {
            FormEnterName frm = new FormEnterName(Properties.Resources.Title_PleaseEnterCURRENTPassword, "", true, true);
            frm.OkPressed += Frm_OkPressed;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // Enter new one
                FormEnterName frm_new_password = new FormEnterName(Properties.Resources.Title_PleaseEnterNEWPassword, "", true, true);
                if (frm_new_password.ShowDialog(this) == DialogResult.OK)
                {
                    // Confirm new password
                    FormEnterName frm_new_password_confirm = new FormEnterName(Properties.Resources.Title_PleaseEnterNEWPasswordAgainToConfirm, "", true, true);
                    if (frm_new_password_confirm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (frm_new_password.EnteredName == frm_new_password_confirm.EnteredName)
                        {
                            textBox_password.Text = frm_new_password.EnteredName;

                            ManagedMessageBox.ShowMessage(Properties.Resources.Message_PasswordHasBeenChangedSuccessfully, Properties.Resources.MessageCaption_ChangePassword);
                        }
                        else
                        {
                            ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_UnableToChangePasswordNotConfimed, Properties.Resources.MessageCaption_ChangePassword);
                        }
                    }
                }
            }
        }

        private void Frm_OkPressed(object sender, EnterNameFormOkPressedArgs e)
        {
            if (textBox_password.Text != e.NameEntered)
            {
                ManagedMessageBox.ShowErrorMessage(Properties.Resources.Message_IncorrectPassword, Properties.Resources.MessageCaption_ChangePassword);
                e.Cancel = true;
                return;
            }
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !checkBox_show_password.Checked;
        }
    }
}
