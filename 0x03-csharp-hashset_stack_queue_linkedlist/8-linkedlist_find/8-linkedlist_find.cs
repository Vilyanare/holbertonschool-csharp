using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = -1, count = 0;
        foreach (int nums in myLList)
        {
            if (nums == value)
            {
                index = count;
            }
            count++;
        }
        return index;
    }
}
