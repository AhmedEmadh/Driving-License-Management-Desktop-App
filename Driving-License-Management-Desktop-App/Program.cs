﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_License_Management_Desktop_App.User;
namespace Driving_License_Management_Desktop_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen());
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        private static void SetDPIAware()
        {
            if (Environment.OSVersion.Version.Major >= 6) // Windows Vista or later
            {
                SetProcessDPIAware();
            }
        }
    }
}
