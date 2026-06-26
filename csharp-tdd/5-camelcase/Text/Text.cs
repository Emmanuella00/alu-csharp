namespace Text
{
    /// <summary>String helpers.</summary>
    public class Str
    {
        /// <summary>Counts words in a camelCase string.</summary>
        /// <param name="s">The camelCase string to check.</param>
        /// <returns>Number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            int count = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    count++;
            }

            return count;
        }
    }
}
