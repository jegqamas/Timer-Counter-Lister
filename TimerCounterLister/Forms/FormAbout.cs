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
using ManagedUI;
namespace TimerCounterLister
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            label_copyright.Text = MUI.ProjectCopyright;
            label_version.Text = Properties.Resources.Word_Version + ": " + MUI.ProjectVersion;
            label_written_by.Text = Properties.Resources.Word_WrittenBy + ": " + Properties.Resources.Word_AlaaIbrahimHadid;
            richTextBox1.Text = Properties.Resources.Word_AboutDetails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:alaahadidfreeware@gmail.com");
            }
            catch { }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/jegqamas/Timer-Counter-Lister");
            }
            catch { }
        }
    }
}
