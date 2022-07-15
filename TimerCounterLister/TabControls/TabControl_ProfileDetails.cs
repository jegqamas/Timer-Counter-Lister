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

using ManagedUI;
using System.ComponentModel.Composition;

namespace TimerCounterLister
{
    [Export(typeof(ITabControl))]
    [ControlInfo("Profile Details", "tcl.tc.profiledetails")]
    [TabControlResourceInfo("TC_Name_ProfileDetails", "table")]
    class TabControl_ProfileDetails : ITabControl
    {
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_is_password_protected;
        private System.Windows.Forms.CheckBox checkBox_ask_for_password_each_time_i_do_an_activity;
        private System.Windows.Forms.TextBox textBox_profile_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_ask_password_on_app_close;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl_ProfileDetails));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_is_password_protected = new System.Windows.Forms.CheckBox();
            this.checkBox_ask_for_password_each_time_i_do_an_activity = new System.Windows.Forms.CheckBox();
            this.textBox_profile_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_ask_password_on_app_close = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::TimerCounterLister.Properties.Resources.pencil;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // richTextBox_desc
            // 
            this.richTextBox_desc.BackColor = System.Drawing.Color.White;
            this.richTextBox_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox_desc, "richTextBox_desc");
            this.richTextBox_desc.Name = "richTextBox_desc";
            this.richTextBox_desc.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_name, "textBox_name");
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkBox_is_password_protected
            // 
            this.checkBox_is_password_protected.AutoCheck = false;
            resources.ApplyResources(this.checkBox_is_password_protected, "checkBox_is_password_protected");
            this.checkBox_is_password_protected.Name = "checkBox_is_password_protected";
            this.checkBox_is_password_protected.UseVisualStyleBackColor = true;
            // 
            // checkBox_ask_for_password_each_time_i_do_an_activity
            // 
            this.checkBox_ask_for_password_each_time_i_do_an_activity.AutoCheck = false;
            resources.ApplyResources(this.checkBox_ask_for_password_each_time_i_do_an_activity, "checkBox_ask_for_password_each_time_i_do_an_activity");
            this.checkBox_ask_for_password_each_time_i_do_an_activity.Name = "checkBox_ask_for_password_each_time_i_do_an_activity";
            this.checkBox_ask_for_password_each_time_i_do_an_activity.UseVisualStyleBackColor = true;
            // 
            // textBox_profile_path
            // 
            this.textBox_profile_path.BackColor = System.Drawing.Color.White;
            this.textBox_profile_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox_profile_path, "textBox_profile_path");
            this.textBox_profile_path.Name = "textBox_profile_path";
            this.textBox_profile_path.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // checkBox_ask_password_on_app_close
            // 
            this.checkBox_ask_password_on_app_close.AutoCheck = false;
            resources.ApplyResources(this.checkBox_ask_password_on_app_close, "checkBox_ask_password_on_app_close");
            this.checkBox_ask_password_on_app_close.Name = "checkBox_ask_password_on_app_close";
            this.checkBox_ask_password_on_app_close.UseVisualStyleBackColor = true;
            // 
            // TabControl_ProfileDetails
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.checkBox_ask_password_on_app_close);
            this.Controls.Add(this.checkBox_ask_for_password_each_time_i_do_an_activity);
            this.Controls.Add(this.checkBox_is_password_protected);
            this.Controls.Add(this.richTextBox_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_profile_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabControl_ProfileDetails";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void Initialize()
        {
            base.Initialize();

            TCLCoreService.TCLC.NewProfileStarted += TCLC_NewProfileStarted;
            TCLCoreService.TCLC.ProfileAskForPasswordOnEachActivityChanged += TCLC_ProfileAskForPasswordOnEachActivityChanged;
            TCLCoreService.TCLC.ProfileDescriptionChanged += TCLC_ProfileDescriptionChanged;
            TCLCoreService.TCLC.ProfileIsPasswordProtectedChanged += TCLC_ProfileIsPasswordProtectedChanged;
            TCLCoreService.TCLC.ProfileNameChanged += TCLC_ProfileNameChanged;
            TCLCoreService.TCLC.ProfileOpened += TCLC_ProfileOpened;
            TCLCoreService.TCLC.ProfileAskForPasswordOnApplicationCloseChanged += TCLC_ProfileAskForPasswordOnApplicationCloseChanged;
        }
        private void RefreshProfileInformation()
        {
            textBox_name.Text = TCLCoreService.TCLC.CurrentProfile.Name;
            richTextBox_desc.Text = TCLCoreService.TCLC.CurrentProfile.Description;
            textBox_profile_path.Text = TCLCoreService.TCLC.CurrentProfilePath;
            checkBox_ask_for_password_each_time_i_do_an_activity.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity;
            checkBox_is_password_protected.Checked = TCLCoreService.TCLC.CurrentProfile.IsPasswordProtected;
            checkBox_ask_password_on_app_close.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnApplicationClose;
        }
        private void TCLC_ProfileOpened(object sender, System.EventArgs e)
        {
            RefreshProfileInformation();
        }
        private void TCLC_ProfileNameChanged(object sender, System.EventArgs e)
        {
            textBox_name.Text = TCLCoreService.TCLC.CurrentProfile.Name;
        }
        private void TCLC_ProfileIsPasswordProtectedChanged(object sender, System.EventArgs e)
        {
            checkBox_is_password_protected.Checked = TCLCoreService.TCLC.CurrentProfile.IsPasswordProtected;
        }
        private void TCLC_ProfileDescriptionChanged(object sender, System.EventArgs e)
        {
            richTextBox_desc.Text = TCLCoreService.TCLC.CurrentProfile.Description;
        }
        private void TCLC_ProfileAskForPasswordOnEachActivityChanged(object sender, System.EventArgs e)
        {
            checkBox_ask_for_password_each_time_i_do_an_activity.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnEachActivity;
        }
        private void TCLC_ProfileAskForPasswordOnApplicationCloseChanged(object sender, System.EventArgs e)
        {
            checkBox_ask_password_on_app_close.Checked = TCLCoreService.TCLC.CurrentProfile.AskForPasswordOnApplicationClose;
        }
        private void TCLC_NewProfileStarted(object sender, System.EventArgs e)
        {
            RefreshProfileInformation();
        }
        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            CommandsManager.CMD.Execute("tcl.edit.profile.details");
        }
    }
}
