using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_Desktop_App.Global_Classes
{
    public class clsUtil
    {
        /// <summary>
        /// Generates a new unique GUID string.
        /// </summary>
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Creates a folder if it does not exist.
        /// </summary>
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            try
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                return true;
            }
            catch
            {
                return false; // Return false if there is an exception (e.g., permission issues)
            }
        }

        /// <summary>
        /// Replaces the filename with a GUID while keeping the same extension.
        /// </summary>
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            if (string.IsNullOrWhiteSpace(sourceFile))
            {
                return GenerateGUID(); // If the source file is empty, just return a GUID
            }

            FileInfo fi = new FileInfo(sourceFile);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }

        /// <summary>
        /// Copies an image file to the project images folder and updates the sourceFile path.
        /// </summary>
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DestinationFolder = @"C:\DBImages";

            // Ensure the destination folder exists
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            // Generate a new file name with a GUID
            string newFileName = ReplaceFileNameWithGUID(sourceFile);
            string destinationFile = Path.Combine(DestinationFolder, newFileName);

            try
            {
                // Copy the file to the new location
                File.Copy(sourceFile, destinationFile, true);
                sourceFile = destinationFile; // Update the reference to the new file path
                return true;
            }
            catch (Exception)
            {
                return false; // Return false if the copy operation fails
            }
        }
    }
}
