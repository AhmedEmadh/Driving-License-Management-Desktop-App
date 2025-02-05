using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Driving_License_Management_Desktop_App.Global_Classes
{
    public class clsValidation
    {
        /// <summary>
        /// Validates whether the given email address is in a proper format.
        /// </summary>
        public static bool ValidateEmail(string EmailAddress)
        {
            if (string.IsNullOrWhiteSpace(EmailAddress))
                return false;

            // Email regex pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(EmailAddress, pattern);
        }

        /// <summary>
        /// Validates if the given string represents a valid integer.
        /// </summary>
        public static bool ValidateInteger(string Number)
        {
            if (string.IsNullOrWhiteSpace(Number))
                return false;

            return int.TryParse(Number, out _);
        }

        /// <summary>
        /// Validates if the given string represents a valid floating-point number.
        /// </summary>
        public static bool ValidateFloat(string Number)
        {
            if (string.IsNullOrWhiteSpace(Number))
                return false;

            return float.TryParse(Number, out _);
        }

        /// <summary>
        /// Checks if the given string represents any numeric type (integer or float).
        /// </summary>
        public static bool IsNumber(string Number)
        {
            if (string.IsNullOrWhiteSpace(Number))
                return false;

            return double.TryParse(Number, out _);
        }
    }
}
