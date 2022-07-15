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

namespace TimerCounterLister
{
    public partial class FormBalanceTransaction : Form
    {
        public FormBalanceTransaction(double balance, string currency)
        {
            InitializeComponent();
            this.balance = balance;
            this.currency = currency;
            textBox_balance.Text = balance.ToString() + " " + currency;

            timeEdit1.SetTime(0, false);

            if (balance <= 0)
            {
                radioButton_add.Checked = true;
                radioButton_withdraw.Checked = false;
                radioButton_withdraw.Enabled = false;
            }

            CalculateNewBalance();
        }
        double balance, new_balance;
        public double NewBalance { get { return new_balance; } }
        string currency;

        private void CalculateNewBalance()
        {
            if (radioButton_add.Checked)
            {
                new_balance = balance + timeEdit1.GetSeconds();
            }
            else
            {
                if (balance - timeEdit1.GetSeconds() <= 0)
                {
                    timeEdit1.SetTime(balance, false);
                }
                new_balance = balance - timeEdit1.GetSeconds();
            }
            textBox_balance.Text = balance.ToString() + " " + currency;
            textBox_new_balance.Text = new_balance.ToString() + " " + currency;
        }
        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        // Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void radioButton_withdraw_CheckedChanged(object sender, EventArgs e)
        {
            CalculateNewBalance();
        }

        private void radioButton_add_CheckedChanged(object sender, EventArgs e)
        {
            CalculateNewBalance();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timeEdit1.SetTime(balance, false);
            CalculateNewBalance();
        }

        // Amount entered
        private void timeEdit1_TimeChanged(object sender, EventArgs e)
        {
            CalculateNewBalance();
        }
    }
}
