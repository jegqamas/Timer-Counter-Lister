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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerCounterLister
{
    public partial class FormTimerCounterPay : Form
    {
        public FormTimerCounterPay(double cost_so_far, double cost_per_minute, double balance, string currency)
        {
            InitializeComponent();
            timeEdit1.SetTime(0, false);
            this.cost_so_far = cost_so_far;
            this.balance = balance;
            this.currency = currency;
            label_currency.Text = currency;

            textBox_cost_so_far.Text = cost_so_far.ToString() + " " + currency;
            textBox_cost_pre_minute.Text = cost_per_minute + " " + currency + " " + Properties.Resources.Word_PerMinute;
            textBox_balance.Text = balance.ToString() + " " + currency;

            CalculateToPay();
            CalculateNewCostBalance();

            if (cost_so_far <= 0)
            {
                textBox_cost_so_far.Enabled = false;
                textBox_to_pay.Enabled = false;
                checkBox_use_balance.Enabled = false;
            }
        }
        double cost_so_far, balance;
        double current_to_pay;
        double current_tremains;
        string currency;
        double new_balance;
        double new_cost;
        bool is_calculating;
        double current_entered_amount;

        public double EnteredAmount { get { return timeEdit1.GetSeconds(); } }
        public double NewCostAfterEnteringAmount { get { return new_cost; } }
        public double NewBalanceAfterEneteringAmount { get { return new_balance; } }
        public double ToPay { get { return current_to_pay; } }

        private void CalculateToPay()
        {
            if (is_calculating)
                return;
            is_calculating = true;
            if (checkBox_use_balance.Checked)
            {
                current_to_pay = balance - cost_so_far;
                textBox_to_pay_details.Text = balance.ToString() + " - " + cost_so_far.ToString() + " = " + current_to_pay + " " + currency;
            }
            else
            {
                current_to_pay = 0 - cost_so_far;
                textBox_to_pay_details.Text = current_to_pay + " " + currency;
            }
            textBox_to_pay.Text = current_to_pay + " " + currency;
            textBox_to_pay.ForeColor = current_to_pay > 0 ? Color.LimeGreen : Color.Red;

            //timeEdit1.Enabled = current_to_pay < 0;
            is_calculating = false;
        }
        private void CalculateNewCostBalance()
        {
            if (is_calculating)
                return;
            is_calculating = true;
            if (checkBox_use_balance.Checked)
            {
                if (cost_so_far >= balance)
                    new_balance = 0;
                else
                    new_balance = balance - cost_so_far;
            }
            else
            {
                new_balance = balance;
            }

            if (current_to_pay < 0)
            {
                // new_cost = current_to_pay + timeEdit1.GetSeconds();
                current_tremains = current_to_pay + timeEdit1.GetSeconds();
                if (current_tremains < 0)
                {
                    new_cost = current_tremains;
                    current_tremains = 0;
                }
                else
                {
                    new_cost = 0;
                    if (checkBox_add_remains_to_balance.Checked)
                    {
                        new_balance += current_tremains;
                    }
                }
            }
            else
            {
                current_tremains = timeEdit1.GetSeconds();
                if (checkBox_add_remains_to_balance.Checked)
                {
                    new_balance += current_tremains;
                }
                new_cost = 0;
            }
            if (new_cost < 0)
                new_cost *= -1;

            textBox_new_balance.Text = new_balance + " " + currency;
            textBox_new_cost.Text = new_cost + " " + currency;
            textBox_remains.Text = current_tremains + " " + currency;
            is_calculating = false;
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
        // After entering amount
        private void timeEdit1_TimeChanged(object sender, EventArgs e)
        {
            if (current_entered_amount != timeEdit1.GetSeconds())
                CalculateNewCostBalance();

            current_entered_amount = timeEdit1.GetSeconds();
        }

        private void checkBox_add_remains_to_balance_CheckedChanged(object sender, EventArgs e)
        {
            CalculateNewCostBalance();
        }

        private void checkBox_use_balance_CheckedChanged(object sender, EventArgs e)
        {
            CalculateToPay();
            CalculateNewCostBalance();
        }
    }
}
