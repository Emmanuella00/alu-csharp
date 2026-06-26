using System.Collections.Generic;

namespace Text
{
    /// <summary>String helpers.</summary>
    public class Str
    {
        /// <summary>Returns index of first non-repeating character.</summary>
        /// <param name="s">The string to check.</param>
        /// <returns>Index of first unique character or -1 if none.</returns>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
                return -1;

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}