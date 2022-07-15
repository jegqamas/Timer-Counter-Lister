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
    [Export(typeof(CMI)), Export(typeof(IMenuItemRepresentator))]
    [MIRInfo("Start/Resume All Timer Counters", "cmi.tcl.tcc.startresume.all")]
    [MIRResourcesInfo("CMI_Name_StartResumeAllTimerCounters", "CMI_Tooltip_StartResumeAllTimerCounters", "time_go")]
    [CMIInfo("tcl.tcc.startresume.all")]
    [Shortcut("LeftControl+LeftAlt+Space", true)]
    class MI_StartResumeAllTimers : CMI
    {
    }
}
