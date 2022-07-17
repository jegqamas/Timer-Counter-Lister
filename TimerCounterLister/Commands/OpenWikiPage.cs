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
using System.Diagnostics;
using ManagedUI;
using System.ComponentModel.Composition;

namespace TimerCounterLister
{
    /*
    * Open profile, check if there is any changes in the profile that require save first. 
    * 
    * 
    * Parameters:
    * string FilePath: the profile file path. Cannot be empty or null. It must be exist as well.
    * 
    * Returns:
    * N/A
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Show Wiki", "tcl.show.wiki", "tcl.core")]
    class OpenWikiPage : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[0];
            try
            {
                Process.Start("https://github.com/jegqamas/Timer-Counter-Lister/wiki");
            }
            catch { }
        }
    }
}
