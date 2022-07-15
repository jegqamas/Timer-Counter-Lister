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
    partial class FormBalanceTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalanceTransaction));
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_withdraw = new System.Windows.Forms.RadioButton();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.label_currency = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeEdit1 = new TimerCounterLister.TimeEdit();
            this.textBox_new_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            // radioButton_withdraw
            // 
            resources.ApplyResources(this.radioButton_withdraw, "radioButton_withdraw");
            this.radioButton_withdraw.Checked = true;
            this.radioButton_withdraw.Name = "radioButton_withdraw";
            this.radioButton_withdraw.TabStop = true;
            this.radioButton_withdraw.UseVisualStyleBackColor = true;
            this.radioButton_withdraw.CheckedChanged += new System.EventHandler(this.radioButton_withdraw_CheckedChanged);
            // 
            // radioButton_add
            // 
            resources.ApplyResources(this.radioButton_add, "radioButton_add");
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.TabStop = true;
            this.radioButton_add.UseVisualStyleBackColor = true;
            this.radioButton_add.CheckedChanged += new System.EventHandler(this.radioButton_add_CheckedChanged);
            // 
            // label_currency
            // 
            resources.ApplyResources(this.label_currency, "label_currency");
            this.label_currency.Name = "label_currency";
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
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormBalanceTransaction
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_new_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_currency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.radioButton_add);
            this.Controls.Add(this.radioButton_withdraw);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBalanceTransaction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_withdraw;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.Label label_currency;
        private System.Windows.Forms.Label label4;
        private TimeEdit timeEdit1;
        private System.Windows.Forms.TextBox textBox_new_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}