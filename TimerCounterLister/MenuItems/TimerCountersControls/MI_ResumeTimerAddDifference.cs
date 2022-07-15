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
    [MIRInfo("Resume Selected Timer Counter Add Difference", "cmi.tcl.tcc.resume.with.difference", true, false)]
    [MIRResourcesInfo("CMI_Name_ResumeTimerCounterWithDifference", "CMI_Tooltip_ResumeTimerCounterWithDifference", "control_play_blue")]
    [CMIInfo("tcl.tcc.resume.with.difference")]
    [Shortcut("LeftControl+LeftShift+Space", true)]
    class MI_ResumeTimerAddDifference : CMI
    {
        public MI_ResumeTimerAddDifference() : base()
        {
            TCLCoreService.TCLC.SelectedTimerCounterIndexChanged += TCLC_SelectedTimerCounterIndexChanged;
        }
        private bool status;
        private void TCLC_SelectedTimerCounterIndexChanged(object sender, System.EventArgs e)
        {
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex < 0)
            {
                OnActiveStatusChanged(status = false);
                return;
            }
            if (TCLCoreService.TCLC.SelectedTimerCounterIndex >= TCLCoreService.TCLC.CurrentProfile.TimerCounters.Length)
            {
                OnActiveStatusChanged(status = false);
                return;
            }
            status = !TCLCoreService.TCLC.CurrentProfile.TimerCounters[TCLCoreService.TCLC.SelectedTimerCounterIndex].BlockResumeWithAdd;
            OnActiveStatusChanged(status);
        }

        public override bool ActiveStatus
        {
            get
            {
                return status;
            }
        }
    }
}
