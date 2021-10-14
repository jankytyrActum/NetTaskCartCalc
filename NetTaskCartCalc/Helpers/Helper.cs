using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


namespace Plugins.Helpers
{
    /// <summary>
    /// Helper class.
    /// </summary>
    public static class Helper
    {
        #region CleanString

        /// <summary>
        /// Clean string from unwanted characters.
        /// </summary>
        /// <param name="input">Input string to clean.</param>
        /// <returns>Cleaned string.</returns>
        internal static string CleanString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            string result = input.Trim();

            result = result.Replace(Environment.NewLine, " ");
            result = result.Replace("\\\n", " ");
            result = result.Replace("\\n", " ");
            result = result.Replace("\\", " ");
            result = result.Replace("/", string.Empty);
            result = result.Replace("(", string.Empty);
            result = result.Replace("<", string.Empty);
            result = result.Replace("[", string.Empty);
            result = result.Replace("^", string.Empty);
            result = result.Replace(">", string.Empty);
            result = result.Replace("]", string.Empty);
            result = result.Replace(")", string.Empty);
            result = result.Replace("\u0000", string.Empty);

            while (result.Contains("  "))
            {
                result = result.Replace(" ", string.Empty);
            }

            return result;
        }
        #endregion
    }
}
