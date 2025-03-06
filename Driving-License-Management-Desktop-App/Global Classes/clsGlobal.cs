using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_License_Management_BusinessLogic;
using Microsoft.Win32;
namespace Driving_License_Management_Desktop_App.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;
        static bool _RememberUsernameAndPasswordUsingFile(string Username, string Password)
        {
            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        static bool _GetStoredCredentialUsingFile(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        static bool _RememberUsernameAndPasswordUsingRegistery(string Username, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\LocalDrivingLicenseManagementDesktopApp";
            string UserName_ValueName = "UserName";
            string Password_ValueName = "Password";
            string UserName_ValueData = Username;
            string Password_ValueData = Password;

            try
            {
                Registry.SetValue(KeyPath, UserName_ValueName, UserName_ValueData, RegistryValueKind.String);
                Registry.SetValue(KeyPath, Password_ValueName, Password_ValueData, RegistryValueKind.String);

                return true;
            }
            catch
            {
                return false;
            }
        }
        static bool _GetStoredCredentialUsingRegistery(ref string Username, ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\LocalDrivingLicenseManagementDesktopApp";
            string UserName_ValueName = "UserName";
            string Password_ValueName = "Password";
            try
            {
                String UserName_ValueData = Registry.GetValue(KeyPath, UserName_ValueName, null) as string;
                String Password_ValueData = Registry.GetValue(KeyPath, Password_ValueName, null) as string;
                if (UserName_ValueData != null && Password_ValueData != null)
                {
                    Username = UserName_ValueData;
                    Password = Password_ValueData;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            return _RememberUsernameAndPasswordUsingRegistery(Username, Password);
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            return _GetStoredCredentialUsingRegistery(ref Username, ref Password);

        }

        public static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
