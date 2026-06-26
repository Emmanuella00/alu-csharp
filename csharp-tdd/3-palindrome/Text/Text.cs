using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>String helpers.</summary>
    public class Str
    {
        /// <summary>Checks if a string is a palindrome.</summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return true;

            // Remove non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s.ToLower(), @"[^a-z0-9]", "");

            if (cleaned.Length == 0)
                return true;

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}