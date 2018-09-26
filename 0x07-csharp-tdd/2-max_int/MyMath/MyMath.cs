using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides Max method.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds and returns highest integer in a list.
        /// </summary>
        /// <param name="nums">List of integers.</param>
        /// <returns>Returns highest interger or 0 if list is empty.</returns>
        public static int Max(List<int> nums)
        {
            int max = 0;
            if (nums.Count > 0)
            {
                foreach (int num in nums)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
            return max;
        }
    }
}
