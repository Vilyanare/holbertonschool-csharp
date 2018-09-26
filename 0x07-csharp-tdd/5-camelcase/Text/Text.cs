using System;

namespace Text
{
    /// <summary>
    /// Provides CamelCase method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the words in a camelcase formatted string.
        /// </summary>
        /// <param name="s">String to check.</param>
        /// <returns>Integer of how many words are in the string.</returns>
        public static int CamelCase(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }
            int count = 1;
            foreach (char letter in s)
            {
                if (Char.IsUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
