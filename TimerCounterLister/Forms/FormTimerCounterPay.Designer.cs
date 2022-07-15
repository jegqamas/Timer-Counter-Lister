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
    partial class FormTimerCounterPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimerCounterPay));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cost_so_far = new System.Windows.Forms.TextBox();
            this.textBox_cost_pre_minute = new System.Windows.Forms.TextBox();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_use_balance = new System.Windows.Forms.CheckBox();
            this.textBox_to_pay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_to_pay_details = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeEdit1 = new TimerCounterLister.TimeEdit();
            this.textBox_new_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_new_cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_add_remains_to_balance = new System.Windows.Forms.CheckBox();
            this.textBox_remains = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_currency = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_cost_so_far
            // 
            resources.ApplyResources(this.textBox_cost_so_far, "textBox_cost_so_far");
            this.textBox_cost_so_far.BackColor = System.Drawing.Color.White;
            this.textBox_cost_so_far.Name = "textBox_cost_so_far";
            this.textBox_cost_so_far.ReadOnly = true;
            // 
            // textBox_cost_pre_minute
            // 
            resources.ApplyResources(this.textBox_cost_pre_minute, "textBox_cost_pre_minute");
            this.textBox_cost_pre_minute.BackColor = System.Drawing.Color.White;
            this.textBox_cost_pre_minute.Name = "textBox_cost_pre_minute";
            this.textBox_cost_pre_minute.ReadOnly = true;
            // 
            // textBox_balance
            // 
            resources.ApplyResources(this.textBox_balance, "textBox_balance");
            this.textBox_balance.BackColor = System.Drawing.Color.White;
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkBox_use_balance
            // 
            resources.ApplyResources(this.checkBox_use_balance, "checkBox_use_balance");
            this.checkBox_use_balance.Checked = true;
            this.checkBox_use_balance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_use_balance.Name = "checkBox_use_balance";
            this.checkBox_use_balance.UseVisualStyleBackColor = true;
            this.checkBox_use_balance.CheckedChanged += new System.EventHandler(this.checkBox_use_balance_CheckedChanged);
            // 
            // textBox_to_pay
            // 
            resources.ApplyResources(this.textBox_to_pay, "textBox_to_pay");
            this.textBox_to_pay.BackColor = System.Drawing.Color.White;
            this.textBox_to_pay.Name = "textBox_to_pay";
            this.textBox_to_pay.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox_to_pay_details
            // 
            resources.ApplyResources(this.textBox_to_pay_details, "textBox_to_pay_details");
            this.textBox_to_pay_details.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_to_pay_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_to_pay_details.Name = "textBox_to_pay_details";
            this.textBox_to_pay_details.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // timeEdit1
            // 
            resources.ApplyResources(this.timeEdit1, "timeEdit1");
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.TimeChanged += new System.EventHandler<System.EventArgs>(this.timeEdit1_TimeChanged);
            // 
            // textBox_new_balance
            // 
            resources.ApplyResources(this.textBox_new_balance, "textBox_new_balance");
            this.textBox_new_balance.BackColor = System.Drawing.Color.White;
            this.textBox_new_balance.Name = "textBox_new_balance";
            this.textBox_new_balance.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox_new_cost
            // 
            resources.ApplyResources(this.textBox_new_cost, "textBox_new_cost");
            this.textBox_new_cost.BackColor = System.Drawing.Color.White;
            this.textBox_new_cost.Name = "textBox_new_cost";
            this.textBox_new_cost.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            this.groupBox1.Controls.Add(this.checkBox_add_remains_to_balance);
            this.groupBox1.Controls.Add(this.textBox_remains);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_currency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_to_pay);
            this.groupBox1.Controls.Add(this.textBox_to_pay_details);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.timeEdit1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_add_remains_to_balance
            // 
            resources.ApplyResources(this.checkBox_add_remains_to_balance, "checkBox_add_remains_to_balance");
            this.checkBox_add_remains_to_balance.Checked = true;
            this.checkBox_add_remains_to_balance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_add_remains_to_balance.Name = "checkBox_add_remains_to_balance";
            this.checkBox_add_remains_to_balance.UseVisualStyleBackColor = true;
            this.checkBox_add_remains_to_balance.CheckedChanged += new System.EventHandler(this.checkBox_add_remains_to_balance_CheckedChanged);
            // 
            // textBox_remains
            // 
            resources.ApplyResources(this.textBox_remains, "textBox_remains");
            this.textBox_remains.BackColor = System.Drawing.Color.White;
            this.textBox_remains.Name = "textBox_remains";
            this.textBox_remains.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label_currency
            // 
            resources.ApplyResources(this.label_currency, "label_currency");
            this.label_currency.Name = "label_currency";
            // 
            // FormTimerCounterPay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_new_cost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_new_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_use_balance);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cost_pre_minute);
            this.Controls.Add(this.textBox_cost_so_far);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTimerCounterPay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cost_so_far;
        private System.Windows.Forms.TextBox textBox_cost_pre_minute;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_use_balance;
        private System.Windows.Forms.TextBox textBox_to_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_to_pay_details;
        private System.Windows.Forms.Label label4;
        private TimeEdit timeEdit1;
        private System.Windows.Forms.TextBox textBox_new_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_new_cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_currency;
        private System.Windows.Forms.CheckBox checkBox_add_remains_to_balance;
        private System.Windows.Forms.TextBox textBox_remains;
        private System.Windows.Forms.Label label7;
    }
}