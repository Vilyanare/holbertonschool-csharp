using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int hold = 0, count = 0;
        if (myLList.Count > 0)
        {
            foreach (int nums in myLList)
            {
                if (count == n)
                {
                    hold = nums;
                }
                count++;
            }
        }
        return hold;
    }
}
