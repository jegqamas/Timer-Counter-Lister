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
namespace TimerCounterLister
{
    partial class FormAddNewTimerCounterAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewTimerCounterAlarm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_days = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_hours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_minutes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_seconds = new System.Windows.Forms.NumericUpDown();
            this.checkBox_pause_timer_on_trigger = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_set_as_triggered = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_alarm_files = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_name
            // 
            resources.ApplyResources(this.textBox_name, "textBox_name");
            this.textBox_name.Name = "textBox_name";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // richTextBox_desc
            // 
            resources.ApplyResources(this.richTextBox_desc, "richTextBox_desc");
            this.richTextBox_desc.Name = "richTextBox_desc";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numericUpDown_days
            // 
            resources.ApplyResources(this.numericUpDown_days, "numericUpDown_days");
            this.numericUpDown_days.Name = "numericUpDown_days";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // numericUpDown_hours
            // 
            resources.ApplyResources(this.numericUpDown_hours, "numericUpDown_hours");
            this.numericUpDown_hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_hours.Name = "numericUpDown_hours";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numericUpDown_minutes
            // 
            resources.ApplyResources(this.numericUpDown_minutes, "numericUpDown_minutes");
            this.numericUpDown_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_minutes.Name = "numericUpDown_minutes";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numericUpDown_seconds
            // 
            resources.ApplyResources(this.numericUpDown_seconds, "numericUpDown_seconds");
            this.numericUpDown_seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_seconds.Name = "numericUpDown_seconds";
            this.numericUpDown_seconds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // checkBox_pause_timer_on_trigger
            // 
            resources.ApplyResources(this.checkBox_pause_timer_on_trigger, "checkBox_pause_timer_on_trigger");
            this.checkBox_pause_timer_on_trigger.Name = "checkBox_pause_timer_on_trigger";
            this.checkBox_pause_timer_on_trigger.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // checkBox_set_as_triggered
            // 
            resources.ApplyResources(this.checkBox_set_as_triggered, "checkBox_set_as_triggered");
            this.checkBox_set_as_triggered.Name = "checkBox_set_as_triggered";
            this.checkBox_set_as_triggered.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // comboBox_alarm_files
            // 
            resources.ApplyResources(this.comboBox_alarm_files, "comboBox_alarm_files");
            this.comboBox_alarm_files.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_alarm_files.FormattingEnabled = true;
            this.comboBox_alarm_files.Name = "comboBox_alarm_files";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormAddNewTimerCounterAlarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox_alarm_files);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox_set_as_triggered);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_pause_timer_on_trigger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_seconds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_hours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_days);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddNewTimerCounterAlarm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNewTimerCounterAlarm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_hours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_minutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_seconds;
        private System.Windows.Forms.CheckBox checkBox_pause_timer_on_trigger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox_set_as_triggered;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_alarm_files;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}