using System;

namespace Text
{
    /// <summary>
    /// Provides UniqueChar method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds first non repeating Char in given string.
        /// </summary>
        /// <param name="s">String to check for uniques.</param>
        /// <returns>Index of unique char or -1 if none found.</returns>
        public static int UniqueChar(string s)
        {
            string dots = ".";
            char hold;
            string used = "";
            for (int i = 0; i < s.Length; i++)
            {
                hold = s[i];
                s = dots + s.Remove(i, 1);
                if (!s.Contains(Char.ToString(hold)) && !used.Contains(Char.ToString(hold)))
                {
                    return i;
                }
                used += hold;
            }
            return -1;
        }
    }
}
