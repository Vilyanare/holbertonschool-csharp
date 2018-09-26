using System;

namespace Text
{
    /// <summary>
    /// Provides the IsPalindrome method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks to see if a string is a palindrome.
        /// </summary>
        /// <param name="s">String to check.</param>
        /// <returns><c>true</c>If string is a palindrome; otherwise, <c>false</c>.</returns>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int left = 0, right = s.Length - 1;
            while ((left != right) && (right >= 0) && (left < s.Length))
            {
                while ((left < s.Length) && (!Char.IsLower(s[left])))
                {
                    left++;
                }
                while ((right >= 0) && (!Char.IsLower(s[right])))
                {
                    right--;
                }
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
