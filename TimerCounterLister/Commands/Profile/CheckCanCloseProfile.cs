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
using System.Diagnostics;
using ManagedUI;
using System.ComponentModel.Composition;

namespace TimerCounterLister
{
    /*
    * Check For Profile Password, work if profile is protected with a password. If not, it will return True.
    * 
    * Parameters:
    * N/A
    * 
    * Returns:
    * bool Confirm: True: password is correct or profile is not protected with a password. 
    *               False: password is not correct and profile is protected with a password.
    */

    [Export(typeof(ICommand))]
    [CommandInfo("Check For Profile Close Ability", "tcl.profile.check.profile.close.ability", "tcl.core")]
    class CheckCanCloseProfile : ICommand
    {
        public override void Execute(object[] parameters, out object[] responses)
        {
            responses = new object[1];
            if (TCLCoreService.TCLC.CurrentProfile == null)
            {
                responses[0] = true;
                return;
            }
            foreach (TimerCounter tt in TCLCoreService.TCLC.CurrentProfile.TimerCounters)
            {
                if (tt.IsTimerStarted && !tt.IsTimerPaused)
                {
                    responses[0] = false;
                    return;
                }
            }
            responses[0] = true;
        }
    }
}
