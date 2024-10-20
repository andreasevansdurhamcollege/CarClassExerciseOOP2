// Author:  Kyle Chapman
// Date:    October 9, 2024
// Description:
// A utility class of common validation functions -
// at least for the scope of the course I'm teaching
// right now.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    static class Validation
    {
        /// <summary>
        /// Checks if a value is a valid double.
        /// </summary>
        /// <param name="value">a string that we want to check if it can be parsed</param>
        /// <returns>true if it can be parsed; false otherwise</returns>
        public static bool IsDouble(string value)
        {
            double number;
            if (double.TryParse(value, out number)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a value is a valid decimal.
        /// </summary>
        /// <param name="value">a string that we want to check if it can be parsed</param>
        /// <returns>true if it can be parsed; false otherwise</returns>
        public static bool IsDecimal(string value)
        {
            decimal number;
            if (decimal.TryParse(value, out number)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a value is a valid integer.
        /// </summary>
        /// <param name="value">a string that we want to check if it can be parsed</param>
        /// <returns>true if it can be parsed; false otherwise</returns>
        public static bool IsInteger(string value)
        {
            int number;
            if (int.TryParse(value, out number)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a value is in the specified range.
        /// </summary>
        /// <param name="value">a number that you want to validate the range of</param>
        /// <param name="minimum">the bottom of the range you are checking (inclusive)</param>
        /// <param name="maximum">the top of the range you are checking (inclusive)</param>
        /// <returns>true if it is in range; false otherwise</returns>
        public static bool IsInRange(double value, double minimum, double maximum)
        {
            if (value < minimum || value > maximum) return false;
            return true;
        }

        /// <summary>
        /// Checks if a value is in the specified range.
        /// </summary>
        /// <param name="value">a number that you want to validate the range of</param>
        /// <param name="minimum">the bottom of the range you are checking (inclusive)</param>
        /// <param name="maximum">the top of the range you are checking (inclusive)</param>
        /// <returns>true if it is in range; false otherwise</returns>
        public static bool IsInRange(decimal value, decimal minimum, decimal maximum)
        {
            if (value < minimum || value > maximum) return false;
            return true;
        }

        /// <summary>
        /// Checks if a value is in the specified range.
        /// </summary>
        /// <param name="value">a number that you want to validate the range of</param>
        /// <param name="minimum">the bottom of the range you are checking (inclusive)</param>
        /// <param name="maximum">the top of the range you are checking (inclusive)</param>
        /// <returns>true if it is in range; false otherwise</returns>
        public static bool IsInRange(int value, int minimum, int maximum)
        {
            if (value < minimum || value > maximum) return false;
            return true;
        }

    }
}
