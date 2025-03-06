using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_DataAccessLayer
{
    public class clsLogger
    {
        private static string sourceName = "DrivingLicenseManagementDesktopApp";

        static clsLogger()
        {
            try
            {
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }
            }
            catch
            {
                // Cannot Check because Application Don't Have Permission
            }

        }


        /// <summary>
        /// Logs an exception to the Windows Event Viewer with the specified entry type.
        /// The default entry type is Error if not specified.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        /// <param name="entryType">The type of entry to log (e.g., Error, Warning, Information). Default is Error.</param>
        public static void Log(Exception ex, EventLogEntryType entryType = EventLogEntryType.Error)
        {
            try
            {
                EventLog.WriteEntry(sourceName, FormatErrorMessage(ex), entryType);
            }
            catch
            {
                // Cannot Check because Application Don't Have Permission
            }
        }



        private static string FormatErrorMessage(Exception ex)
        {

            // this is an example
            /*
                --- Exception Log ---
                Timestamp: 3/3/2025 6:45:32 PM
                Message: File not found.
                Inner Exception: File path was null.
                Stack Trace: at MyApp.Program.Main() in C:\Project\MyApp\Program.cs:line 24
                Source: MyApp
                -----------------------
             */

            string message =

                 $"--- Exception Log ---\n" +
                 $"Timestamp: {DateTime.Now}\n" +
                 $"Message: {ex.Message}\n" +
                 $"Inner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}\n" +
                 $"Stack Trace: {ex.StackTrace}\n" +
                 $"Source: {ex.Source}\n" +
                 $"-----------------------";

            return message;
        }


    }
}
