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
    partial class FormAddTimerCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTimerCounter));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_timer_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_timer_description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeEdit_cost_per_minute = new TimerCounterLister.TimeEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.timeEdit_start_balance = new TimerCounterLister.TimeEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_currency = new System.Windows.Forms.TextBox();
            this.checkBox_start_timer_instantly = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_preview = new System.Windows.Forms.TextBox();
            this.checkBox_allow_resume_timer_with_difference_add = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_timer_rate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_timer_name
            // 
            resources.ApplyResources(this.textBox_timer_name, "textBox_timer_name");
            this.textBox_timer_name.Name = "textBox_timer_name";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // richTextBox_timer_description
            // 
            resources.ApplyResources(this.richTextBox_timer_description, "richTextBox_timer_description");
            this.richTextBox_timer_description.Name = "richTextBox_timer_description";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // timeEdit_cost_per_minute
            // 
            resources.ApplyResources(this.timeEdit_cost_per_minute, "timeEdit_cost_per_minute");
            this.timeEdit_cost_per_minute.Name = "timeEdit_cost_per_minute";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // timeEdit_start_balance
            // 
            resources.ApplyResources(this.timeEdit_start_balance, "timeEdit_start_balance");
            this.timeEdit_start_balance.Name = "timeEdit_start_balance";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox_currency
            // 
            resources.ApplyResources(this.textBox_currency, "textBox_currency");
            this.textBox_currency.Name = "textBox_currency";
            // 
            // checkBox_start_timer_instantly
            // 
            resources.ApplyResources(this.checkBox_start_timer_instantly, "checkBox_start_timer_instantly");
            this.checkBox_start_timer_instantly.Checked = true;
            this.checkBox_start_timer_instantly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_start_timer_instantly.Name = "checkBox_start_timer_instantly";
            this.checkBox_start_timer_instantly.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox_preview);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_preview
            // 
            resources.ApplyResources(this.textBox_preview, "textBox_preview");
            this.textBox_preview.BackColor = System.Drawing.Color.White;
            this.textBox_preview.Name = "textBox_preview";
            this.textBox_preview.ReadOnly = true;
            // 
            // checkBox_allow_resume_timer_with_difference_add
            // 
            resources.ApplyResources(this.checkBox_allow_resume_timer_with_difference_add, "checkBox_allow_resume_timer_with_difference_add");
            this.checkBox_allow_resume_timer_with_difference_add.Checked = true;
            this.checkBox_allow_resume_timer_with_difference_add.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_allow_resume_timer_with_difference_add.Name = "checkBox_allow_resume_timer_with_difference_add";
            this.checkBox_allow_resume_timer_with_difference_add.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_timer_rate
            // 
            resources.ApplyResources(this.label_timer_rate, "label_timer_rate");
            this.label_timer_rate.Name = "label_timer_rate";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // FormAddTimerCounter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_timer_rate);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox_allow_resume_timer_with_difference_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_start_timer_instantly);
            this.Controls.Add(this.textBox_currency);
            this.Controls.Add(this.timeEdit_start_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeEdit_cost_per_minute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_timer_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_timer_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddTimerCounter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_timer_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_timer_description;
        private System.Windows.Forms.Label label3;
        private TimeEdit timeEdit_cost_per_minute;
        private System.Windows.Forms.Label label4;
        private TimeEdit timeEdit_start_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_currency;
        private System.Windows.Forms.CheckBox checkBox_start_timer_instantly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_preview;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox_allow_resume_timer_with_difference_add;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_timer_rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}