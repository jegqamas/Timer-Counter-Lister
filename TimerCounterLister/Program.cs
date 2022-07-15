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
using System.Linq;
using System.Windows.Forms;
using ManagedUI;

namespace TimerCounterLister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Optional: get information from assembly and register it
            ManagedUIApplicationInfo.Initialize(System.Reflection.Assembly.GetExecutingAssembly());

            // We need to setup the MUI using parameters.
            MUIParameters parameters = new MUIParameters();
            parameters.ProjectTitle = "Timer Lister Counter";// Project title, this will be displayed in the splash window as well.
            parameters.ProjectCopyright = Properties.Resources.Word_Copyright + " (C) 2021 - 2022 " + Properties.Resources.Word_AlaaIbrahimHadid;// Enter your copyright message here.
            parameters.ProjectCopyrightMessage = Properties.Resources.Word_CopyrightMessage;
            parameters.ProjectVersion = ManagedUIApplicationInfo.ApplicationVersion;// Enter the program version here

            // REQUIRED: we must fill required services ids in order for our application to work.
            // YOU CANNOT USE MUI BUILT IN SERVICES, such as "cmd" or "gui".
            // At least one service must be listed. The application will not launch if a service is missing, not loaded or blacklisted.
            parameters.RequiredServiceIDS = new List<string>();
            parameters.RequiredServiceIDS.Add("tcl.core");
            // Do we want out application to accept all services ? i.e. accept add ons ? TRUE: all services will be accepted regardless if they are built in or required.
            // FALSE: Only service that 1 built in 2 in the required services list will be accepted. Default is FALSE, that means even there are million service in the application
            // directory, the application will only use the accepted one ^.
            // in this demo, we are allowing all services.
            parameters.AllowAllServices = true;

            // This will show getting started dialog.
            parameters.StartupArguments = new List<string>();
            parameters.StartupArguments.Add("tcl.show.gettingstarted");
#if DEBUG
            /* DEBUGGING CONSOLE, comment these 2 lines to disable console or build with no DEBUG label.*/
            //
            //parameters.StartupArguments.Add("console.show");
#endif

            // Optionals
            parameters.ProjectIcon = Properties.Resources.TimerCounterLister;// You can use an icon from the resources, from a file ...etc
            parameters.ShowSplash = false;// Set to false if you don't want to show the splash window on load
            //parameters.UseColorForSplashBackground = true;// We are going to use color as background for splash window instead of image.
            //parameters.SplashBackgroundColor = System.Drawing.Color.PowderBlue;// hmmm ...
            //parameters.SplashBackgroundImage = null;// You can set a background image for the splash window (when parameters.ShowSplash = true of course), the image will be displayed stretched.
            //parameters.SplashSize = new System.Drawing.Size(650, 260);// We set this when the splash window doesn't fit our information.

            // !! OPTIONALS !!
            // GUIConfiguration settings are optionals, allows for further config for the app. All settings (properties) are set to true by default.
            // Change the GUI configuration, what's the GUI allows the end-user to do. We MUST change these settings here before the core load.
            // We can set the default main window size here, later on, user resizing values will be saved and used. This value is 1444, 906 by default.
            GUIConfiguration.MainWindowDefaultSize = new System.Drawing.Size(1000, 700);
            // Here we can disable the ability for user to change the interface language. If false, this will remove the commands and the menu items that allows the user
            // to change the language.
            GUIConfiguration.UserCanChangeLanguage = true;
            // Here we can disable the ability for user to edit the main menu. Same as above ...
            GUIConfiguration.UserCanEditMenu = true;
            // Here we can disable the ability for user to edit the shortcuts. Same as above ...
            GUIConfiguration.UserCanEditShortcuts = true;
            // Here we can disable the ability for user to edit the theme. Same as above ...
            GUIConfiguration.UserCanEditTheme = true;
            // Here we can disable the ability for user to edit the theme. Same as above ...
            GUIConfiguration.UserCanEditToolbars = true;
            // Here we can disable the ability for user to hide or show tab controls. Same as above ...
            GUIConfiguration.UserCanHideTabs = true;
            // Here we can disable the ability for user to hide or show toolbars. Same as above ...
            GUIConfiguration.UserCanHideToolbars = true;
            // If you want to disable the default exit menu item and make one of your own .... the command won't be affected and will be still there.
            GUIConfiguration.EnableExitCMI = true;
            // If you want to disable the default help menu item and make one of your own .... the command won't be affected and will be still there.
            GUIConfiguration.EnableHelpCMI = true;
            // If you want to disable the default settings menu item and make one of your own .... the command won't be affected and will be still there.
            GUIConfiguration.EnableShowSettingsCMI = false;
            // SETTINGS
            // You can disable environment settings here
            // This settings control allows to edit the main menu.
            GUIConfiguration.EnableMenuItemsSettingsControl = false;
            // This settings control allows to edit the hotkeys.
            GUIConfiguration.EnableShortcutsHotkeysSettingsControl = false;
            // This settings control allows to edit the theme.
            GUIConfiguration.EnableThemeSettingsControl = false;


            // All we need now is to call this method at program's main !!
            MUI.Initialize(parameters);
        }
    }
}
