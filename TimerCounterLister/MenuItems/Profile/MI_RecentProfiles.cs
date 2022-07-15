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
    [Export(typeof(DMI)), Export(typeof(IMenuItemRepresentator))]
    [MIRInfo("Recent Profiles", "dmi.recent.profiles")]
    [MIRResourcesInfo("DMI_Name_RecentProfiles")]
    class MI_RecentProfiles : DMI
    {
        public override void OnView()
        {
            ChildItems.Clear();
            // Get all supported languages
            for (int i = 0; i < TCLCoreService.TCLC.RecentProfiles.Count; i++)
            {
                DMIChild chld = new DMIChild(ID);

                chld.DisplayName = TCLCoreService.TCLC.RecentProfiles[i];

                chld.CommandID = "tcl.open.profile";
                chld.UseParameters = true;
                chld.Parameters = new object[] { TCLCoreService.TCLC.RecentProfiles[i] };

                ChildItems.Add(chld);
            }
        }
    }
}
